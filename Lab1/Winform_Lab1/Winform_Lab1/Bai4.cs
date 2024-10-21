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
    public partial class Bai4 : Form
    {
        private List<System.Windows.Forms.Button> list_seats;
        List<Movie> list_movies;
        List<Ticket> list_tickets = new List<Ticket>();
        
        int Chosen_Seat = 0;

        public Bai4()
        {
            
            InitializeComponent();
            this.list_seats = new List<System.Windows.Forms.Button>();
            for (int i = 0; i < 15; i++)
            {

                System.Windows.Forms.Button temp = new System.Windows.Forms.Button();
                temp.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                temp.Location = new System.Drawing.Point(20 + (i % 5) * 100, 70 + (i / 5) * 50);
                temp.Name = "Seat" + i.ToString();
                temp.Size = new System.Drawing.Size(40, 30);
                temp.TabIndex = 5;
                temp.Text = ((i / 5 == 0) ? "A" : ((i / 5 == 1) ? "B" : "C")) + (i % 5 + 1).ToString();
                temp.UseVisualStyleBackColor = true;
                temp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.list_seats_click);
                list_seats.Add(temp);
                GrBx_Ticket.Controls.Add(temp);
            }


            list_movies = new List<Movie>()
            {
                new Movie(){Name_Movie="Đào, phở và piano", Price_Movie=45000, Theater_Index=new int[]{1,2,3}, },
                new Movie(){Name_Movie="Mai", Price_Movie=100000, Theater_Index=new int[]{2,3}, },
                new Movie(){Name_Movie="Gặp lại chị bầu", Price_Movie=70000, Theater_Index=new int[]{1}, },
                new Movie(){Name_Movie="Tarot", Price_Movie=90000, Theater_Index=new int[]{3},}
            };

            list_movies[0].Theater_Seat.Add(0, Enumerable.Repeat(0, 15).ToArray());
            list_movies[0].Theater_Seat.Add(1, Enumerable.Repeat(0, 15).ToArray());
            list_movies[0].Theater_Seat.Add(2, Enumerable.Repeat(0, 15).ToArray());
            list_movies[1].Theater_Seat.Add(0, Enumerable.Repeat(0, 15).ToArray());
            list_movies[1].Theater_Seat.Add(1, Enumerable.Repeat(0, 15).ToArray());
            list_movies[2].Theater_Seat.Add(0, Enumerable.Repeat(0, 15).ToArray());
            list_movies[3].Theater_Seat.Add(0, Enumerable.Repeat(0, 15).ToArray());
            


            CBx_Movie.DataSource = list_movies;
            CBx_Movie.DisplayMember = "Name_Movie";

            CBx_Theater.DataSource = list_movies[0].Theater_Index;
            CBx_Theater.DisplayMember = "";

            for(int i=0; i<15; i++)
            {
                this.list_seats[i].TabStop = true;
                this.list_seats[i].Enabled = true;
                this.list_seats[i].BackColor = System.Drawing.SystemColors.Control;
                this.list_seats[i].ForeColor = System.Drawing.SystemColors.ControlText;
                if (list_movies[CBx_Movie.SelectedIndex].Theater_Seat[CBx_Theater.SelectedIndex][i] ==1)
                {
                    this.list_seats[i].BackColor = System.Drawing.Color.Yellow;
                    this.list_seats[i].ForeColor = System.Drawing.Color.White;
                    this.list_seats[i].TabStop = false;
                    this.list_seats[i].Enabled = false;
                }    
            }    
        }

        private void list_seats_click(object sender, System.EventArgs e)
        {
            Button this_button = sender as Button;

            if (this_button.BackColor == System.Drawing.SystemColors.Control)
            {
                this_button.BackColor = System.Drawing.Color.Firebrick;
                this_button.ForeColor = System.Drawing.Color.White;
                
            }
            else
            {
                this_button.BackColor= System.Drawing.SystemColors.Control;
                this_button.ForeColor= System.Drawing.SystemColors.ControlText;
            }    
        }

        private void CBx_Movie_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

            CBx_Theater.DataSource = list_movies[CBx_Movie.SelectedIndex].Theater_Index;
            CBx_Theater.DisplayMember = "";
            for (int i = 0; i < 15; i++)
            {
                this.list_seats[i].TabStop = true;
                this.list_seats[i].Enabled = true;
                this.list_seats[i].BackColor = System.Drawing.SystemColors.Control;
                this.list_seats[i].ForeColor = System.Drawing.SystemColors.ControlText;
                if (list_movies[CBx_Movie.SelectedIndex].Theater_Seat[CBx_Theater.SelectedIndex][i] == 1)
                {
                    this.list_seats[i].BackColor = System.Drawing.Color.Yellow;
                    this.list_seats[i].ForeColor = System.Drawing.Color.White;
                    this.list_seats[i].TabStop = false;
                    this.list_seats[i].Enabled = false;
                }
            }

        }

        private void CBx_Theater_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                this.list_seats[i].TabStop = true;
                this.list_seats[i].Enabled = true;
                this.list_seats[i].BackColor = System.Drawing.SystemColors.Control;
                this.list_seats[i].ForeColor = System.Drawing.SystemColors.ControlText;
                if (list_movies[CBx_Movie.SelectedIndex].Theater_Seat[CBx_Theater.SelectedIndex][i] == 1)
                {
                    this.list_seats[i].BackColor = System.Drawing.Color.Yellow;
                    this.list_seats[i].ForeColor = System.Drawing.Color.White;
                    this.list_seats[i].TabStop = false;
                    this.list_seats[i].Enabled = false;
                }
            }
        }

        private void Btn_Buy_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(TBx_Customer.Text)) { MessageBox.Show("Chưa nhập tên khách hàng!"); }   
            for (int i = 0; i < 15; i++)
            {
                if (list_seats[i].BackColor == Color.Firebrick && list_movies[CBx_Movie.SelectedIndex].Theater_Seat[CBx_Theater.SelectedIndex][i] == 0)
                {
                    
                    this.list_seats[i].TabStop = false;
                    this.list_seats[i].Enabled = false;
                    Chosen_Seat += 1; 
                }

            }

            if(Chosen_Seat==0) { MessageBox.Show("Chưa chọn vé!"); return; }

            Ticket ticket = new Ticket() { Bill = 0, };
            ticket.Customer_Name = TBx_Customer.Text;
            ticket.Name_Movie = list_movies[CBx_Movie.SelectedIndex].Name_Movie;
            ticket.Theater = list_movies[CBx_Movie.SelectedIndex].Theater_Index[CBx_Theater.SelectedIndex];

            for (int i = 0; i < 15; i++)
            {
                if (list_seats[i].BackColor == Color.Firebrick
                    && list_movies[CBx_Movie.SelectedIndex].Theater_Seat[CBx_Theater.SelectedIndex][i] ==0)
                {
                    list_movies[CBx_Movie.SelectedIndex].Theater_Seat[CBx_Theater.SelectedIndex][i] = 1;
                    ticket.Chosen_Ticket.Add(((i / 5 == 0) ? "A" : ((i / 5 == 1) ? "B" : "C")) + (i % 5 + 1).ToString());
                    if (i % 5 == 0 || i % 5 == 4) ticket.Bill += list_movies[CBx_Movie.SelectedIndex].Price_Movie * 1 / 4;
                    else if (i / 5 == 0 || i / 5 == 2) ticket.Bill += list_movies[CBx_Movie.SelectedIndex].Price_Movie;
                    else ticket.Bill += list_movies[CBx_Movie.SelectedIndex].Price_Movie*2;
                    this.list_seats[i].BackColor = System.Drawing.Color.Yellow;
                    this.list_seats[i].ForeColor = System.Drawing.Color.White;
                }
             }

            list_tickets.Add(ticket);

            ListViewItem item = new ListViewItem((list_tickets.Count).ToString());
            item.SubItems.Add(list_tickets[list_tickets.Count-1].Customer_Name);
            item.SubItems.Add(string.Join(", ", list_tickets[list_tickets.Count - 1].Chosen_Ticket));
            item.SubItems.Add(list_tickets[list_tickets.Count - 1].Name_Movie);
            

            item.SubItems.Add(list_tickets[list_tickets.Count - 1].Theater.ToString());
            item.SubItems.Add(list_tickets[list_tickets.Count - 1].Bill.ToString());
            
            ListView_Bought_Ticket.Items.Add(item);


            Chosen_Seat = 0;
        }

        private void TBx_Customer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Không nhập số hoặc kí tự lạ!");
            }
        }

        private void ListView_Bought_Ticket_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    public class Movie
    {
        public string Name_Movie { get; set; }
        public int[] Theater_Index;
        public float Price_Movie { get; set; }
        public Dictionary<int, int[]> Theater_Seat=new Dictionary<int, int[]>();


    }



    class Ticket
    {
        public string Customer_Name { get; set; }
        public List<string> Chosen_Ticket= new List<string>();
        public string Name_Movie { get; set; }
        public int Theater { get; set;}
        public float Bill { get; set; }
    }
}
