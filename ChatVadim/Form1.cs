using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Runtime.InteropServices;
using System.IO;
using System.Text.RegularExpressions;

namespace ChatVadim
{
    public partial class Form1 : Form
    {
        //перемещение формы
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public int connection_count = -1; //кол-во серверов

        private delegate void printer(string data);
        private delegate void cleaner();
        printer Printer;
        cleaner Cleaner;
        private Socket _serverSocket;
        private Thread _clientThread;
        private string _serverHost = "127.0.0.1";
        private const int _serverPort = 2048;
        public Form1()
        {
            InitializeComponent();
            Printer = new printer(print);
            Cleaner = new cleaner(clearChat);
            chat_msg.Enabled = false;
            chat_send.Enabled = false;
            chat_listbox.Enabled = false;
            //connect();
            //_clientThread = new Thread(listner);
            //_clientThread.IsBackground = true;
            //_clientThread.Start();
        }

        private void listner() //"отловка" сообщений
        {
            while (_serverSocket.Connected)
            {
                byte[] buffer = new byte[8196];
                int bytesRec = _serverSocket.Receive(buffer);
                string data = Encoding.UTF8.GetString(buffer, 0, bytesRec); //переделываем полученный байт массив в читаемую строку
                if (data.Contains("#updatechat"))
                {
                    UpdateChat(data);
                    continue;
                }
                if (data.Contains("#updateonline"))
                {
                    UpdateOnline(data);
                    continue;
                }
            }
        }
        private void connect()
        {
            try
            {
                IPHostEntry ipHost = Dns.GetHostEntry(_serverHost);
                IPAddress ipAddress = ipHost.AddressList[0];
                IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, _serverPort);
                //_serverSocket = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                //_serverSocket.Connect(ipEndPoint);
                _serverSocket = new Socket(SocketType.Stream, ProtocolType.Tcp);
                _serverSocket.Connect(_serverHost, 2048);
            }
            catch { print("Сервер недоступен!"); }
        }
        private void clearChat()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(Cleaner);
                return;
            }
            chatBox.Clear();
        }
        private void UpdateChat(string data)
        {
            //#updatechat&userName~data|username~data
            //clearChat();
            string[] messages = data.Split('&')[1].Split('|');
            int countMessages = messages.Length;
            if (countMessages <= 0) return;
            for (int i = 0; i < countMessages; i++)
            {
                try
                {
                    if (string.IsNullOrEmpty(messages[i])) continue;
                    print(String.Format("[{0}]:{1}.", messages[i].Split('~')[0], messages[i].Split('~')[1]));
                }
                catch { continue; }
            }
        }
        private void UpdateOnline(string users)
        {
            try
            {
                string[] online_users = users.Split('&')[1].Split('|');
                //onlineBox.Text = online_users.ToString();
                onlineBox.Invoke(new Action(() => onlineBox.Text ="Online: \n" + string.Join("\n", online_users)));
            }
            catch(Exception exp) { onlineBox.Text = exp.ToString(); }
        }

        private void send(string data) // отправка байтового массива
        {
            try
            {
                byte[] buffer = Encoding.UTF8.GetBytes(data);
                int bytesSent = _serverSocket.Send(buffer);
            }
            catch { print("Связь с сервером прервалась..."); }
        }
        private void print(string msg)
        {           
            if (this.InvokeRequired)
            {
                this.Invoke(Printer, msg);
                return;
            }
            if (chatBox.Text.Length == 0)
                chatBox.AppendText(msg);
            else
                chatBox.Text += Environment.NewLine +  msg;
            chatBox.Focus();
            chatBox.Select(chatBox.Text.Length, 0);
            chat_msg.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //chat_listbox.Items.Insert(0, "New connection");
            //chat_listbox.SelectedIndex = 0;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enterChat_Click(object sender, EventArgs e)
        {            //при подключении создаем поток для отловки, отправляем на сервер сообщение с тегом о новом клиенте
            _serverHost = server_address.Text;
            connect();
            _clientThread = new Thread(listner);
            _clientThread.IsBackground = true;
            _clientThread.Start();

            string Name = userName.Text;
            if (string.IsNullOrEmpty(Name)) return;
            send("#setname&" + Name);
            chatBox.Enabled = true;
            chat_msg.Enabled = true;
            chat_send.Enabled = true;
            userName.Enabled = false;
            enterChat.Enabled = false;
            server_address.Enabled = false;
            connection_count++;
            chat_listbox.Items.Insert(connection_count, _serverHost);
            chat_listbox.SelectedIndex = connection_count;
        }

        private void chat_send_Click(object sender, EventArgs e)
        {
            sendMessage();
        }

        private void sendMessage()
        {
            try
            {
                string data = chat_msg.Text;
                if (string.IsNullOrEmpty(data)) return;
                if (!data.Contains("#personally"))
                    send("#newmsg&" + data);
                else //если отправляем персональное сообщение - прописываем его искуственно у себя
                {
                    chatBox.Text +=Environment.NewLine + "[" + userName.Text + "]:(personally)" + data.Split(')')[1];
                    send(data);
                    chat_listbox.Items.Add(userName.Text);
                }
                chat_msg.Text = string.Empty;
            }
            catch { MessageBox.Show("Ошибка при отправке сообщения!"); }
        }

        private void chatBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                sendMessage();
        }

        private void chat_msg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                sendMessage();
        }

        private void toolStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximaze_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                maximaze.Text = "Norm";
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                maximaze.Text = "Max";
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void toolStrip1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                maximaze.Text = "Norm";
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                maximaze.Text = "Max";
                this.WindowState = FormWindowState.Normal;
            }
        }     

        private void chat_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void private_message_Click(object sender, EventArgs e)
        {
            chat_msg.Text = "#personally@() " + chat_msg.Text;
        }

        private void chat_msg_TextChanged(object sender, EventArgs e)
        {
            if (chat_msg.Text.Length>60 & chat_msg.Multiline==false)
            {
                chat_msg.Multiline = true;
                chatBox.Height -= 50;
                chat_msg.Height += 50;
                chat_msg.Location = new Point(chat_msg.Location.X, chat_msg.Location.Y - 50);
            }
            if (chat_msg.Text.Length<60 & chat_msg.Multiline==true)
            {
                chat_msg.Multiline = false;
                chat_msg.Location = new Point(chat_msg.Location.X, chat_msg.Location.Y + 50);
                chat_msg.Height -= 50;
                chatBox.Height += 50;
            }
        }

        private void chatBox_TextChanged(object sender, EventArgs e)
        {
            var start = chatBox.Text.IndexOf('[', 0);
            var end = chatBox.Text.IndexOf(']', 0);
            chatBox.Select(start+1, end-1);
            chatBox.SelectionColor = Color.Green;
            while (start >-1)
            {
                start = chatBox.Text.IndexOf('[', start+1);
                end = chatBox.Text.IndexOf(']', end+1);
                chatBox.Select(start + 1, end-start - 1);
                    chatBox.SelectionColor = Color.Green;
            }
        }
    }
}
