namespace Winform_Lab1
{
    partial class Bai8
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
            this.Label_Input = new System.Windows.Forms.Label();
            this.Label_Output = new System.Windows.Forms.Label();
            this.TBx_Input = new System.Windows.Forms.TextBox();
            this.TBx_Output = new System.Windows.Forms.TextBox();
            this.List_Food = new System.Windows.Forms.ListBox();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Find = new System.Windows.Forms.Button();
            this.Btn_Del_All = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Label_Del = new System.Windows.Forms.Label();
            this.TBx_Del_1 = new System.Windows.Forms.TextBox();
            this.Btn_Del_1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_Input
            // 
            this.Label_Input.AutoSize = true;
            this.Label_Input.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Input.Location = new System.Drawing.Point(49, 43);
            this.Label_Input.Name = "Label_Input";
            this.Label_Input.Size = new System.Drawing.Size(107, 21);
            this.Label_Input.TabIndex = 0;
            this.Label_Input.Text = "Nhập món ăn";
            // 
            // Label_Output
            // 
            this.Label_Output.AutoSize = true;
            this.Label_Output.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Output.Location = new System.Drawing.Point(374, 394);
            this.Label_Output.Name = "Label_Output";
            this.Label_Output.Size = new System.Drawing.Size(151, 21);
            this.Label_Output.TabIndex = 1;
            this.Label_Output.Text = "Món ăn hôm nay là:";
            // 
            // TBx_Input
            // 
            this.TBx_Input.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBx_Input.Location = new System.Drawing.Point(156, 42);
            this.TBx_Input.Name = "TBx_Input";
            this.TBx_Input.Size = new System.Drawing.Size(216, 25);
            this.TBx_Input.TabIndex = 2;
            this.TBx_Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBx_Input_KeyPress);
            // 
            // TBx_Output
            // 
            this.TBx_Output.BackColor = System.Drawing.SystemColors.Window;
            this.TBx_Output.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBx_Output.Location = new System.Drawing.Point(238, 418);
            this.TBx_Output.Name = "TBx_Output";
            this.TBx_Output.Size = new System.Drawing.Size(414, 25);
            this.TBx_Output.TabIndex = 3;
            // 
            // List_Food
            // 
            this.List_Food.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List_Food.FormattingEnabled = true;
            this.List_Food.ItemHeight = 17;
            this.List_Food.Location = new System.Drawing.Point(486, 42);
            this.List_Food.Name = "List_Food";
            this.List_Food.Size = new System.Drawing.Size(362, 242);
            this.List_Food.TabIndex = 4;
            this.List_Food.SelectedValueChanged += new System.EventHandler(this.List_Food_SelectedValueChanged);
            // 
            // Btn_Add
            // 
            this.Btn_Add.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add.Location = new System.Drawing.Point(378, 39);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(75, 30);
            this.Btn_Add.TabIndex = 5;
            this.Btn_Add.Text = "Thêm";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Find
            // 
            this.Btn_Find.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Find.Location = new System.Drawing.Point(115, 317);
            this.Btn_Find.Name = "Btn_Find";
            this.Btn_Find.Size = new System.Drawing.Size(152, 30);
            this.Btn_Find.TabIndex = 6;
            this.Btn_Find.Text = "Tìm kiếm món ăn";
            this.Btn_Find.UseVisualStyleBackColor = true;
            this.Btn_Find.Click += new System.EventHandler(this.Btn_Find_Click);
            // 
            // Btn_Del_All
            // 
            this.Btn_Del_All.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Del_All.Location = new System.Drawing.Point(406, 317);
            this.Btn_Del_All.Name = "Btn_Del_All";
            this.Btn_Del_All.Size = new System.Drawing.Size(75, 30);
            this.Btn_Del_All.TabIndex = 7;
            this.Btn_Del_All.Text = "Xóa hết";
            this.Btn_Del_All.UseVisualStyleBackColor = true;
            this.Btn_Del_All.Click += new System.EventHandler(this.Btn_Del_All_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Exit.Location = new System.Drawing.Point(633, 317);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(75, 30);
            this.Btn_Exit.TabIndex = 8;
            this.Btn_Exit.Text = "Thoát";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Label_Del
            // 
            this.Label_Del.AutoSize = true;
            this.Label_Del.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Del.Location = new System.Drawing.Point(10, 87);
            this.Label_Del.Name = "Label_Del";
            this.Label_Del.Size = new System.Drawing.Size(140, 21);
            this.Label_Del.TabIndex = 9;
            this.Label_Del.Text = "Xóa món ăn(Click)";
            // 
            // TBx_Del_1
            // 
            this.TBx_Del_1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBx_Del_1.Location = new System.Drawing.Point(156, 86);
            this.TBx_Del_1.Name = "TBx_Del_1";
            this.TBx_Del_1.ReadOnly = true;
            this.TBx_Del_1.Size = new System.Drawing.Size(216, 25);
            this.TBx_Del_1.TabIndex = 10;
            // 
            // Btn_Del_1
            // 
            this.Btn_Del_1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Del_1.Location = new System.Drawing.Point(378, 85);
            this.Btn_Del_1.Name = "Btn_Del_1";
            this.Btn_Del_1.Size = new System.Drawing.Size(75, 30);
            this.Btn_Del_1.TabIndex = 11;
            this.Btn_Del_1.Text = "Xóa";
            this.Btn_Del_1.UseVisualStyleBackColor = true;
            this.Btn_Del_1.Click += new System.EventHandler(this.Btn_Del_1_Click);
            // 
            // Bai8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 525);
            this.Controls.Add(this.Btn_Del_1);
            this.Controls.Add(this.TBx_Del_1);
            this.Controls.Add(this.Label_Del);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Del_All);
            this.Controls.Add(this.Btn_Find);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.List_Food);
            this.Controls.Add(this.TBx_Output);
            this.Controls.Add(this.TBx_Input);
            this.Controls.Add(this.Label_Output);
            this.Controls.Add(this.Label_Input);
            this.Name = "Bai8";
            this.Text = "Bài 8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Input;
        private System.Windows.Forms.Label Label_Output;
        private System.Windows.Forms.TextBox TBx_Input;
        private System.Windows.Forms.TextBox TBx_Output;
        private System.Windows.Forms.ListBox List_Food;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Find;
        private System.Windows.Forms.Button Btn_Del_All;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Label Label_Del;
        private System.Windows.Forms.TextBox TBx_Del_1;
        private System.Windows.Forms.Button Btn_Del_1;
    }
}