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
            this.exit_button = new System.Windows.Forms.ToolStripButton();
            this.maximaze = new System.Windows.Forms.ToolStripButton();
            this.minimize = new System.Windows.Forms.ToolStripButton();
            this.chatBox = new System.Windows.Forms.RichTextBox();
            this.chat_msg = new System.Windows.Forms.RichTextBox();
            this.onlineBox = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.chat_send = new System.Windows.Forms.ToolStripButton();
            this.private_message = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
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
            this.exit_button,
            this.maximaze,
            this.minimize});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(747, 25);
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
            this.server_address.Size = new System.Drawing.Size(100, 25);
            this.server_address.Text = "25.60.255.151";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(1, 1, 0, 2);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel1.Text = "Your nik:";
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.SystemColors.Window;
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
            // exit_button
            // 
            this.exit_button.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exit_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exit_button.Image = ((System.Drawing.Image)(resources.GetObject("exit_button.Image")));
            this.exit_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(29, 22);
            this.exit_button.Text = "Exit";
            this.exit_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            this.exit_button.MouseEnter += new System.EventHandler(this.exit_button_MouseEnter);
            this.exit_button.MouseLeave += new System.EventHandler(this.exit_button_MouseLeave);
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
            // chatBox
            // 
            this.chatBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatBox.BackColor = System.Drawing.Color.White;
            this.chatBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chatBox.Location = new System.Drawing.Point(0, 0);
            this.chatBox.Margin = new System.Windows.Forms.Padding(0);
            this.chatBox.Name = "chatBox";
            this.chatBox.ReadOnly = true;
            this.chatBox.Size = new System.Drawing.Size(588, 303);
            this.chatBox.TabIndex = 2;
            this.chatBox.Text = "";
            this.chatBox.TextChanged += new System.EventHandler(this.chatBox_TextChanged);
            this.chatBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chatBox_KeyDown);
            // 
            // chat_msg
            // 
            this.chat_msg.AcceptsTab = true;
            this.chat_msg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chat_msg.AutoWordSelection = true;
            this.chat_msg.BackColor = System.Drawing.Color.Gainsboro;
            this.chat_msg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chat_msg.EnableAutoDragDrop = true;
            this.chat_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chat_msg.Location = new System.Drawing.Point(3, 25);
            this.chat_msg.Margin = new System.Windows.Forms.Padding(0);
            this.chat_msg.Name = "chat_msg";
            this.chat_msg.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.chat_msg.Size = new System.Drawing.Size(585, 94);
            this.chat_msg.TabIndex = 3;
            this.chat_msg.Text = "";
            this.chat_msg.TextChanged += new System.EventHandler(this.chat_msg_TextChanged);
            this.chat_msg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chat_msg_KeyDown);
            // 
            // onlineBox
            // 
            this.onlineBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.onlineBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.onlineBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.onlineBox.ForeColor = System.Drawing.Color.Black;
            this.onlineBox.Location = new System.Drawing.Point(0, 0);
            this.onlineBox.Margin = new System.Windows.Forms.Padding(0);
            this.onlineBox.Name = "onlineBox";
            this.onlineBox.ReadOnly = true;
            this.onlineBox.ShortcutsEnabled = false;
            this.onlineBox.Size = new System.Drawing.Size(152, 423);
            this.onlineBox.TabIndex = 5;
            this.onlineBox.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1MinSize = 120;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.onlineBox);
            this.splitContainer1.Panel2MinSize = 120;
            this.splitContainer1.Size = new System.Drawing.Size(747, 425);
            this.splitContainer1.SplitterDistance = 591;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 6;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.chatBox);
            this.splitContainer2.Panel1MinSize = 100;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.toolStrip2);
            this.splitContainer2.Panel2.Controls.Add(this.chat_msg);
            this.splitContainer2.Panel2MinSize = 80;
            this.splitContainer2.Size = new System.Drawing.Size(593, 427);
            this.splitContainer2.SplitterDistance = 302;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chat_send,
            this.toolStripSeparator2,
            this.private_message});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip2.Size = new System.Drawing.Size(591, 25);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // chat_send
            // 
            this.chat_send.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.chat_send.Image = ((System.Drawing.Image)(resources.GetObject("chat_send.Image")));
            this.chat_send.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.chat_send.Name = "chat_send";
            this.chat_send.Size = new System.Drawing.Size(105, 22);
            this.chat_send.Text = "Send Message!";
            this.chat_send.Click += new System.EventHandler(this.chat_send_Click);
            // 
            // private_message
            // 
            this.private_message.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.private_message.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.private_message.Image = ((System.Drawing.Image)(resources.GetObject("private_message.Image")));
            this.private_message.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.private_message.Name = "private_message";
            this.private_message.Size = new System.Drawing.Size(96, 22);
            this.private_message.Text = "Private Message";
            this.private_message.Click += new System.EventHandler(this.private_message_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton exit_button;
        private System.Windows.Forms.RichTextBox chatBox;
        private System.Windows.Forms.RichTextBox chat_msg;
        private System.Windows.Forms.ToolStripTextBox userName;
        private System.Windows.Forms.ToolStripButton enterChat;
        private System.Windows.Forms.ToolStripButton minimize;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton maximaze;
        private System.Windows.Forms.ToolStripLabel labelq;
        private System.Windows.Forms.ToolStripTextBox server_address;
        public System.Windows.Forms.RichTextBox onlineBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton chat_send;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton private_message;
    }
}

