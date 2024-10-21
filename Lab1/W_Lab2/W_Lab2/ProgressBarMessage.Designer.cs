namespace W_Lab2
{
    partial class ProgressBarMessage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Pb1 = new System.Windows.Forms.ProgressBar();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Pb1
            // 
            this.Pb1.Location = new System.Drawing.Point(28, 47);
            this.Pb1.MarqueeAnimationSpeed = 1000;
            this.Pb1.Name = "Pb1";
            this.Pb1.RightToLeftLayout = true;
            this.Pb1.Size = new System.Drawing.Size(399, 50);
            this.Pb1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Pb1.TabIndex = 0;
            this.Pb1.UseWaitCursor = true;
            // 
            // time
            // 
            this.time.Interval = 300;
            this.time.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ProgressBarMessage
            // 
            this.ClientSize = new System.Drawing.Size(456, 139);
            this.Controls.Add(this.Pb1);
            this.Name = "ProgressBarMessage";
            this.Text = "Loading...";
            this.ResumeLayout(false);

        }

        #endregion

       
        private System.Windows.Forms.TextBox Tbx_Status;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.ProgressBar Pb1;
    }
}