using System.Windows.Forms;

namespace Winform_Lab1
{
    partial class Bai7
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
            this.Label_Array = new System.Windows.Forms.Label();
            this.Input_Array = new System.Windows.Forms.TextBox();
            this.Btn_Calc = new System.Windows.Forms.Button();
            this.OutBox_1 = new System.Windows.Forms.TextBox();
            this.Btn_Del_All = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_Array
            // 
            this.Label_Array.AutoSize = true;
            this.Label_Array.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Array.Location = new System.Drawing.Point(21, 52);
            this.Label_Array.Name = "Label_Array";
            this.Label_Array.Size = new System.Drawing.Size(94, 21);
            this.Label_Array.TabIndex = 0;
            this.Label_Array.Text = "Nhập mảng";
            // 
            // Input_Array
            // 
            this.Input_Array.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Array.Location = new System.Drawing.Point(25, 76);
            this.Input_Array.Name = "Input_Array";
            this.Input_Array.Size = new System.Drawing.Size(686, 25);
            this.Input_Array.TabIndex = 1;
            this.Input_Array.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_Array_KeyPress);
            // 
            // Btn_Calc
            // 
            this.Btn_Calc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Calc.Location = new System.Drawing.Point(179, 111);
            this.Btn_Calc.Name = "Btn_Calc";
            this.Btn_Calc.Size = new System.Drawing.Size(105, 34);
            this.Btn_Calc.TabIndex = 2;
            this.Btn_Calc.Text = "Calculate";
            this.Btn_Calc.UseVisualStyleBackColor = true;
            this.Btn_Calc.Click += new System.EventHandler(this.Btn_Calc_Click);
            // 
            // OutBox_1
            // 
            this.OutBox_1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutBox_1.Location = new System.Drawing.Point(50, 150);
            this.OutBox_1.Multiline = true;
            this.OutBox_1.Name = "OutBox_1";
            this.OutBox_1.ReadOnly = true;
            this.OutBox_1.Size = new System.Drawing.Size(630, 200);
            this.OutBox_1.TabIndex = 5;
            // 
            // Btn_Del_All
            // 
            this.Btn_Del_All.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Del_All.Location = new System.Drawing.Point(320, 111);
            this.Btn_Del_All.Name = "Btn_Del_All";
            this.Btn_Del_All.Size = new System.Drawing.Size(100, 34);
            this.Btn_Del_All.TabIndex = 3;
            this.Btn_Del_All.Text = "Xóa tất cả";
            this.Btn_Del_All.UseVisualStyleBackColor = true;
            this.Btn_Del_All.Click += new System.EventHandler(this.Btn_Del_All_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Exit.Location = new System.Drawing.Point(451, 111);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(100, 34);
            this.Btn_Exit.TabIndex = 4;
            this.Btn_Exit.Text = "Thoát";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Bai7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 458);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Del_All);
            this.Controls.Add(this.Btn_Calc);
            this.Controls.Add(this.Input_Array);
            this.Controls.Add(this.Label_Array);
            this.Name = "Bai7";
            this.Text = "Bài 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Array;
        private System.Windows.Forms.TextBox Input_Array;
        private System.Windows.Forms.Button Btn_Calc;
        private System.Windows.Forms.TextBox OutBox_1;
        private Button Btn_Del_All;
        private Button Btn_Exit;
    }
}