namespace Lab16OOP
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnSave = new Button();
            txtPort = new TextBox();
            txtHost = new TextBox();
            label2 = new Label();
            label1 = new Label();
            fontDialog1 = new FontDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(txtPort);
            groupBox1.Controls.Add(txtHost);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(8, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(607, 136);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Підключення";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(426, 44);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(139, 59);
            btnSave.TabIndex = 4;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(90, 83);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(285, 27);
            txtPort.TabIndex = 3;
            // 
            // txtHost
            // 
            txtHost.Location = new Point(90, 29);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(285, 27);
            txtHost.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 90);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 1;
            label2.Text = "Порт";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 32);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Адрес";
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 155);
            Controls.Add(groupBox1);
            Name = "SettingsForm";
            Text = "SettingsForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtPort;
        private TextBox txtHost;
        private Label label2;
        private Label label1;
        private FontDialog fontDialog1;
        private Button btnSave;
    }
}