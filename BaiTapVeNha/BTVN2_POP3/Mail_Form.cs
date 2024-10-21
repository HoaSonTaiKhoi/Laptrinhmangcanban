using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Pop3;
using MailKit.Net.Smtp;

namespace BTVN2_POP3
{
    public partial class Mail_Form : Form
    {
        public string Acccount, Password;

        public Mail_Form(Pop3Client client, string account, string password)
        {
            InitializeComponent();
            Tbx_Acc.Text = account;
            this.Acccount = account;
            this.Password = password;

            //Load các mail mới nhất
            var Limitation = client.GetMessageCount();
            for (int i = Limitation - 1; i >= 0; i--)
            {
                var message = client.GetMessage(i);
                ListViewItem item = new ListViewItem((Limitation - i).ToString());
                item.SubItems.Add(message.Subject);
                item.SubItems.Add(message.From.ToString());
                item.SubItems.Add(message.Date.ToString());
                Lsv_Mail.Items.Add(item);
            }
        }

        private void Btn_Send_Click(object sender, EventArgs e)
        {
            try
            {
                SendMail_Form form = new SendMail_Form(this);
                this.Hide();
                form.ShowDialog();
                form = null;
                this.Show();
            }
            catch
            {
                MessageBox.Show("Không thể tạo Email mới");
                return;
            }
        }
    }
}
