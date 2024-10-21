namespace BTVN1_Chat
{
    partial class Server
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
            this.Btn_Listen = new System.Windows.Forms.Button();
            this.Rtbx_Message = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Btn_Listen
            // 
            this.Btn_Listen.BackColor = System.Drawing.Color.White;
            this.Btn_Listen.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Listen.Location = new System.Drawing.Point(11, 19);
            this.Btn_Listen.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Listen.Name = "Btn_Listen";
            this.Btn_Listen.Size = new System.Drawing.Size(99, 45);
            this.Btn_Listen.TabIndex = 0;
            this.Btn_Listen.Text = "Connect";
            this.Btn_Listen.UseVisualStyleBackColor = false;
            this.Btn_Listen.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Rtbx_Message
            // 
            this.Rtbx_Message.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rtbx_Message.Location = new System.Drawing.Point(11, 68);
            this.Rtbx_Message.Margin = new System.Windows.Forms.Padding(2);
            this.Rtbx_Message.Name = "Rtbx_Message";
            this.Rtbx_Message.Size = new System.Drawing.Size(511, 342);
            this.Rtbx_Message.TabIndex = 1;
            this.Rtbx_Message.Text = "";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(533, 419);
            this.Controls.Add(this.Rtbx_Message);
            this.Controls.Add(this.Btn_Listen);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Server";
            this.Text = "server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Server_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Listen;
        private System.Windows.Forms.RichTextBox Rtbx_Message;
    }
}