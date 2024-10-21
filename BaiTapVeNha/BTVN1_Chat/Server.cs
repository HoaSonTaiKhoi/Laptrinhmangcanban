using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTVN1_Chat;

namespace BTVN1_Chat
{
    public partial class Server : Form
    {
        public bool isOpen = false;
        private bool isListen = false;
        Dieuhuong form;
        public Server(Dieuhuong form)
        {
            this.form = form;
            InitializeComponent();
            isOpen = true;
        }

        Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Thread serverThread;
        List<Socket> clientList = new List<Socket>();
        async void StartUnsafeThread()
        {
            try
            {
                IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
                listenerSocket.Bind(ipepServer);
                listenerSocket.Listen(-1);
            }
            catch
            {
                MessageBox.Show("Server is already running!!!");
                return;
            }
            Rtbx_Message.Text += "Server is running on 127.0.0.1:8080\n";
            while (true)
            {
                Socket clientSocket = await listenerSocket.AcceptAsync();
                clientList.Add(clientSocket);
                Thread thr = new Thread(() => HandleClient(clientSocket));
                thr.Start();
            }
        }
        void HandleClient(Socket clientSocket)
        {
            int bytesReceived = 0;
            while (true)
            {
                byte[] recv = new byte[100];

                string text = "";
                do
                {
                    try
                    {
                        bytesReceived = clientSocket.Receive(recv);
                    }
                    catch
                    {
                        clientSocket.Close();
                        clientList.Remove(clientSocket);
                        return;
                    }
                    //MessageBox.Show(bytesReceived.ToString());
                    /*if (bytesReceived == 0)
                    {
                        
                    }*/
                    text += Encoding.UTF8.GetString(recv);
                } while (text.EndsWith("\n"));
                Rtbx_Message.Text += clientSocket.RemoteEndPoint + ": " + text;
                BroadcastMessage(text);

            }
        }
        void BroadcastMessage(string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            foreach (Socket client in clientList)
            {
                // Don't send the message back to the sender
                client.Send(data);
            }
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!isListen)
            {
                CheckForIllegalCrossThreadCalls = false;
                serverThread = new Thread(new ThreadStart(StartUnsafeThread));
                serverThread.Start();
                Btn_Listen.BackColor = System.Drawing.Color.Lime;
                isListen = true;
            }
            else
            {
                isListen = false;
                Btn_Listen.BackColor = System.Drawing.Color.White;
            }
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            isOpen = false;
            form.Off();
        }
    }
}
