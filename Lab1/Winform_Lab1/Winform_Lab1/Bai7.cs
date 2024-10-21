using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Lab1
{
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
        }

        private void Input_Array_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && e.KeyChar!=',' && e.KeyChar!=' ' && e.KeyChar != '.' && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không nhập ký tự lạ!");
            }
        }

        private float Average_Score(float[] array_score)
        {
            float Average_Score = 0;
            foreach (float score in array_score) { Average_Score += score; }
            return Average_Score / array_score.Length;
        }


        private float Highest_Score(float[] array_score)
        {
            float Highest_Score = -1;
            foreach(float score in array_score) { if(Highest_Score<score) Highest_Score = score; }
            return Highest_Score;
        }

        private float Lowest_Score(float[] array_score)
        {
            float Lowest_Score = 10;
            foreach (float score in array_score) { if (Lowest_Score > score) Lowest_Score = score; }
            return Lowest_Score;
        }

        private int Num_Not_Pass_Subject(float[] array_score)
        {
            int Num_Not_Pass = 0;
            foreach(float score in array_score) if(score<5.0) Num_Not_Pass++;
            return Num_Not_Pass;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            
        }

        private void Btn_Calc_Click(object sender, EventArgs e)
        {
            OutBox_1.Clear();


            if (Input_Array.Text.Length < 1)
            {
                MessageBox.Show("Không có thông tin!");
                return;
            }

            string[] words = Input_Array.Text.Split(',');
            //Return condition
            string User_Name = words[0];

            if (float.TryParse(words[0], out float tmp)) { MessageBox.Show("Chưa nhập tên!"); return; }
            foreach (char c in User_Name) if (int.TryParse(c.ToString(), out int tp)) { MessageBox.Show("Trong tên không được có số!"); return; }
            if (words.Length < 2 ) { MessageBox.Show("Chưa nhập điểm!"); return; }


            foreach (string word in words)
            {
                word.Replace(" ", "");
            }

            Dictionary<int, string> Rate = new Dictionary<int, string>()
            {
                {0, "Kém"},
                {1,  "Yếu"},
                {2, "TB"},
                {3,"Khá" },
                {4,"Giỏi"}
            };

            //

            float[] array_score = new float[words.Length - 1];
            int Rate_score = 4;
            for (int i = 1; i < words.Length; i++)
            {
                if (!float.TryParse(words[i], out array_score[i-1])) { MessageBox.Show("Chưa nhập điểm!"); return; }
                int temp = Rate_score;
                if (array_score[i - 1] < 2) Rate_score = 0;
                else if (array_score[i - 1] < 3.5) Rate_score = 1;
                else if (array_score[i - 1] < 5) Rate_score = 2;
                else if (array_score[i - 1] < 6.5) Rate_score = 3;
                else Rate_score = 4;
                if (temp < Rate_score) Rate_score = temp;
                if (array_score[i - 1] < 0 || array_score[i - 1] > 10)
                {
                    MessageBox.Show("Điểm không hợp lệ!");
                    return;
                }
            }



            //
            float DTB = Average_Score(array_score);

            OutBox_1.Text += "Họ và Tên: " + User_Name + Environment.NewLine;
            for (int i = 0; i < array_score.Length; i++) { OutBox_1.Text += "Môn " + (i + 1).ToString() + ": " + array_score[i].ToString() + "    "; }
            OutBox_1.Text += Environment.NewLine;
            OutBox_1.Text += "Điểm trung bình: " + DTB.ToString() + Environment.NewLine;
            OutBox_1.Text += "Điểm cao nhất: " + Highest_Score(array_score).ToString() + "; Điểm thấp nhất: " + Lowest_Score(array_score) + Environment.NewLine;
            OutBox_1.Text += "Số môn đậu: " + (array_score.Length - Num_Not_Pass_Subject(array_score)).ToString() + "; Số môn không đậu: " + Num_Not_Pass_Subject(array_score).ToString() + Environment.NewLine;

            //Rate
            if (DTB >= 8) { }
            else if (DTB >= 6.5) { if (Rate_score > 3) Rate_score = 3; }
            else if (DTB >= 5) { if (Rate_score > 2) Rate_score = 2; }
            else if (DTB >= 3.5) { if (Rate_score > 1) Rate_score = 1; }




            OutBox_1.Text += "Xếp loại: " + Rate[Rate_score].ToString();

            this.Controls.Add(OutBox_1);
        }

        private void Btn_Del_All_Click(object sender, EventArgs e)
        {
            foreach(Control ctrl in this.Controls)
            {
                if(ctrl is TextBoxBase) { ctrl.Text = String.Empty; }
            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
