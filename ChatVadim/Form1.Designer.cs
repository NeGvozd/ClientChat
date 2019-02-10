namespace ChatVadim
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.labelq = new System.Windows.Forms.ToolStripLabel();
            this.server_address = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.userName = new System.Windows.Forms.ToolStripTextBox();
            this.enterChat = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.private_message = new System.Windows.Forms.ToolStripButton();
            this.exit_button = new System.Windows.Forms.ToolStripButton();
            this.maximaze = new System.Windows.Forms.ToolStripButton();
            this.minimize = new System.Windows.Forms.ToolStripButton();
            this.chat_listbox = new System.Windows.Forms.ListBox();
            this.chatBox = new System.Windows.Forms.RichTextBox();
            this.chat_msg = new System.Windows.Forms.RichTextBox();
            this.chat_send = new System.Windows.Forms.Button();
            this.onlineBox = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelq,
            this.server_address,
            this.toolStripLabel1,
            this.userName,
            this.enterChat,
            this.toolStripSeparator3,
            this.private_message,
            this.exit_button,
            this.maximaze,
            this.minimize});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(950, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseDoubleClick);
            this.toolStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseMove);
            // 
            // labelq
            // 
            this.labelq.Name = "labelq";
            this.labelq.Size = new System.Drawing.Size(85, 22);
            this.labelq.Text = "Server address:";
            // 
            // server_address
            // 
            this.server_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.server_address.Name = "server_address";
            this.server_address.Size = new System.Drawing.Size(150, 25);
            this.server_address.Text = "25.60.255.151";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel1.Text = "Your nik:";
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.SystemColors.Info;
            this.userName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(100, 25);
            // 
            // enterChat
            // 
            this.enterChat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.enterChat.Image = ((System.Drawing.Image)(resources.GetObject("enterChat.Image")));
            this.enterChat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.enterChat.Name = "enterChat";
            this.enterChat.Size = new System.Drawing.Size(41, 22);
            this.enterChat.Text = "Enter!";
            this.enterChat.Click += new System.EventHandler(this.enterChat_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // private_message
            // 
            this.private_message.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.private_message.Image = ((System.Drawing.Image)(resources.GetObject("private_message.Image")));
            this.private_message.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.private_message.Name = "private_message";
            this.private_message.Size = new System.Drawing.Size(96, 22);
            this.private_message.Text = "Private Message";
            this.private_message.Click += new System.EventHandler(this.private_message_Click);
            // 
            // exit_button
            // 
            this.exit_button.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exit_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exit_button.Image = ((System.Drawing.Image)(resources.GetObject("exit_button.Image")));
            this.exit_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(29, 22);
            this.exit_button.Text = "Exit";
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // maximaze
            // 
            this.maximaze.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.maximaze.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.maximaze.Image = ((System.Drawing.Image)(resources.GetObject("maximaze.Image")));
            this.maximaze.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.maximaze.Name = "maximaze";
            this.maximaze.Size = new System.Drawing.Size(33, 22);
            this.maximaze.Text = "Max";
            this.maximaze.Click += new System.EventHandler(this.maximaze_Click);
            // 
            // minimize
            // 
            this.minimize.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.minimize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(32, 22);
            this.minimize.Text = "Min";
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // chat_listbox
            // 
            this.chat_listbox.BackColor = System.Drawing.Color.White;
            this.chat_listbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.chat_listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chat_listbox.FormattingEnabled = true;
            this.chat_listbox.ItemHeight = 20;
            this.chat_listbox.Location = new System.Drawing.Point(0, 25);
            this.chat_listbox.Name = "chat_listbox";
            this.chat_listbox.Size = new System.Drawing.Size(241, 425);
            this.chat_listbox.TabIndex = 1;
            this.chat_listbox.SelectedIndexChanged += new System.EventHandler(this.chat_listbox_SelectedIndexChanged);
            // 
            // chatBox
            // 
            this.chatBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatBox.BackColor = System.Drawing.Color.LightGray;
            this.chatBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chatBox.Location = new System.Drawing.Point(241, 25);
            this.chatBox.Margin = new System.Windows.Forms.Padding(0);
            this.chatBox.Name = "chatBox";
            this.chatBox.ReadOnly = true;
            this.chatBox.Size = new System.Drawing.Size(559, 396);
            this.chatBox.TabIndex = 2;
            this.chatBox.Text = "";
            this.chatBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chatBox_KeyDown);
            // 
            // chat_msg
            // 
            this.chat_msg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chat_msg.AutoWordSelection = true;
            this.chat_msg.BackColor = System.Drawing.Color.Gainsboro;
            this.chat_msg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chat_msg.EnableAutoDragDrop = true;
            this.chat_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chat_msg.Location = new System.Drawing.Point(241, 419);
            this.chat_msg.Multiline = false;
            this.chat_msg.Name = "chat_msg";
            this.chat_msg.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.chat_msg.Size = new System.Drawing.Size(493, 31);
            this.chat_msg.TabIndex = 3;
            this.chat_msg.Text = "";
            this.chat_msg.TextChanged += new System.EventHandler(this.chat_msg_TextChanged);
            this.chat_msg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chat_msg_KeyDown);
            // 
            // chat_send
            // 
            this.chat_send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chat_send.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.chat_send.Cursor = System.Windows.Forms.Cursors.Default;
            this.chat_send.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chat_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chat_send.Location = new System.Drawing.Point(733, 419);
            this.chat_send.Margin = new System.Windows.Forms.Padding(0);
            this.chat_send.Name = "chat_send";
            this.chat_send.Size = new System.Drawing.Size(70, 31);
            this.chat_send.TabIndex = 4;
            this.chat_send.Text = "Send!";
            this.chat_send.UseVisualStyleBackColor = false;
            this.chat_send.Click += new System.EventHandler(this.chat_send_Click);
            // 
            // onlineBox
            // 
            this.onlineBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.onlineBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.onlineBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.onlineBox.Location = new System.Drawing.Point(800, 25);
            this.onlineBox.Margin = new System.Windows.Forms.Padding(0);
            this.onlineBox.Name = "onlineBox";
            this.onlineBox.ReadOnly = true;
            this.onlineBox.Size = new System.Drawing.Size(150, 425);
            this.onlineBox.TabIndex = 5;
            this.onlineBox.Text = "Online:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.onlineBox);
            this.Controls.Add(this.chat_send);
            this.Controls.Add(this.chat_msg);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.chat_listbox);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton exit_button;
        private System.Windows.Forms.ListBox chat_listbox;
        private System.Windows.Forms.RichTextBox chatBox;
        private System.Windows.Forms.RichTextBox chat_msg;
        private System.Windows.Forms.Button chat_send;
        private System.Windows.Forms.ToolStripTextBox userName;
        private System.Windows.Forms.ToolStripButton enterChat;
        private System.Windows.Forms.ToolStripButton minimize;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton maximaze;
        private System.Windows.Forms.ToolStripLabel labelq;
        private System.Windows.Forms.ToolStripTextBox server_address;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton private_message;
        public System.Windows.Forms.RichTextBox onlineBox;
    }
}

