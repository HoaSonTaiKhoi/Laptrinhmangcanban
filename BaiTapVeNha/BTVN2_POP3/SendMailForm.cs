using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MimeKit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTVN2_POP3
{
    public partial class SendMail_Form : Form
    {
        private Mail_Form form;
        public SendMail_Form(Mail_Form form)
        {
            InitializeComponent();
            this.form = form;
            Tbx_User.Text = form.Acccount;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Send_Click(object sender, EventArgs e)
        {
            if (Tbx_Recv.Text == "" || Tbx_Subject.Text == "" || Rtbx_Content.Text == "")
            {
                MessageBox.Show("Lack of Information");
                return;
            }
            var client = new SmtpClient();
            try
            {
                client.Connect("smtp.gmail.com", 465, true);
                client.Authenticate(Tbx_User.Text, form.Password);
            }
            catch
            {
                MessageBox.Show("Failed!");
                return;
            }
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("", form.Acccount));
            message.To.Add(new MailboxAddress("", Tbx_Recv.Text));
            message.Subject = Tbx_Subject.Text;
            message.Body = new TextPart("plain") { Text = Rtbx_Content.Text };
            client.Send(message);
            MessageBox.Show("Email Sent Successfully!");
        }
    }
}
