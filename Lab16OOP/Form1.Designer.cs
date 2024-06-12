namespace Lab16OOP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            lblPort = new Label();
            lblHost = new Label();
            btnFont = new Button();
            settingsButton = new Button();
            logoutButton = new Button();
            loginButton = new Button();
            userNameTextBox = new TextBox();
            label1 = new Label();
            chatTextBox = new TextBox();
            messageTextBox = new TextBox();
            sendButton = new Button();
            fontDialog1 = new FontDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblPort);
            groupBox1.Controls.Add(lblHost);
            groupBox1.Controls.Add(btnFont);
            groupBox1.Controls.Add(settingsButton);
            groupBox1.Controls.Add(logoutButton);
            groupBox1.Controls.Add(loginButton);
            groupBox1.Controls.Add(userNameTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(11, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(778, 118);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // lblPort
            // 
            lblPort.AutoSize = true;
            lblPort.Location = new Point(217, 83);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(44, 20);
            lblPort.TabIndex = 7;
            lblPort.Text = "Порт";
            // 
            // lblHost
            // 
            lblHost.AutoSize = true;
            lblHost.Location = new Point(6, 83);
            lblHost.Name = "lblHost";
            lblHost.Size = new Size(40, 20);
            lblHost.TabIndex = 6;
            lblHost.Text = "Хост";
            // 
            // btnFont
            // 
            btnFont.Location = new Point(676, 64);
            btnFont.Name = "btnFont";
            btnFont.Size = new Size(95, 39);
            btnFont.TabIndex = 5;
            btnFont.Text = "Текст";
            btnFont.UseVisualStyleBackColor = true;
            btnFont.Click += btnFont_Click;
            // 
            // settingsButton
            // 
            settingsButton.Image = (Image)resources.GetObject("settingsButton.Image");
            settingsButton.Location = new Point(676, 18);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(96, 40);
            settingsButton.TabIndex = 4;
            settingsButton.Text = "Порт";
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += settingsButton_Click;
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(504, 64);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(104, 39);
            logoutButton.TabIndex = 3;
            logoutButton.Text = "Виход";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(504, 18);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(104, 40);
            loginButton.TabIndex = 2;
            loginButton.Text = "Вход";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(118, 31);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(318, 27);
            userNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 0;
            label1.Text = "Введіть ім'я";
            // 
            // chatTextBox
            // 
            chatTextBox.Location = new Point(11, 131);
            chatTextBox.Multiline = true;
            chatTextBox.Name = "chatTextBox";
            chatTextBox.Size = new Size(777, 234);
            chatTextBox.TabIndex = 1;
            // 
            // messageTextBox
            // 
            messageTextBox.Location = new Point(12, 371);
            messageTextBox.Multiline = true;
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(533, 69);
            messageTextBox.TabIndex = 2;
            // 
            // sendButton
            // 
            sendButton.Location = new Point(551, 371);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(238, 69);
            sendButton.TabIndex = 3;
            sendButton.Text = "Отправить";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 449);
            Controls.Add(sendButton);
            Controls.Add(messageTextBox);
            Controls.Add(chatTextBox);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button logoutButton;
        private Button loginButton;
        private TextBox userNameTextBox;
        private Label label1;
        private TextBox chatTextBox;
        private TextBox messageTextBox;
        private Button sendButton;
        private Button settingsButton;
        private Button btnFont;
        private FontDialog fontDialog1;
        private Label lblPort;
        private Label lblHost;
    }
}
