namespace Winform_Lab1
{
    partial class Bai1
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
            this.label_So_1 = new System.Windows.Forms.Label();
            this.label_So_2 = new System.Windows.Forms.Label();
            this.Input_txt_1 = new System.Windows.Forms.TextBox();
            this.Input_txt_2 = new System.Windows.Forms.TextBox();
            this.Label_KQ = new System.Windows.Forms.Label();
            this.Output_txt = new System.Windows.Forms.TextBox();
            this.Button_Tinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_So_1
            // 
            this.label_So_1.AutoSize = true;
            this.label_So_1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_So_1.Location = new System.Drawing.Point(130, 51);
            this.label_So_1.Name = "label_So_1";
            this.label_So_1.Size = new System.Drawing.Size(57, 17);
            this.label_So_1.TabIndex = 0;
            this.label_So_1.Text = "Số thứ 1";
            // 
            // label_So_2
            // 
            this.label_So_2.AutoSize = true;
            this.label_So_2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_So_2.Location = new System.Drawing.Point(130, 101);
            this.label_So_2.Name = "label_So_2";
            this.label_So_2.Size = new System.Drawing.Size(59, 17);
            this.label_So_2.TabIndex = 1;
            this.label_So_2.Text = "Số thứ 2";
            // 
            // Input_txt_1
            // 
            this.Input_txt_1.Location = new System.Drawing.Point(200, 50);
            this.Input_txt_1.Name = "Input_txt_1";
            this.Input_txt_1.Size = new System.Drawing.Size(184, 20);
            this.Input_txt_1.TabIndex = 2;
            this.Input_txt_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_txt_1_KeyPress);
            // 
            // Input_txt_2
            // 
            this.Input_txt_2.Location = new System.Drawing.Point(200, 100);
            this.Input_txt_2.Name = "Input_txt_2";
            this.Input_txt_2.Size = new System.Drawing.Size(184, 20);
            this.Input_txt_2.TabIndex = 3;
            this.Input_txt_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_txt_1_KeyPress);
            // 
            // Label_KQ
            // 
            this.Label_KQ.AutoSize = true;
            this.Label_KQ.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_KQ.Location = new System.Drawing.Point(130, 151);
            this.Label_KQ.Name = "Label_KQ";
            this.Label_KQ.Size = new System.Drawing.Size(57, 17);
            this.Label_KQ.TabIndex = 4;
            this.Label_KQ.Text = "Kết Quả";
            // 
            // Output_txt
            // 
            this.Output_txt.Location = new System.Drawing.Point(200, 150);
            this.Output_txt.Name = "Output_txt";
            this.Output_txt.ReadOnly = true;
            this.Output_txt.Size = new System.Drawing.Size(184, 20);
            this.Output_txt.TabIndex = 5;
            // 
            // Button_Tinh
            // 
            this.Button_Tinh.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Tinh.Location = new System.Drawing.Point(224, 188);
            this.Button_Tinh.Name = "Button_Tinh";
            this.Button_Tinh.Size = new System.Drawing.Size(75, 40);
            this.Button_Tinh.TabIndex = 6;
            this.Button_Tinh.Text = "Tính";
            this.Button_Tinh.UseVisualStyleBackColor = true;
            this.Button_Tinh.Click += new System.EventHandler(this.Button_Tinh_Click);
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(518, 262);
            this.Controls.Add(this.Button_Tinh);
            this.Controls.Add(this.Output_txt);
            this.Controls.Add(this.Label_KQ);
            this.Controls.Add(this.Input_txt_2);
            this.Controls.Add(this.Input_txt_1);
            this.Controls.Add(this.label_So_2);
            this.Controls.Add(this.label_So_1);
            this.DoubleBuffered = true;
            this.Name = "Bai1";
            this.Text = "Bài 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_So_1;
        private System.Windows.Forms.Label label_So_2;
        private System.Windows.Forms.TextBox Input_txt_1;
        private System.Windows.Forms.TextBox Input_txt_2;
        private System.Windows.Forms.Label Label_KQ;
        private System.Windows.Forms.TextBox Output_txt;
        private System.Windows.Forms.Button Button_Tinh;
    }
}