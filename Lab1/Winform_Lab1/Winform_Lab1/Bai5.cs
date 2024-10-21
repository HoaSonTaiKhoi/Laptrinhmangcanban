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

    
    public partial class Bai5 : Form
    {
       

        public Bai5()
        {
            InitializeComponent();
            List<string> List_Func = new List<string>()
            {
                "Bảng cửu chương","Tính toán giá trị"
            };
            
            CBox_Func.DataSource= List_Func;
            CBox_Func.DisplayMember = "Function";
        }


        private long Giai_Thua(int x)
        {
            if (x == 0) return 1;
            long giai_thua = 1;
            for (int i = 1; i <= x; i++) giai_thua *= i;
            return giai_thua;
        }

        private double Tong_S(int A, int B)
        {
            double S = 0;
            for(int i=1; i<= B; i++)
            {
                S += Math.Pow(A, i);
            }
            return S;
        }

        private void Btn_Calc_Click(object sender, EventArgs e)
        {
            if (Input_A.Text.Length < 1 || Input_B.Text.Length < 1)
            {
                MessageBox.Show("Có số chưa được nhập!");
                return;
            }

            if (CBox_Func.SelectedIndex == 0)
            {

                int In_Num=int.Parse(Input_B.Text) - int.Parse(Input_A.Text);
                if (In_Num < 0)
                {
                    
                    MessageBox.Show("Không thể lập bảng cửu chương với số âm");
                    return;
                }
                System.Windows.Forms.TextBox OutBox_1 = new System.Windows.Forms.TextBox();
                System.Windows.Forms.TextBox OutBox_2 = new System.Windows.Forms.TextBox();

                //OutputBox1
                OutBox_1.Location = new System.Drawing.Point(40, 60);
                OutBox_1.Name = "Output_Box_1";
                OutBox_1.Size = new System.Drawing.Size(200, 160);
                OutBox_1.TabIndex = 9;
                OutBox_1.ReadOnly = true;
                OutBox_1.Multiline = true;
                OutBox_1.TextAlign = HorizontalAlignment.Left;
                OutBox_1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                

                //OutputBox2
                OutBox_2.Location = new System.Drawing.Point(280, 60);
                OutBox_2.Name = "Output_Box_2";
                OutBox_2.Size = new System.Drawing.Size(200, 160);
                OutBox_2.TabIndex = 9;
                OutBox_2.ReadOnly = true;
                OutBox_2.Multiline = true;
                OutBox_2.TextAlign = HorizontalAlignment.Left;
                OutBox_2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                //Calculate
                for(int i=0; i<5; i++)
                {
                    OutBox_1.Text += "        "+In_Num.ToString() + " x " + (i + 1).ToString() + " = " + (In_Num * (i + 1)).ToString() +Environment.NewLine;
                    OutBox_2.Text += "        "+In_Num.ToString() + " x " + (i + 6).ToString() + " = " + (In_Num * (i + 6)).ToString() +Environment.NewLine;
                }

                //GroupBox Add
                GrBox_Output.Controls.Clear();
                GrBox_Output.Text = "Bảng cửu chương " + In_Num.ToString();
                GrBox_Output.Controls.Add(OutBox_1);
                GrBox_Output.Controls.Add(OutBox_2);


            }
            else if(CBox_Func.SelectedIndex==1)
            {
                int A = int.Parse(Input_A.Text), B= int.Parse(Input_B.Text), In_Num=A-B;
                if (In_Num < 0)
                {

                    MessageBox.Show("Không thể tính toán với số âm");
                    return;
                }
                System.Windows.Forms.TextBox OutBox_1 = new System.Windows.Forms.TextBox();
                System.Windows.Forms.TextBox OutBox_2 = new System.Windows.Forms.TextBox();

                //OutputBox1
                OutBox_1.Location = new System.Drawing.Point(40, 60);
                OutBox_1.Name = "Output_Box_1";
                OutBox_1.Size = new System.Drawing.Size(450, 80);
                OutBox_1.TabIndex = 9;
                OutBox_1.ReadOnly = true;
                OutBox_1.Multiline = true;
                OutBox_1.TextAlign = HorizontalAlignment.Left;
                OutBox_1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                //OutputBox2
                OutBox_2.Location = new System.Drawing.Point(40, 150);
                OutBox_2.Name = "Output_Box_2";
                OutBox_2.Size = new System.Drawing.Size(450, 80);
                OutBox_2.TabIndex = 9;
                OutBox_2.ReadOnly = true;
                OutBox_2.Multiline = true;
                OutBox_2.TextAlign = HorizontalAlignment.Left;
                OutBox_2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                OutBox_1.Text = "(" + Input_A.Text + " - " + Input_B.Text + ")! = " + Giai_Thua(In_Num).ToString();
                OutBox_2.Text = "S = " + Tong_S(A, B).ToString();
                GrBox_Output.Controls.Clear();
                GrBox_Output.Text = "Tính toán giá trị";
                GrBox_Output.Controls.Add(OutBox_1);
                GrBox_Output.Controls.Add(OutBox_2);
            }    
        }

        private void CBox_Func_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            int SelectedIndex = cmb.SelectedIndex;

        }

        private void Input_A_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("Nhập số!");
            }
        }

        private void Btn_Del_Click(object sender, EventArgs e)
        {
            foreach(Control ctrl in this.Controls)
            {
                if(ctrl is TextBoxBase)
                {
                    ctrl.Text = string.Empty;
                }
                GrBox_Output.Controls.Clear();
            }    
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
