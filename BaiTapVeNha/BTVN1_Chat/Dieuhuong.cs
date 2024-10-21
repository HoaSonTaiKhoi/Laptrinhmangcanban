using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN1_Chat
{
    public partial class Dieuhuong : Form
    {
        public Dieuhuong()
        {
            InitializeComponent();
        }

        public void Btn_TcpServer_Click(object sender, EventArgs e)
        {
            Server server = new Server(this);
            server.Show();
            if (Btn_TcpServer.Enabled == true) Btn_TcpServer.Enabled = false;
        }

        private void Btn_TcpClient_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            Task.Run(() => client.ShowDialog());
        }
        public void Off()
        {
            Btn_TcpServer.Enabled = true;
        }
        
    }


}
