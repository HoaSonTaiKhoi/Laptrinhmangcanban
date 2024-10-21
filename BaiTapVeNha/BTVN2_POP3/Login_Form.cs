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

namespace BTVN2_POP3
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if (Tbx_Acc.Text == string.Empty || Tbx_Pass.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đủ tên đăng nhập và mật khẩu!");
                return;
            }
            var client = new Pop3Client();
            try
            {
                client.Connect("pop.gmail.com", 995, true);
                client.Authenticate(Tbx_Acc.Text, Tbx_Pass.Text);
                Mail_Form mail = new Mail_Form(client, Tbx_Acc.Text, Tbx_Pass.Text);
                this.Hide();
                mail.ShowDialog();
                mail = null;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Login Failed");
                return;
            }
        }
    }
}
