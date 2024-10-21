namespace BTVN1_Chat
{
    partial class Dieuhuong
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
            this.Btn_TcpServer = new System.Windows.Forms.Button();
            this.Btn_TcpClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_TcpServer
            // 
            this.Btn_TcpServer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TcpServer.Location = new System.Drawing.Point(81, 43);
            this.Btn_TcpServer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_TcpServer.Name = "Btn_TcpServer";
            this.Btn_TcpServer.Size = new System.Drawing.Size(158, 67);
            this.Btn_TcpServer.TabIndex = 0;
            this.Btn_TcpServer.Text = "Open TCP Server";
            this.Btn_TcpServer.UseVisualStyleBackColor = true;
            this.Btn_TcpServer.Click += new System.EventHandler(this.Btn_TcpServer_Click);
            // 
            // Btn_TcpClient
            // 
            this.Btn_TcpClient.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TcpClient.Location = new System.Drawing.Point(81, 145);
            this.Btn_TcpClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_TcpClient.Name = "Btn_TcpClient";
            this.Btn_TcpClient.Size = new System.Drawing.Size(158, 67);
            this.Btn_TcpClient.TabIndex = 1;
            this.Btn_TcpClient.Text = "Open TCP Client";
            this.Btn_TcpClient.UseVisualStyleBackColor = true;
            this.Btn_TcpClient.Click += new System.EventHandler(this.Btn_TcpClient_Click);
            // 
            // Dieuhuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 285);
            this.Controls.Add(this.Btn_TcpClient);
            this.Controls.Add(this.Btn_TcpServer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Dieuhuong";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_TcpServer;
        private System.Windows.Forms.Button Btn_TcpClient;
    }
}

