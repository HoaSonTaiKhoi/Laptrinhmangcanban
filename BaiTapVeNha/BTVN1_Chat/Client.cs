using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BTVN1_Chat
{   
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        TcpClient tcpClient = new TcpClient();
        NetworkStream ns = null;


        private async void btnConnect_Click(object sender, EventArgs e)
        {
            if (Tbx_Name.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên người dùng");
                return;
            }
            IPEndPoint server = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            try
            {
                tcpClient = new TcpClient();
                tcpClient.Connect(server);
                ns = tcpClient.GetStream();
            }
            catch
            {
                MessageBox.Show("Không thể kết nối đến server!");
                return;
            }

            sendMessage(Tbx_Name.Text + $" đã gia nhập đoạn chat\n");
            Btn_Connect.Enabled = false;
            Btn_Connect.BackColor = Color.YellowGreen;
            Btn_Connect.Text = "Connected";
            Btn_Send.Enabled = true;
            Btn_Disconnect.Enabled = true;
            await Task.Run(() => ReceiveMessage());
        }
        void sendMessage(string message) //txtMessage
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            ns.Write(data, 0, data.Length);
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (Tbx_Send.Text == "")
            {
                MessageBox.Show("Không thể để trống phần message");
                return;
            }
            string sentData = Tbx_Name.Text + ": " + Tbx_Send.Text + "" + "\n";
            sendMessage(sentData);
            Tbx_Send.Text = "";
        }
        private async void ReceiveMessage()
        {
            while (tcpClient.Connected)
            {
                try
                {
                    if (ns.DataAvailable)
                    {
                        byte[] buffer = new byte[tcpClient.ReceiveBufferSize];
                        await ns.ReadAsync(buffer, 0, (int)tcpClient.ReceiveBufferSize);
                        string recvMess = Encoding.UTF8.GetString(buffer);
                        rtbListMessage.Text += recvMess + "\n";
                    }
                }
                catch
                {
                    return;
                }
            }
        }
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            sendMessage(Tbx_Name.Text + " đã rời khỏi đoạn chat\n");
            tcpClient.Close();
            ns.Close();
            rtbListMessage.Text = string.Empty;
            Btn_Connect.Enabled = true;
            Btn_Connect.BackColor = Client.DefaultBackColor;
            Btn_Connect.Text = "Connect";
            Btn_Send.Enabled = false;
            Btn_Disconnect.Enabled = false;
        }

        private void CloseTask(object sender, FormClosedEventArgs e)
        {
            if (tcpClient.Connected)
            {
                sendMessage(Tbx_Name.Text + " đã rời khỏi đoạn chat\n");
                tcpClient.Close();
                ns.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
