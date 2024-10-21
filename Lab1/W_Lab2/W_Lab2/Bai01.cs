using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace W_Lab2
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private void Btn_ReadFile_Click(object sender, EventArgs e)
        {
            RTBx_Output.Text = String.Empty;
            FileStream fstr = new FileStream(".\\Source\\input1.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fstr);
            string contents=sr.ReadToEnd();
            RTBx_Output.Text = contents;
            fstr.Close();
        }

        private void Btn_WriteFile_Click(object sender, EventArgs e)
        {
            
            StreamWriter sw = new StreamWriter(".\\Source\\output1.txt");
            string contents = RTBx_Output.Text;
            contents=contents.ToUpper();
            sw.Write(contents);
            sw.Close();
            
        }
    }
}
