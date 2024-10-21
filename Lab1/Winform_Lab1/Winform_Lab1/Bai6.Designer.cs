using System.Windows.Forms;

namespace Winform_Lab1
{
    partial class Bai6
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
            this.Label_Input_1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Masked_Input = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Label_Input_1
            // 
            this.Label_Input_1.AutoSize = true;
            this.Label_Input_1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Input_1.Location = new System.Drawing.Point(277, 55);
            this.Label_Input_1.Name = "Label_Input_1";
            this.Label_Input_1.Size = new System.Drawing.Size(71, 21);
            this.Label_Input_1.TabIndex = 0;
            this.Label_Input_1.Text = "Birthday";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(217, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kiểm tra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Masked_Input
            // 
            this.Masked_Input.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Masked_Input.Location = new System.Drawing.Point(174, 79);
            this.Masked_Input.Mask = "00-00-0000";
            this.Masked_Input.Name = "Masked_Input";
            this.Masked_Input.Size = new System.Drawing.Size(274, 29);
            this.Masked_Input.TabIndex = 5;
            this.Masked_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Masked_Input.ValidatingType = typeof(System.DateTime);
            this.Masked_Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_KeyPress);
            // 
            // Bai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 308);
            this.Controls.Add(this.Masked_Input);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Label_Input_1);
            this.Name = "Bai6";
            this.Text = "Bài 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Input_1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox Masked_Input;
    }
}