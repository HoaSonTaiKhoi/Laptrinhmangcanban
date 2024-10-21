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
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }

        private string Line_Count(StreamReader sr)
        {
            int Line_Count = 0;
            while(sr.ReadLine()!=null)
            {
                Line_Count++;
            }
            return Line_Count.ToString();
        }    

        private string Words_Count(StreamReader sr)
        {
            string temp = sr.ReadToEnd();
            string[] words=temp.Split(' ',',',';','.','\n', '\t','\r','/');
            return words.Length.ToString();
        }

        private string Characters_Count(StreamReader sr)
        {
            string temp = sr.ReadToEnd();
            return temp.Length.ToString();
        }

        private bool IsExecutableFile(string filePath)
        {
            string extension = Path.GetExtension(filePath);
            if (string.IsNullOrEmpty(extension))
                return false;

            string[] executableExtensions = { ".exe", ".bat", ".cmd", ".com", ".pdb" }; // Danh sách các phần mở rộng cho file thực thi

            return Array.IndexOf(executableExtensions, extension.ToLower()) == -1;
        }

    private void Btn_ReadFile_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd=new OpenFileDialog();
            
            //Filter
            ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            ofd.FilterIndex = 1;
            ofd.Multiselect = false;
            ofd.DefaultExt = "txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = ofd.SafeFileName.ToString();
                if(!IsExecutableFile(selectedFile))
                {
                    MessageBox.Show("Không thể đọc! Chọn lại.");
                    return;
                }    

                TBx_FileName.Text = selectedFile;
                TBx_Size.Text = new System.IO.FileInfo(ofd.FileName).Length.ToString() + " bytes";
                TBx_URL.Text= Path.GetDirectoryName(ofd.FileName);
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                // Textbox_LineCount Words Count, Characters Count
                
                
                TBx_LineCount.Text = Line_Count(new StreamReader(fs));
                fs.Position = 0;
                TBx_WordsCount.Text = Words_Count(new StreamReader(fs));
                fs.Position = 0;
                TBx_CharCount.Text= Characters_Count(new StreamReader(fs));
                fs.Position = 0;
                RTBx_Output.Text = sr.ReadToEnd();

                fs.Close();
            }    
                
            
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
