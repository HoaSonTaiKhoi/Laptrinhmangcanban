using Org.BouncyCastle.Asn1.Crmf;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BTVN2_POP3
{
    partial class SendMail_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Tbx_User = new System.Windows.Forms.TextBox();
            this.Tbx_Recv = new System.Windows.Forms.TextBox();
            this.Tbx_Subject = new System.Windows.Forms.TextBox();
            this.Rtbx_Content = new System.Windows.Forms.RichTextBox();
            this.Btn_Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-3, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Content";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Tbx_User
            // 
            this.Tbx_User.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_User.Location = new System.Drawing.Point(72, 14);
            this.Tbx_User.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Tbx_User.Name = "Tbx_User";
            this.Tbx_User.ReadOnly = true;
            this.Tbx_User.Size = new System.Drawing.Size(591, 29);
            this.Tbx_User.TabIndex = 4;
            // 
            // Tbx_Recv
            // 
            this.Tbx_Recv.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_Recv.Location = new System.Drawing.Point(72, 54);
            this.Tbx_Recv.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Tbx_Recv.Name = "Tbx_Recv";
            this.Tbx_Recv.Size = new System.Drawing.Size(591, 29);
            this.Tbx_Recv.TabIndex = 5;
            // 
            // Tbx_Subject
            // 
            this.Tbx_Subject.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_Subject.Location = new System.Drawing.Point(72, 101);
            this.Tbx_Subject.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Tbx_Subject.Name = "Tbx_Subject";
            this.Tbx_Subject.Size = new System.Drawing.Size(591, 29);
            this.Tbx_Subject.TabIndex = 6;
            // 
            // Rtbx_Content
            // 
            this.Rtbx_Content.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rtbx_Content.Location = new System.Drawing.Point(72, 145);
            this.Rtbx_Content.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Rtbx_Content.Name = "Rtbx_Content";
            this.Rtbx_Content.Size = new System.Drawing.Size(591, 423);
            this.Rtbx_Content.TabIndex = 7;
            this.Rtbx_Content.Text = "";
            // 
            // Btn_Send
            // 
            this.Btn_Send.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Send.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Send.Location = new System.Drawing.Point(494, 579);
            this.Btn_Send.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Btn_Send.Name = "Btn_Send";
            this.Btn_Send.Size = new System.Drawing.Size(169, 33);
            this.Btn_Send.TabIndex = 8;
            this.Btn_Send.Text = "Send";
            this.Btn_Send.UseVisualStyleBackColor = false;
            this.Btn_Send.Click += new System.EventHandler(this.Btn_Send_Click);
            // 
            // SendMail_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 622);
            this.Controls.Add(this.Btn_Send);
            this.Controls.Add(this.Rtbx_Content);
            this.Controls.Add(this.Tbx_Subject);
            this.Controls.Add(this.Tbx_Recv);
            this.Controls.Add(this.Tbx_User);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "SendMail_Form";
            this.Text = "SendMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Tbx_User;
        private TextBox Tbx_Recv;
        private TextBox Tbx_Subject;
        private RichTextBox Rtbx_Content;
        private Button Btn_Send;
    }
}