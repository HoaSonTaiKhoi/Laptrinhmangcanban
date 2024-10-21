using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace W_Lab2
{
    public partial class ProgressBarMessage : Form
    {
        public ProgressBarMessage()
        {
            InitializeComponent();
            time.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Pb1.Increment(10);
            // Display the textual value of the ProgressBar in the StatusBar control's first panel.
            Pb1.Text = Pb1.Value.ToString() + "% Completed";
            // Determine if we have completed by comparing the value of the Value property to the Maximum value.
            if (Pb1.Value == Pb1.Maximum)
            {
                time.Stop();
                Task.Delay(100).Wait();
                MessageBox.Show("Done!");
                this.Close();
            }

            
            
        }
    }
}
