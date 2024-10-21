using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Winform_Lab1
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        private bool Check_DateTime(int DD, int MM, int YYYY)
        {
            if (MM > 12 || MM < 1) return false;
            if (DD < 1) return false;
            if (MM == 1 || MM == 3 || MM == 5 || MM == 7 || MM == 8 || MM == 10 || MM == 12) if (DD > 31) return false;
            if (MM == 4 || MM == 6 || MM == 9 || MM == 11) if(DD>30) return false;
            if (YYYY > DateTime.Now.Year) return false;
            if((YYYY % 4==0 && YYYY%100!=0) || YYYY%400==0)
            {
                if (MM==2 && DD > 29) return false;
            }    
            else
            {
                if (MM == 2 && DD > 28) return false;
            }    
            return true;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int DD, MM, YYYY;
            

            DD = Int32.Parse(Masked_Input.Text.Substring(0, 2));
            MM = Int32.Parse(Masked_Input.Text.Substring(3, 2));
            YYYY = Int32.Parse(Masked_Input.Text.Substring(6,4));

            if (Check_DateTime(DD, MM, YYYY) == false)
            {
                MessageBox.Show("Không tồn tại ngày này!");
                return;
            }

            string Output_CungHoangDao="";

            switch (MM)
            {
                case 1:
                    Output_CungHoangDao = (DD <= 20) ? "Ma Kết" : "Bảo Bình";
                    break;
                case 2:
                    Output_CungHoangDao = (DD <= 19) ? "Bảo Bình" : "Song Ngư";
                    break;
                case 3:
                    Output_CungHoangDao = (DD <= 20) ? "Song Ngư" : "Bạch Dương";
                    break;
                case 4:
                    Output_CungHoangDao = (DD <= 20) ? "Bạch Dương" : "Kim Ngưu";
                    break;
                case 5:
                    Output_CungHoangDao = (DD <= 21) ? "Kim Ngưu" : "Song Tử";
                    break;
                case 6:
                    Output_CungHoangDao = (DD <= 21) ? "Song Tử" : "Cự Giải";
                    break;
                case 7:
                    Output_CungHoangDao = (DD <= 22) ? "Cự Giải" : "Sư Tử";
                    break;
                case 8:
                    Output_CungHoangDao = (DD <= 22) ? "Sư Tử" : "Xử Nữ";
                    break;
                case 9:
                    Output_CungHoangDao = (DD <= 23) ? "Xử Nữ" : "Thiên Bình";
                    break;
                case 10:
                    Output_CungHoangDao = (DD <= 23) ? "Thiên Bình" : "Thần Nông";
                    break;
                 case 11:
                    Output_CungHoangDao = (DD <= 22) ? "Thần Nông" : "Nhân Mã";
                    break;
                case 12:
                    Output_CungHoangDao = (DD <= 21) ? "Nhân Mã" : "Ma Kết";
                    break;
                default:
                    break;
            }

            MessageBox.Show("Bạn thuộc Cung Hoàng Đạo " + Output_CungHoangDao);


        }

        private void Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Nhập số!");
            }
        }
    }
}
