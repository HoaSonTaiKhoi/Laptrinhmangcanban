using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Lab1
{
    public partial class Bai8 : Form
    {
        public Bai8()
        {
            InitializeComponent();
        }

        private void Btn_Del_All_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBoxBase)
                    ctrl.Text = String.Empty;
            }
            List_Food.Items.Clear();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TBx_Input.Text))
            {
                MessageBox.Show("Không có thông tin!");
                return;
            }

            List_Food.Items.Add(TBx_Input.Text);
            TBx_Input.Clear();
            TBx_Input.Focus();
        }

        private void TBx_Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && e.KeyChar != ' ' && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không nhập ký tự lạ!");
            }
        }

        private void Btn_Del_1_Click(object sender, EventArgs e)
        {
            List_Food.Items.RemoveAt(List_Food.SelectedIndex);
            TBx_Del_1.Text = "";
        }


        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void List_Food_SelectedValueChanged(object sender, EventArgs e)
        {
            if (List_Food.SelectedItem == null) return;
            TBx_Del_1.Text = List_Food.SelectedItem.ToString();
            
        }

        private void Btn_Find_Click(object sender, EventArgs e)
        {
            if(List_Food.Items.Count == 0)
            {
                MessageBox.Show("Không có món ăn nào trong List!");
                return;
            } 
                
            Random rand = new Random();
            int SelectIndex = rand.Next(0, List_Food.Items.Count);
            rand = null;
            TBx_Output.Text = List_Food.Items[SelectIndex].ToString();
        }
    }
}
