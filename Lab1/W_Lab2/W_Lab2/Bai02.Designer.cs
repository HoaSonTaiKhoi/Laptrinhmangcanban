namespace W_Lab2
{
    partial class Bai02
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
            this.RTBx_Output = new System.Windows.Forms.RichTextBox();
            this.Btn_ReadFile = new System.Windows.Forms.Button();
            this.Label_FileName = new System.Windows.Forms.Label();
            this.Label_Size = new System.Windows.Forms.Label();
            this.Label_URL = new System.Windows.Forms.Label();
            this.Label_LineCount = new System.Windows.Forms.Label();
            this.Label_WordsCount = new System.Windows.Forms.Label();
            this.Label_CharCount = new System.Windows.Forms.Label();
            this.TBx_FileName = new System.Windows.Forms.TextBox();
            this.TBx_Size = new System.Windows.Forms.TextBox();
            this.TBx_URL = new System.Windows.Forms.TextBox();
            this.TBx_LineCount = new System.Windows.Forms.TextBox();
            this.TBx_WordsCount = new System.Windows.Forms.TextBox();
            this.TBx_CharCount = new System.Windows.Forms.TextBox();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RTBx_Output
            // 
            this.RTBx_Output.Location = new System.Drawing.Point(378, 24);
            this.RTBx_Output.Name = "RTBx_Output";
            this.RTBx_Output.Size = new System.Drawing.Size(541, 443);
            this.RTBx_Output.TabIndex = 0;
            this.RTBx_Output.Text = "";
            // 
            // Btn_ReadFile
            // 
            this.Btn_ReadFile.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ReadFile.Location = new System.Drawing.Point(12, 24);
            this.Btn_ReadFile.Name = "Btn_ReadFile";
            this.Btn_ReadFile.Size = new System.Drawing.Size(343, 40);
            this.Btn_ReadFile.TabIndex = 1;
            this.Btn_ReadFile.Text = "Read from file";
            this.Btn_ReadFile.UseVisualStyleBackColor = true;
            this.Btn_ReadFile.Click += new System.EventHandler(this.Btn_ReadFile_Click);
            // 
            // Label_FileName
            // 
            this.Label_FileName.AutoSize = true;
            this.Label_FileName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_FileName.Location = new System.Drawing.Point(15, 103);
            this.Label_FileName.Name = "Label_FileName";
            this.Label_FileName.Size = new System.Drawing.Size(79, 21);
            this.Label_FileName.TabIndex = 2;
            this.Label_FileName.Text = "File name";
            // 
            // Label_Size
            // 
            this.Label_Size.AutoSize = true;
            this.Label_Size.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Size.Location = new System.Drawing.Point(15, 153);
            this.Label_Size.Name = "Label_Size";
            this.Label_Size.Size = new System.Drawing.Size(39, 21);
            this.Label_Size.TabIndex = 3;
            this.Label_Size.Text = "Size";
            // 
            // Label_URL
            // 
            this.Label_URL.AutoSize = true;
            this.Label_URL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_URL.Location = new System.Drawing.Point(15, 203);
            this.Label_URL.Name = "Label_URL";
            this.Label_URL.Size = new System.Drawing.Size(39, 21);
            this.Label_URL.TabIndex = 4;
            this.Label_URL.Text = "URL";
            // 
            // Label_LineCount
            // 
            this.Label_LineCount.AutoSize = true;
            this.Label_LineCount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_LineCount.Location = new System.Drawing.Point(15, 253);
            this.Label_LineCount.Name = "Label_LineCount";
            this.Label_LineCount.Size = new System.Drawing.Size(88, 21);
            this.Label_LineCount.TabIndex = 5;
            this.Label_LineCount.Text = "Line Count";
            // 
            // Label_WordsCount
            // 
            this.Label_WordsCount.AutoSize = true;
            this.Label_WordsCount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_WordsCount.Location = new System.Drawing.Point(15, 303);
            this.Label_WordsCount.Name = "Label_WordsCount";
            this.Label_WordsCount.Size = new System.Drawing.Size(106, 21);
            this.Label_WordsCount.TabIndex = 6;
            this.Label_WordsCount.Text = "Words Count";
            // 
            // Label_CharCount
            // 
            this.Label_CharCount.AutoSize = true;
            this.Label_CharCount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CharCount.Location = new System.Drawing.Point(15, 353);
            this.Label_CharCount.Name = "Label_CharCount";
            this.Label_CharCount.Size = new System.Drawing.Size(135, 21);
            this.Label_CharCount.TabIndex = 7;
            this.Label_CharCount.Text = "Characters Count";
            // 
            // TBx_FileName
            // 
            this.TBx_FileName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBx_FileName.Location = new System.Drawing.Point(159, 100);
            this.TBx_FileName.Name = "TBx_FileName";
            this.TBx_FileName.Size = new System.Drawing.Size(196, 29);
            this.TBx_FileName.TabIndex = 8;
            // 
            // TBx_Size
            // 
            this.TBx_Size.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBx_Size.Location = new System.Drawing.Point(159, 150);
            this.TBx_Size.Name = "TBx_Size";
            this.TBx_Size.Size = new System.Drawing.Size(196, 29);
            this.TBx_Size.TabIndex = 9;
            // 
            // TBx_URL
            // 
            this.TBx_URL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBx_URL.Location = new System.Drawing.Point(159, 200);
            this.TBx_URL.Name = "TBx_URL";
            this.TBx_URL.Size = new System.Drawing.Size(196, 29);
            this.TBx_URL.TabIndex = 10;
            // 
            // TBx_LineCount
            // 
            this.TBx_LineCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBx_LineCount.Location = new System.Drawing.Point(159, 250);
            this.TBx_LineCount.Name = "TBx_LineCount";
            this.TBx_LineCount.Size = new System.Drawing.Size(196, 29);
            this.TBx_LineCount.TabIndex = 11;
            // 
            // TBx_WordsCount
            // 
            this.TBx_WordsCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBx_WordsCount.Location = new System.Drawing.Point(159, 300);
            this.TBx_WordsCount.Name = "TBx_WordsCount";
            this.TBx_WordsCount.Size = new System.Drawing.Size(196, 29);
            this.TBx_WordsCount.TabIndex = 12;
            // 
            // TBx_CharCount
            // 
            this.TBx_CharCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBx_CharCount.Location = new System.Drawing.Point(159, 350);
            this.TBx_CharCount.Name = "TBx_CharCount";
            this.TBx_CharCount.Size = new System.Drawing.Size(196, 29);
            this.TBx_CharCount.TabIndex = 13;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.Yellow;
            this.Btn_Exit.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Exit.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Btn_Exit.Location = new System.Drawing.Point(12, 427);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(343, 40);
            this.Btn_Exit.TabIndex = 14;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 491);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.TBx_CharCount);
            this.Controls.Add(this.TBx_WordsCount);
            this.Controls.Add(this.TBx_LineCount);
            this.Controls.Add(this.TBx_URL);
            this.Controls.Add(this.TBx_Size);
            this.Controls.Add(this.TBx_FileName);
            this.Controls.Add(this.Label_CharCount);
            this.Controls.Add(this.Label_WordsCount);
            this.Controls.Add(this.Label_LineCount);
            this.Controls.Add(this.Label_URL);
            this.Controls.Add(this.Label_Size);
            this.Controls.Add(this.Label_FileName);
            this.Controls.Add(this.Btn_ReadFile);
            this.Controls.Add(this.RTBx_Output);
            this.Name = "Bai02";
            this.Text = "Bài 02 - Đọc thông tin một file .txt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTBx_Output;
        private System.Windows.Forms.Button Btn_ReadFile;
        private System.Windows.Forms.Label Label_FileName;
        private System.Windows.Forms.Label Label_Size;
        private System.Windows.Forms.Label Label_URL;
        private System.Windows.Forms.Label Label_LineCount;
        private System.Windows.Forms.Label Label_WordsCount;
        private System.Windows.Forms.Label Label_CharCount;
        private System.Windows.Forms.TextBox TBx_FileName;
        private System.Windows.Forms.TextBox TBx_Size;
        private System.Windows.Forms.TextBox TBx_URL;
        private System.Windows.Forms.TextBox TBx_LineCount;
        private System.Windows.Forms.TextBox TBx_WordsCount;
        private System.Windows.Forms.TextBox TBx_CharCount;
        private System.Windows.Forms.Button Btn_Exit;
    }
}