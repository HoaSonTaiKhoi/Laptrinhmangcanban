using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Lab1
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void Button_Read_Click(object sender, EventArgs e)
        {
            int a;
            if(InputText.Text.Length>1 || InputText.Text.Length<1 || Int32.TryParse(InputText.Text, out a)==false)
            {
                MessageBox.Show("Không hợp lệ! Nhập lại!");
                return;
            }    
            Dictionary<int, string> dict_num = new Dictionary<int, string>();
            dict_num.Add(0, "Không");
            dict_num.Add(1, "Một");
            dict_num.Add(2, "Hai");
            dict_num.Add(3, "Ba");
            dict_num.Add(4, "Bốn");
            dict_num.Add(5, "Năm");
            dict_num.Add(6, "Sáu");
            dict_num.Add(7, "Bảy");
            dict_num.Add(8, "Tám");
            dict_num.Add(9, "Chín");

            OutputText.Text= dict_num[a].ToString();
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = string.Empty;
                }
            }
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       
    }
}
