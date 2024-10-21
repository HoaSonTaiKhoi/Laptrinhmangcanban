namespace W_Lab2
{
    partial class Bai03
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
            this.RTBx_Input = new System.Windows.Forms.RichTextBox();
            this.RTBx_Output = new System.Windows.Forms.RichTextBox();
            this.Btn_WriteOutput = new System.Windows.Forms.Button();
            this.Btn_WriteInput = new System.Windows.Forms.Button();
            this.Btn_ReadInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input3.txt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(538, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output3.txt";
            // 
            // RTBx_Input
            // 
            this.RTBx_Input.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBx_Input.Location = new System.Drawing.Point(39, 78);
            this.RTBx_Input.Name = "RTBx_Input";
            this.RTBx_Input.Size = new System.Drawing.Size(292, 331);
            this.RTBx_Input.TabIndex = 2;
            this.RTBx_Input.Text = "";
            // 
            // RTBx_Output
            // 
            this.RTBx_Output.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBx_Output.Location = new System.Drawing.Point(436, 78);
            this.RTBx_Output.Name = "RTBx_Output";
            this.RTBx_Output.Size = new System.Drawing.Size(292, 331);
            this.RTBx_Output.TabIndex = 3;
            this.RTBx_Output.Text = "";
            // 
            // Btn_WriteOutput
            // 
            this.Btn_WriteOutput.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_WriteOutput.Location = new System.Drawing.Point(337, 334);
            this.Btn_WriteOutput.Name = "Btn_WriteOutput";
            this.Btn_WriteOutput.Size = new System.Drawing.Size(93, 75);
            this.Btn_WriteOutput.TabIndex = 4;
            this.Btn_WriteOutput.Text = "Tính Và Ghi vào Output3";
            this.Btn_WriteOutput.UseVisualStyleBackColor = true;
            this.Btn_WriteOutput.Click += new System.EventHandler(this.Btn_WriteOutput_Click);
            // 
            // Btn_WriteInput
            // 
            this.Btn_WriteInput.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_WriteInput.Location = new System.Drawing.Point(337, 78);
            this.Btn_WriteInput.Name = "Btn_WriteInput";
            this.Btn_WriteInput.Size = new System.Drawing.Size(93, 52);
            this.Btn_WriteInput.TabIndex = 5;
            this.Btn_WriteInput.Text = "Ghi vào Input3";
            this.Btn_WriteInput.UseVisualStyleBackColor = true;
            this.Btn_WriteInput.Click += new System.EventHandler(this.Btn_WriteInput_Click);
            // 
            // Btn_ReadInput
            // 
            this.Btn_ReadInput.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ReadInput.Location = new System.Drawing.Point(338, 206);
            this.Btn_ReadInput.Name = "Btn_ReadInput";
            this.Btn_ReadInput.Size = new System.Drawing.Size(93, 52);
            this.Btn_ReadInput.TabIndex = 6;
            this.Btn_ReadInput.Text = "Đọc File Input3.txt";
            this.Btn_ReadInput.UseVisualStyleBackColor = true;
            this.Btn_ReadInput.Click += new System.EventHandler(this.Btn_ReadInput_Click);
            // 
            // Bai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 465);
            this.Controls.Add(this.Btn_ReadInput);
            this.Controls.Add(this.Btn_WriteInput);
            this.Controls.Add(this.Btn_WriteOutput);
            this.Controls.Add(this.RTBx_Output);
            this.Controls.Add(this.RTBx_Input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai03";
            this.Text = "Bài 3 - Đọc, ghi file và tính toán";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox RTBx_Input;
        private System.Windows.Forms.RichTextBox RTBx_Output;
        private System.Windows.Forms.Button Btn_WriteOutput;
        private System.Windows.Forms.Button Btn_WriteInput;
        private System.Windows.Forms.Button Btn_ReadInput;
    }
}