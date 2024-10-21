namespace Winform_Lab1
{
    partial class Bai2
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
            this.Num_1 = new System.Windows.Forms.Label();
            this.Num_2 = new System.Windows.Forms.Label();
            this.Num_3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Input_1 = new System.Windows.Forms.TextBox();
            this.Input_2 = new System.Windows.Forms.TextBox();
            this.Input_3 = new System.Windows.Forms.TextBox();
            this.Output_Big = new System.Windows.Forms.TextBox();
            this.Output_Small = new System.Windows.Forms.TextBox();
            this.Button_Find = new System.Windows.Forms.Button();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.Button_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Num_1
            // 
            this.Num_1.AutoSize = true;
            this.Num_1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_1.Location = new System.Drawing.Point(60, 80);
            this.Num_1.Name = "Num_1";
            this.Num_1.Size = new System.Drawing.Size(84, 17);
            this.Num_1.TabIndex = 0;
            this.Num_1.Text = "Số Thứ Nhất";
            // 
            // Num_2
            // 
            this.Num_2.AutoSize = true;
            this.Num_2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_2.Location = new System.Drawing.Point(275, 80);
            this.Num_2.Name = "Num_2";
            this.Num_2.Size = new System.Drawing.Size(74, 17);
            this.Num_2.TabIndex = 1;
            this.Num_2.Text = "Số Thứ Hai";
            // 
            // Num_3
            // 
            this.Num_3.AutoSize = true;
            this.Num_3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_3.Location = new System.Drawing.Point(480, 80);
            this.Num_3.Name = "Num_3";
            this.Num_3.Size = new System.Drawing.Size(69, 17);
            this.Num_3.TabIndex = 2;
            this.Num_3.Text = "Số Thứ Ba";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số Lớn Nhất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(370, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số Nhỏ Nhất";
            // 
            // Input_1
            // 
            this.Input_1.Location = new System.Drawing.Point(145, 79);
            this.Input_1.Name = "Input_1";
            this.Input_1.Size = new System.Drawing.Size(100, 20);
            this.Input_1.TabIndex = 5;
            this.Input_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_1_KeyPress);
            // 
            // Input_2
            // 
            this.Input_2.Location = new System.Drawing.Point(350, 79);
            this.Input_2.Name = "Input_2";
            this.Input_2.Size = new System.Drawing.Size(100, 20);
            this.Input_2.TabIndex = 6;
            this.Input_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_1_KeyPress);
            // 
            // Input_3
            // 
            this.Input_3.Location = new System.Drawing.Point(550, 79);
            this.Input_3.Name = "Input_3";
            this.Input_3.Size = new System.Drawing.Size(100, 20);
            this.Input_3.TabIndex = 7;
            this.Input_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_1_KeyPress);
            // 
            // Output_Big
            // 
            this.Output_Big.BackColor = System.Drawing.SystemColors.Info;
            this.Output_Big.Location = new System.Drawing.Point(211, 219);
            this.Output_Big.Name = "Output_Big";
            this.Output_Big.ReadOnly = true;
            this.Output_Big.Size = new System.Drawing.Size(100, 20);
            this.Output_Big.TabIndex = 8;
            // 
            // Output_Small
            // 
            this.Output_Small.BackColor = System.Drawing.SystemColors.Info;
            this.Output_Small.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Output_Small.Location = new System.Drawing.Point(455, 219);
            this.Output_Small.Name = "Output_Small";
            this.Output_Small.ReadOnly = true;
            this.Output_Small.Size = new System.Drawing.Size(100, 20);
            this.Output_Small.TabIndex = 9;
            // 
            // Button_Find
            // 
            this.Button_Find.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Find.Location = new System.Drawing.Point(145, 152);
            this.Button_Find.Name = "Button_Find";
            this.Button_Find.Size = new System.Drawing.Size(75, 25);
            this.Button_Find.TabIndex = 10;
            this.Button_Find.Text = "Tìm";
            this.Button_Find.UseVisualStyleBackColor = true;
            this.Button_Find.Click += new System.EventHandler(this.Button_Find_Click);
            // 
            // Button_Delete
            // 
            this.Button_Delete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Delete.Location = new System.Drawing.Point(316, 152);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(75, 25);
            this.Button_Delete.TabIndex = 11;
            this.Button_Delete.Text = "Xóa";
            this.Button_Delete.UseVisualStyleBackColor = true;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // Button_Back
            // 
            this.Button_Back.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Back.Location = new System.Drawing.Point(480, 152);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(75, 25);
            this.Button_Back.TabIndex = 12;
            this.Button_Back.Text = "Thoát";
            this.Button_Back.UseVisualStyleBackColor = true;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(717, 299);
            this.Controls.Add(this.Button_Back);
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.Button_Find);
            this.Controls.Add(this.Output_Small);
            this.Controls.Add(this.Output_Big);
            this.Controls.Add(this.Input_3);
            this.Controls.Add(this.Input_2);
            this.Controls.Add(this.Input_1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Num_3);
            this.Controls.Add(this.Num_2);
            this.Controls.Add(this.Num_1);
            this.Name = "Bai2";
            this.Text = "Bài 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Num_1;
        private System.Windows.Forms.Label Num_2;
        private System.Windows.Forms.Label Num_3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Input_1;
        private System.Windows.Forms.TextBox Input_2;
        private System.Windows.Forms.TextBox Input_3;
        private System.Windows.Forms.TextBox Output_Big;
        private System.Windows.Forms.TextBox Output_Small;
        private System.Windows.Forms.Button Button_Find;
        private System.Windows.Forms.Button Button_Delete;
        private System.Windows.Forms.Button Button_Back;
    }
}