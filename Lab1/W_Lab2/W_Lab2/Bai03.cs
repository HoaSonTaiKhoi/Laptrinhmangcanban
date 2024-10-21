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
    public partial class Bai03 : Form
    {
        char[] symbol ={'+','-','*', '/'};

        public Bai03()
        {
            InitializeComponent();
            
        }

        // Symbol priority
        private int priority(char symbol)
        {
            if (symbol == '*' || symbol == '/') return 2;
            else if (symbol == '+' || symbol == '-') return 1;
            else return 0;
        }

        private bool check_Input(string Text)
        {
            for(int i=0; i<Text.Length; i++)
            {
                if (symbol.Contains(Text[i]) && symbol.Contains(Text[i+1]))
                {

                    return false;
                }    
            }    
            return true;
        }
        private void calc_Functions(string input)
        {
            string old_input = input;
            input = input.Replace(" ", "");
            var st = new Stack<char>();
            List<string> postfix = new List<string>();

            // convert func into postfix list
            int i = 0, n = input.Length;
            while (i < n)
            {
                // Nếu là ngoặc mở đẩy vào ngăn xếp
                if (input[i] == '(')
                {
                    st.Push(input[i]);
                    i++;
                }

                else if (input[i] == ')')
                {
                    while (st.Peek() != '(')
                    {
                        postfix.Add(st.Peek().ToString());
                        st.Pop();
                    }
                    st.Pop();
                    i++;
                }

                else if (input[i]>='0' && input[i]<='9')
                {
                    
                    string number="";

                    while (i < n && input[i] >= '0' && input[i] <= '9')
                    {
                        number += input[i].ToString();
                        i++;
                    }

                    postfix.Add(number);

                }
                // Nếu s[i] là toán tử thì xử lý dựa trên độ ưu tiên.
                else
                {
                    while (st.Count() != 0 && priority(st.Peek()) >= priority(input[i]))
                    {
                        postfix.Add(st.Peek().ToString());
                        st.Pop();
                    }

                    st.Push(input[i]);
                    i++;
                }
            }

           
            while (st.Count()!=0)
            {
                postfix.Add(st.Peek().ToString());
                st.Pop();
            }


            var st_calc=new Stack<string>();
            
            for (i = 0; i < postfix.Count; i++)
            {
                if (postfix[i] != "+" && postfix[i] != "-" && postfix[i] != "*" && postfix[i] != "/")
                    st_calc.Push(postfix[i]);
                else
                {
                    if (postfix[i] == "+")
                    {
                        float temp = float.Parse(st_calc.Peek());
                        st_calc.Pop();
                        temp += float.Parse(st_calc.Peek());
                        st_calc.Pop();
                        st_calc.Push(temp.ToString());
                    }
                    else if (postfix[i] == "-")
                    {
                        float temp = float.Parse(st_calc.Peek());
                        st_calc.Pop();
                        temp = float.Parse(st_calc.Peek()) - temp;
                        st_calc.Pop();
                        st_calc.Push(temp.ToString());
                    }
                    else if (postfix[i] == "*")
                    {
                        float temp = float.Parse(st_calc.Peek());
                        st_calc.Pop();
                        temp *= float.Parse(st_calc.Peek());
                        st_calc.Pop();
                        st_calc.Push(temp.ToString());
                    }
                    else if (postfix[i] == "/")
                    {
                        float temp = float.Parse(st_calc.Peek());
                        st_calc.Pop();
                        temp= float.Parse(st_calc.Peek())/temp;
                        st_calc.Pop();
                        st_calc.Push(temp.ToString());
                    }
                }


            }
            RTBx_Output.Text += old_input + "= " + st_calc.Peek() + System.Environment.NewLine;
        }

        private void Btn_WriteOutput_Click(object sender, EventArgs e)
        {
            RTBx_Output.Clear();

            string strInputFile = ".\\Source\\input3.txt", strOutputFile = ".\\Source\\output3.txt";
            FileStream fs = new FileStream(strInputFile, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string Content = sr.ReadToEnd();
            if(Content.Contains('='))
            {
                MessageBox.Show("Không được có dấu '='!");
                fs.Close();
                return;
            }    
            if (string.IsNullOrEmpty(Content))
            {
                MessageBox.Show("File rỗng!");
                fs.Close();
                return;
            }

            RTBx_Input.Text = Content;

            string[] Each_Line_Text = RTBx_Input.Text.Split('\n');
           

            for (int i = 0; i<Each_Line_Text.Length; i++)
            {
                if (!check_Input(Each_Line_Text[i]))
                {
                    MessageBox.Show("các phép tính không hợp lệ!");
                    return;
                }
                
                calc_Functions(Each_Line_Text[i]);
            }
            fs.Close();
            StreamWriter sw = new StreamWriter(strOutputFile);
            sw.Write(RTBx_Output.Text);
            sw.Close();

        }

        private void Btn_ReadInput_Click(object sender, EventArgs e)
        {

            string strInputFile = ".\\Source\\input3.txt", strOutputFile = ".\\Source\\output3.txt";
            FileStream fs = new FileStream(strInputFile, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string Content = sr.ReadToEnd();
            if (string.IsNullOrEmpty(Content))
            {
                MessageBox.Show("File rỗng!");
                fs.Close();
                return;
            }

            RTBx_Input.Text = Content;

            string[] Each_Line_Text = RTBx_Input.Text.Split('\n');
            fs.Close();

            
        }

        private void Btn_WriteInput_Click(object sender, EventArgs e)
        {
            string strInputFile = ".\\Source\\input3.txt";
            StreamWriter sw = new StreamWriter(strInputFile);
            sw.Write(RTBx_Input.Text);
            sw.Close();
        }
    }
}
