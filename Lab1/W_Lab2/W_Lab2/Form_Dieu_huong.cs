using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W_Lab2
{
    public partial class Form_Dieu_huong : Form
    {
        public Form_Dieu_huong()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Bai01_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai01 form= new Bai01();
            form.ShowDialog();
            form = null;
            this.Show();
        }

        private void Btn_Bai02_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai02 form = new Bai02();
            form.ShowDialog();
            form = null;
            this.Show();
        }

        private void Btn_Bai03_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai03 form = new Bai03();
            form.ShowDialog();
            form = null;
            this.Show();
        }

        private void Btn_Bai04_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai04 form = new Bai04();
            form.ShowDialog();
            form = null;
            this.Show();
        }

        private void Btn_Bai05_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai05 form = new Bai05();
            form.ShowDialog();
            form = null;
            this.Show();
        }

        private void Btn_Bai07_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai07 form = new Bai07();
            form.ShowDialog();
            form = null;
            this.Show();
        }

        private void Btn_Bai06_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai06 form = new Bai06();
            form.ShowDialog();
            form = null;
            this.Show();
        }
    }
}
