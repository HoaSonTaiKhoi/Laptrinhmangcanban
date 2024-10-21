namespace W_Lab2
{
    partial class Bai01
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
            this.Btn_ReadFile = new System.Windows.Forms.Button();
            this.Btn_WriteFile = new System.Windows.Forms.Button();
            this.RTBx_Output = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Btn_ReadFile
            // 
            this.Btn_ReadFile.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ReadFile.Location = new System.Drawing.Point(30, 31);
            this.Btn_ReadFile.Name = "Btn_ReadFile";
            this.Btn_ReadFile.Size = new System.Drawing.Size(143, 40);
            this.Btn_ReadFile.TabIndex = 0;
            this.Btn_ReadFile.Text = "Đọc File";
            this.Btn_ReadFile.UseVisualStyleBackColor = true;
            this.Btn_ReadFile.Click += new System.EventHandler(this.Btn_ReadFile_Click);
            // 
            // Btn_WriteFile
            // 
            this.Btn_WriteFile.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_WriteFile.Location = new System.Drawing.Point(30, 77);
            this.Btn_WriteFile.Name = "Btn_WriteFile";
            this.Btn_WriteFile.Size = new System.Drawing.Size(143, 40);
            this.Btn_WriteFile.TabIndex = 1;
            this.Btn_WriteFile.Text = "Ghi File";
            this.Btn_WriteFile.UseVisualStyleBackColor = true;
            this.Btn_WriteFile.Click += new System.EventHandler(this.Btn_WriteFile_Click);
            // 
            // RTBx_Output
            // 
            this.RTBx_Output.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBx_Output.Location = new System.Drawing.Point(214, 31);
            this.RTBx_Output.Name = "RTBx_Output";
            this.RTBx_Output.Size = new System.Drawing.Size(545, 298);
            this.RTBx_Output.TabIndex = 2;
            this.RTBx_Output.Text = "";
            // 
            // Bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 376);
            this.Controls.Add(this.RTBx_Output);
            this.Controls.Add(this.Btn_WriteFile);
            this.Controls.Add(this.Btn_ReadFile);
            this.Name = "Bai01";
            this.Text = "Bài 01 - Ghi và Đọc File";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_ReadFile;
        private System.Windows.Forms.Button Btn_WriteFile;
        private System.Windows.Forms.RichTextBox RTBx_Output;
    }
}