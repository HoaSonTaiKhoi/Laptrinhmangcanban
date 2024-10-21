using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Winform_Lab1
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void Input_txt_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số nguyên!");
            }
        }

        private void Button_Tinh_Click(object sender, EventArgs e)
        {
            int num1, num2;
            if(String.IsNullOrEmpty(Input_txt_1.Text) ||String.IsNullOrEmpty(Input_txt_2.Text))
            {
                MessageBox.Show("Một trong 2 số còn thiếu!");
                return;
            }
            num1=Int32.Parse(Input_txt_1.Text);
            num2=Int32.Parse(Input_txt_2.Text);
            long sum = num1 + num2;
            Output_txt.Text=sum.ToString();
        }
    }
}
