namespace W_Lab2
{
    partial class Bai06
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
            this.listView = new System.Windows.Forms.ListView();
            this.Col_IDMA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_TenMonAn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_HinhAnh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_IDNCC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pB1 = new System.Windows.Forms.PictureBox();
            this.Btn_Random = new System.Windows.Forms.Button();
            this.Rtbx_Provider = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pB1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col_IDMA,
            this.Col_TenMonAn,
            this.Col_HinhAnh,
            this.Col_IDNCC});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(20, 16);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(311, 550);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // Col_IDMA
            // 
            this.Col_IDMA.Text = "IDMA";
            this.Col_IDMA.Width = 40;
            // 
            // Col_TenMonAn
            // 
            this.Col_TenMonAn.Text = "TenMonAn";
            this.Col_TenMonAn.Width = 110;
            // 
            // Col_HinhAnh
            // 
            this.Col_HinhAnh.Text = "HinhAnh";
            this.Col_HinhAnh.Width = 100;
            // 
            // Col_IDNCC
            // 
            this.Col_IDNCC.Text = "IDNCC";
            // 
            // pB1
            // 
            this.pB1.Location = new System.Drawing.Point(348, 18);
            this.pB1.Name = "pB1";
            this.pB1.Size = new System.Drawing.Size(735, 548);
            this.pB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB1.TabIndex = 1;
            this.pB1.TabStop = false;
            // 
            // Btn_Random
            // 
            this.Btn_Random.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Random.Location = new System.Drawing.Point(90, 594);
            this.Btn_Random.Name = "Btn_Random";
            this.Btn_Random.Size = new System.Drawing.Size(181, 75);
            this.Btn_Random.TabIndex = 3;
            this.Btn_Random.Text = "Hôm nay ăn ...";
            this.Btn_Random.UseVisualStyleBackColor = true;
            this.Btn_Random.Click += new System.EventHandler(this.Btn_Random_Click);
            // 
            // Rtbx_Provider
            // 
            this.Rtbx_Provider.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rtbx_Provider.Location = new System.Drawing.Point(348, 575);
            this.Rtbx_Provider.Name = "Rtbx_Provider";
            this.Rtbx_Provider.Size = new System.Drawing.Size(735, 125);
            this.Rtbx_Provider.TabIndex = 4;
            this.Rtbx_Provider.Text = "";
            // 
            // Bai06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 712);
            this.Controls.Add(this.Rtbx_Provider);
            this.Controls.Add(this.Btn_Random);
            this.Controls.Add(this.pB1);
            this.Controls.Add(this.listView);
            this.Name = "Bai06";
            this.Text = "Bài 6 - Hôm nay ăn gì?";
            ((System.ComponentModel.ISupportInitialize)(this.pB1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader Col_IDMA;
        private System.Windows.Forms.ColumnHeader Col_TenMonAn;
        private System.Windows.Forms.ColumnHeader Col_HinhAnh;
        private System.Windows.Forms.ColumnHeader Col_IDNCC;
        private System.Windows.Forms.PictureBox pB1;
        private System.Windows.Forms.Button Btn_Random;
        private System.Windows.Forms.RichTextBox Rtbx_Provider;
    }
}