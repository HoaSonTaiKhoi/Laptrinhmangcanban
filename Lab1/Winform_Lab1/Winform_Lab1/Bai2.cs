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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void Input_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Input_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar!='.')
            {
                e.Handled = true;
                MessageBox.Show("Nhập số!");
            }
        }

        private void Button_Find_Click(object sender, EventArgs e)
        {
            float num1, num2, num3;

            if(Input_1.Text.Length<1 || Input_2.Text.Length<1|| Input_3.Text.Length<1) {
                MessageBox.Show("Có số chưa được nhập!");
                return;
            }

            num1=float.Parse(Input_1.Text);
            num2=float.Parse(Input_2.Text);
            num3=float.Parse(Input_3.Text);

            float Biggest_Num, Smallest_Num;
            Biggest_Num = num1 >= num2 ? (num1 >= num3 ? num1 : num3) : (num2 >= num3 ? num2 : num3);
            Smallest_Num = num1 <= num2 ? (num1 <= num3 ? num1 : num3) : (num2 <= num3 ? num2 : num3);

            Output_Big.Text = Biggest_Num.ToString();
            Output_Small.Text = Smallest_Num.ToString();
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

        private void Button_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
