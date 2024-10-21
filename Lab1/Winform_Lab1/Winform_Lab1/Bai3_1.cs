using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Lab1
{
    public partial class Bai3_1 : Form
    {
        public Bai3_1()
        {
            InitializeComponent();
        }

        private void Read3(int tram, int chuc, int donvi, Dictionary<int, string> dict)
        {
            if (tram >0) OutputText.Text += dict[tram].ToString() + " Trăm ";
            else if (tram == 0) OutputText.Text += "Không Trăm ";
            if (chuc == 0 && donvi == 0) return;
            if (chuc > 1) OutputText.Text += dict[chuc].ToString() + " Mươi ";
            else if (chuc == 1) OutputText.Text += "Mười ";
            else if (chuc == 0) OutputText.Text += "Lẻ ";
            
            if (donvi == 0) return;
            else if (donvi == 1 && chuc > 1 ) OutputText.Text += "Mốt ";
            else if(chuc!=0 && donvi==5) OutputText.Text += "Lăm ";
            else if (donvi > 0) OutputText.Text += dict[donvi].ToString() + " ";
        }
        private void Button_Read_Click(object sender, EventArgs e)
        {
            OutputText.Text = "";
            int [] array_Input= new int[12];
            long a;
            bool check_0 = false;
            if (InputText.Text.Length > 12 || InputText.Text.Length < 1 || long.TryParse(InputText.Text, out a) == false)
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

            // Donvi
            Dictionary<int, string> dict_value= new Dictionary<int, string>();
            dict_value.Add(0, "Tỷ ");
            dict_value.Add(1, "Triệu ");
            dict_value.Add(2, "Nghìn ");
            dict_value.Add(3, "");
            for(int i=0; i<12; i++)
            {
                if(12-i<=InputText.Text.Length)
                {
                    array_Input[i] = Int32.Parse(InputText.Text[i + InputText.Text.Length - 12].ToString());
                    if (array_Input[i]>0) check_0= true; 
                    else if (array_Input[i] == 0 && check_0 == false) { array_Input[i] = -1;}
                   
                }
                else array_Input[i] = -1;
            }

            for(int i=0; i<4; i++)
            {
                if (array_Input[i*3]<0 && array_Input[i*3+1]<0 && array_Input[i*3+2]<0) { }
                else
                {
                    Read3(array_Input[i * 3], array_Input[i * 3 + 1], array_Input[i * 3 + 2], dict_num);
                    OutputText.Text += dict_value[i];
                }    
            }    
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
