using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab16OOP
{
    public partial class Form1 : Form
    {
        bool alive = false; // чи буде працювати потік для приймання
        UdpClient client;
        const int LOCALPORT = 8001; // порт для приймання повідомлень
        const int REMOTEPORT = 8001; // порт для передавання повідомлень
        const int TTL = 20;
        int localPort = 8001;
        int remotePort = 8001;
        const string HOST = "235.5.5.1"; // хост для групового розсилання
        IPAddress groupAddress; // адреса для групового розсилання
        string userName; // ім’я користувача в чаті
        public Font ChatFont { get; set; }

        public Form1()
        {
            InitializeComponent();
            loginButton.Enabled = true; // кнопка входу
            logoutButton.Enabled = false; // кнопка виходу
            sendButton.Enabled = false; // кнопка отправки
            chatTextBox.ReadOnly = true; // поле для повідомлень
            groupAddress = IPAddress.Parse(HOST);

            lblHost.Text = $"Host: {HOST}";
            lblPort.Text = $"Port: {LOCALPORT}";
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            userName = userNameTextBox.Text;
            userNameTextBox.ReadOnly = true;
            try
            {
                client = new UdpClient(LOCALPORT);
                //підєднання до групового розсилання
                client.JoinMulticastGroup(groupAddress, TTL);

                // задача на приймання повідомлень
                Task receiveTask = new Task(ReceiveMessages);
                receiveTask.Start();
                // перше повідомлення про вхід нового користувача
                string message = userName + " вошел в чат";
                byte[] data = Encoding.Unicode.GetBytes(message);
                client.Send(data, data.Length, HOST, REMOTEPORT);
                loginButton.Enabled = false;
                logoutButton.Enabled = true;
                sendButton.Enabled = true;

                // Показати шлях до файлу логу
                ShowLogFilePath();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReceiveMessages()
        {
            alive = true;
            try
            {
                while (alive)
                {
                    IPEndPoint remoteIp = null;
                    byte[] data = client.Receive(ref remoteIp);
                    string message = Encoding.Unicode.GetString(data);
                    // добавляем полученное сообщение в текстовое поле
                    this.Invoke(new MethodInvoker(() =>
                    {
                        string time = DateTime.Now.ToShortTimeString();
                        string logMessage = $"{time} {message}";
                        chatTextBox.AppendText(logMessage + "\r\n");
                        SaveLog(logMessage);
                    }));
                }
            }
            catch (ObjectDisposedException)
            {
                if (!alive)
                    return;
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                string message = String.Format("{0}: {1}", userName, messageTextBox.Text);
                byte[] data = Encoding.Unicode.GetBytes(message);
                client.Send(data, data.Length, HOST, REMOTEPORT);
                SaveLog(message);
                messageTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            ExitChat();
        }

        // вихід з чату
        private void ExitChat()
        {
            string message = userName + " покидает чат";
            byte[] data = Encoding.Unicode.GetBytes(message);
            client.Send(data, data.Length, HOST, REMOTEPORT);
            client.DropMulticastGroup(groupAddress);
            alive = false;
            client.Close();
            loginButton.Enabled = true;
            logoutButton.Enabled = false;
            sendButton.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (alive)
                ExitChat();
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                ChatFont = fontDialog1.Font;
                chatTextBox.Font = ChatFont;
                messageTextBox.Font = ChatFont;
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Host = groupAddress.ToString();
            settingsForm.Port = localPort;

            if (settingsForm.ShowDialog() == DialogResult.OK)
            {
                groupAddress = IPAddress.Parse(settingsForm.Host);
                localPort = settingsForm.Port;
                remotePort = settingsForm.Port;

                lblHost.Text = $"Host: {settingsForm.Host}";
                lblPort.Text = $"Port: {settingsForm.Port}";
            }
        }

        private void SaveLog(string message)
        {
            string logFilePath = Path.Combine(Application.StartupPath, "chatLog.txt");
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"{DateTime.Now.ToShortTimeString()} {message}");
            }
        }

        private void ShowLogFilePath()
        {
            string logFilePath = Path.Combine(Application.StartupPath, "chatLog.txt");
            MessageBox.Show($"Журнал чату зберігається в: {logFilePath}", "Шлях до файлу журналу чату", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
