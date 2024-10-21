namespace Winform_Lab1
{
    partial class Bai5
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
            this.Label_A = new System.Windows.Forms.Label();
            this.Label_B = new System.Windows.Forms.Label();
            this.CBox_Func = new System.Windows.Forms.ComboBox();
            this.GrBox_Output = new System.Windows.Forms.GroupBox();
            this.Input_A = new System.Windows.Forms.TextBox();
            this.Input_B = new System.Windows.Forms.TextBox();
            this.Btn_Calc = new System.Windows.Forms.Button();
            this.Btn_Del = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_A
            // 
            this.Label_A.AutoSize = true;
            this.Label_A.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_A.Location = new System.Drawing.Point(100, 31);
            this.Label_A.Name = "Label_A";
            this.Label_A.Size = new System.Drawing.Size(54, 17);
            this.Label_A.TabIndex = 0;
            this.Label_A.Text = "Nhập A";
            // 
            // Label_B
            // 
            this.Label_B.AutoSize = true;
            this.Label_B.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_B.Location = new System.Drawing.Point(350, 31);
            this.Label_B.Name = "Label_B";
            this.Label_B.Size = new System.Drawing.Size(53, 17);
            this.Label_B.TabIndex = 1;
            this.Label_B.Text = "Nhập B";
            // 
            // CBox_Func
            // 
            this.CBox_Func.FormattingEnabled = true;
            this.CBox_Func.Location = new System.Drawing.Point(262, 65);
            this.CBox_Func.Name = "CBox_Func";
            this.CBox_Func.Size = new System.Drawing.Size(141, 21);
            this.CBox_Func.TabIndex = 2;
            this.CBox_Func.SelectedIndexChanged += new System.EventHandler(this.CBox_Func_SelectedIndexChanged);
            // 
            // GrBox_Output
            // 
            this.GrBox_Output.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrBox_Output.Location = new System.Drawing.Point(68, 159);
            this.GrBox_Output.Name = "GrBox_Output";
            this.GrBox_Output.Size = new System.Drawing.Size(516, 252);
            this.GrBox_Output.TabIndex = 3;
            this.GrBox_Output.TabStop = false;
            this.GrBox_Output.Text = "Kết Quả";
            // 
            // Input_A
            // 
            this.Input_A.Location = new System.Drawing.Point(155, 30);
            this.Input_A.Name = "Input_A";
            this.Input_A.Size = new System.Drawing.Size(110, 20);
            this.Input_A.TabIndex = 4;
            this.Input_A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_A_KeyPress);
            // 
            // Input_B
            // 
            this.Input_B.Location = new System.Drawing.Point(405, 30);
            this.Input_B.Name = "Input_B";
            this.Input_B.Size = new System.Drawing.Size(110, 20);
            this.Input_B.TabIndex = 5;
            this.Input_B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_A_KeyPress);
            // 
            // Btn_Calc
            // 
            this.Btn_Calc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Calc.Location = new System.Drawing.Point(110, 100);
            this.Btn_Calc.Name = "Btn_Calc";
            this.Btn_Calc.Size = new System.Drawing.Size(130, 30);
            this.Btn_Calc.TabIndex = 6;
            this.Btn_Calc.Text = "Tính các giá trị";
            this.Btn_Calc.UseVisualStyleBackColor = true;
            this.Btn_Calc.Click += new System.EventHandler(this.Btn_Calc_Click);
            // 
            // Btn_Del
            // 
            this.Btn_Del.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Del.Location = new System.Drawing.Point(295, 100);
            this.Btn_Del.Name = "Btn_Del";
            this.Btn_Del.Size = new System.Drawing.Size(80, 30);
            this.Btn_Del.TabIndex = 7;
            this.Btn_Del.Text = "Xóa";
            this.Btn_Del.UseVisualStyleBackColor = true;
            this.Btn_Del.Click += new System.EventHandler(this.Btn_Del_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Exit.Location = new System.Drawing.Point(430, 100);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(80, 30);
            this.Btn_Exit.TabIndex = 8;
            this.Btn_Exit.Text = "Thoát";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Bai5
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 423);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Del);
            this.Controls.Add(this.Btn_Calc);
            this.Controls.Add(this.Input_B);
            this.Controls.Add(this.Input_A);
            this.Controls.Add(this.GrBox_Output);
            this.Controls.Add(this.CBox_Func);
            this.Controls.Add(this.Label_B);
            this.Controls.Add(this.Label_A);
            this.Name = "Bai5";
            this.Text = "Bài 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_A;
        private System.Windows.Forms.Label Label_B;
        private System.Windows.Forms.ComboBox CBox_Func;
        private System.Windows.Forms.GroupBox GrBox_Output;
        private System.Windows.Forms.TextBox Input_A;
        private System.Windows.Forms.TextBox Input_B;
        private System.Windows.Forms.Button Btn_Calc;
        private System.Windows.Forms.Button Btn_Del;
        private System.Windows.Forms.Button Btn_Exit;
    }
}