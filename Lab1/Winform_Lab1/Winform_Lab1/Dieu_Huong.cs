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
    public partial class Form_Dieu_Huong : Form
    {
        public Form_Dieu_Huong()
        {
            InitializeComponent();
        }

        

        private void Form_Dieu_Huong_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



        private void Bai1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Bai1 form = new Bai1();
            form.ShowDialog();
            form = null;
            this.Show();
        }

        private void Bai2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Bai2 form = new Bai2();
            form.ShowDialog();
            form = null;
            this.Show();
        }

        private void Bai3_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Bai3 form = new Bai3();
            form.ShowDialog();
            form = null;
            this.Show();
        }

        private void Bai3_1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai3_1 form = new Bai3_1();
            form.ShowDialog();
            form = null;
            this.Show();

        }

        private void Bai5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai5 form = new Bai5();
            form.ShowDialog();
            form = null;
            this.Show();
        }

        private void Bai6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai6 form = new Bai6();
            form.ShowDialog();
            form = null;
            this.Show();
        }

        private void Bai7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai7 form = new Bai7();
            form.ShowDialog();
            form = null;
            this.Show();
        }

        private void Bai8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai8 form = new Bai8();
            form.ShowDialog();
            form = null;
            this.Show();
        }

        private void Bai4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai4 form = new Bai4();
            form.ShowDialog();
            form = null;
            this.Show();
        }
    }
}
