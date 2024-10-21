using Org.BouncyCastle.Asn1.Crmf;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BTVN2_POP3
{
    partial class Mail_Form
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
            this.Lsv_Mail = new System.Windows.Forms.ListView();
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.From = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Btn_Send = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Tbx_Acc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lsv_Mail
            // 
            this.Lsv_Mail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.Email,
            this.From,
            this.Date});
            this.Lsv_Mail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lsv_Mail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lsv_Mail.HideSelection = false;
            this.Lsv_Mail.Location = new System.Drawing.Point(0, 69);
            this.Lsv_Mail.Margin = new System.Windows.Forms.Padding(4);
            this.Lsv_Mail.Name = "Lsv_Mail";
            this.Lsv_Mail.Scrollable = false;
            this.Lsv_Mail.Size = new System.Drawing.Size(986, 419);
            this.Lsv_Mail.TabIndex = 0;
            this.Lsv_Mail.UseCompatibleStateImageBehavior = false;
            this.Lsv_Mail.View = System.Windows.Forms.View.Details;
            // 
            // Number
            // 
            this.Number.Text = "Number";
            this.Number.Width = 100;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 392;
            // 
            // From
            // 
            this.From.Text = "From";
            this.From.Width = 302;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 300;
            // 
            // Btn_Send
            // 
            this.Btn_Send.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Send.Location = new System.Drawing.Point(803, 13);
            this.Btn_Send.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Send.Name = "Btn_Send";
            this.Btn_Send.Size = new System.Drawing.Size(152, 30);
            this.Btn_Send.TabIndex = 1;
            this.Btn_Send.Text = "New Email";
            this.Btn_Send.UseVisualStyleBackColor = true;
            this.Btn_Send.Click += new System.EventHandler(this.Btn_Send_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Account";
            // 
            // Tbx_Acc
            // 
            this.Tbx_Acc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_Acc.Location = new System.Drawing.Point(119, 15);
            this.Tbx_Acc.Margin = new System.Windows.Forms.Padding(4);
            this.Tbx_Acc.Name = "Tbx_Acc";
            this.Tbx_Acc.ReadOnly = true;
            this.Tbx_Acc.Size = new System.Drawing.Size(455, 29);
            this.Tbx_Acc.TabIndex = 4;
            // 
            // Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 488);
            this.Controls.Add(this.Tbx_Acc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Send);
            this.Controls.Add(this.Lsv_Mail);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Mail";
            this.Text = "Mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView Lsv_Mail;
        private ColumnHeader Number;
        private ColumnHeader Email;
        private ColumnHeader From;
        private ColumnHeader Date;
        private Button Btn_Send;
        private Label label2;
        private TextBox Tbx_Acc;
    }
}