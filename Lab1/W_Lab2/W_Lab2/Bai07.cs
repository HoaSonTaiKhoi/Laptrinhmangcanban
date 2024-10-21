using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using System.Drawing.Imaging;
using System.Drawing.Text;
using Microsoft.Office.Interop.Word;
using PdfiumViewer;

namespace W_Lab2
{
    public partial class Bai07 : Form
    {
        public Bai07()
        {

            InitializeComponent();
            //Add Picture Box
            pB1_Output = new System.Windows.Forms.PictureBox();
            this.pB1_Output.Location = new System.Drawing.Point(382, 12);
            this.pB1_Output.Name = "Rtbx_Output";
            this.pB1_Output.Size = new System.Drawing.Size(691, 587);
            this.pB1_Output.TabIndex = 4;
            this.pB1_Output.Text = "";
            this.Controls.Add(pB1_Output);
            this.pB1_Output.Hide();
            //Add root nodes

            string root1 = @"C:\", root2 = @"D:\";
            treeView.Nodes.Clear();
            
            TreeNode newroot= new TreeNode(root1);
            treeView.Nodes.Add(newroot);
            newroot=new TreeNode(root2);
            treeView.Nodes.Add(newroot);

            treeView.NodeMouseDoubleClick += treeView_Node_Double_Click;
            treeView.NodeMouseClick += treeView_Node_Click;
        }


        private void LoadNode(TreeNode root)
        {
            if (root == null|| File.Exists(root.FullPath) || root.Nodes.Count>0) return;

            DirectoryInfo di=new DirectoryInfo(root.FullPath);

            DirectoryInfo[] folderList = di.GetDirectories();

            FileInfo[] fileList = di.GetFiles();

            if (folderList.Count() < 1 && fileList.Count() < 1) { return; }

            //Add Folder and File into Parent Node
            foreach (DirectoryInfo folder in folderList)
            {
                if(Directory.Exists(folder.FullName) && !folder.Attributes.HasFlag(FileAttributes.Directory | FileAttributes.Hidden))
                {
                    TreeNode newnode= new TreeNode(folder.Name);
                    root.Nodes.Add(newnode);
                }    
            }

            foreach (FileInfo file in fileList)
            {
                if (File.Exists(file.FullName) && !file.Attributes.HasFlag(FileAttributes.Directory | FileAttributes.Hidden))
                {
                    TreeNode newnode = new TreeNode(file.Name);
                    root.Nodes.Add(newnode);
                }
            }

        }

        private void treeView_Node_Double_Click(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (treeView.SelectedNode == null) return;
            LoadNode(e.Node);
            e.Node.Expand();
            return;
        }

        private void treeView_Node_Click(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (treeView.SelectedNode == e.Node) return;
            if (File.Exists(e.Node.FullPath))
            {
                OpenFile(e.Node);
                /*Rtbx_Output.Text += System.Environment.NewLine;
                Rtbx_Output.Text += "Name: " + e.Node.Text + System.Environment.NewLine + System.Environment.NewLine;
                Rtbx_Output.Text += "Details: " + System.Environment.NewLine;
                Rtbx_Output.Text += "Type:                 File Folder" + System.Environment.NewLine;
                Rtbx_Output.Text += "File location:             " + e.Node.FullPath + System.Environment.NewLine; */
            }
            else if (Directory.Exists(e.Node.FullPath))
            {
                this.Rtbx_Output.Show();
                Rtbx_Output.Clear();
                Rtbx_Output.Text += "Name: " + e.Node.Text + System.Environment.NewLine + System.Environment.NewLine;
                Rtbx_Output.Text += "Details: " + System.Environment.NewLine;
                Rtbx_Output.Text += "Type:                 File Folder" + System.Environment.NewLine;
                Rtbx_Output.Text += "File location:             " + e.Node.FullPath + System.Environment.NewLine;
            }
            else
            {
                Rtbx_Output.Text = "Không thể mở hoặc hiện thông tin!";  
            } 
                
        }


        private void OpenFile(TreeNode node)
        {
            //Image
            string[] validImageExtensions = { ".jpg", ".png", ".gif", "jpeg","tiff", "eps",".ai", "indd", "raw", "heic"};
            string[] validDocExtensions = { ".doc", ".docx" };
            string[] invalidExtensions = { ".exe", ".zip", ".tar", ".rar", ".pdb", ".dll", ".npukg", ".p7s", ".psd", ".sys"};
            string extension = Path.GetExtension(node.Text);
            extension = extension.ToLower();
            if (validImageExtensions.Contains(extension))
            {



                /*
                  using (Image image = Image.FromFile(node.FullPath))
                  {
                      Clipboard.SetImage(image);
                      Rtbx_Output.Paste();
                      Clipboard.Clear();
                  } */

                Rtbx_Output.Clear();
                /*
                 string lstrFile = node.FullPath;
                 Bitmap myBitmap = new Bitmap(lstrFile);

                 Clipboard.SetDataObject(myBitmap);
                 // Get the format for the object type.
                 DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
                 // After verifying that the data can be pasted, paste
                 if (Rtbx_Output.CanPaste(myFormat))
                 {
                     Rtbx_Output.Paste(myFormat);
                 }
                 else
                 {
                     MessageBox.Show("The data format that you attempted site" +
                       " is not supportedby this control.");
                 }
                 Clipboard.Clear();
                 myBitmap = null;
                 myFormat = null;

                 // Tạo đối tượng hình ảnh từ tệp tin
                */
                this.Rtbx_Output.Hide();
                this.pB1_Output.Show();

                pB1_Output.SizeMode = PictureBoxSizeMode.Zoom;
                Image image = Image.FromFile(node.FullPath);

                // Đặt hình ảnh vào PictureBox
                pB1_Output.Image = image;
            }
           
            else if(validDocExtensions.Contains(extension))
            {
                this.Rtbx_Output.Show();
                this.pB1_Output.Hide();
                this.Rtbx_Output.Clear();
                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();

                // Mở file DOC
                Document doc = wordApp.Documents.Open(node.FullPath);

                // Đọc nội dung từ các đoạn văn trong file DOC
                string text = string.Empty;
                foreach (Paragraph paragraph in doc.Paragraphs)
                {
                    text += paragraph.Range.Text;
                }

                // Đóng file DOC
                doc.Close();

                // Đóng ứng dụng Microsoft Word
                wordApp.Quit();

                // In ra nội dung đọc được
                Rtbx_Output.Text = text;
               
            }  
            else if(invalidExtensions.Contains(extension))
            {
                this.Rtbx_Output.Show();
                this.pB1_Output.Hide();
                Rtbx_Output.Clear();
                Rtbx_Output.Text += "Name: " + node.Text + System.Environment.NewLine + System.Environment.NewLine;
                Rtbx_Output.Text += "Details: " + System.Environment.NewLine;
                Rtbx_Output.Text += "Type:                 "+extension + System.Environment.NewLine;
                Rtbx_Output.Text += "File location:             " + node.FullPath + System.Environment.NewLine;
            }    
            else
            {

                this.Rtbx_Output.Show();
                this.pB1_Output.Hide();
                Rtbx_Output.Clear();
                using (FileStream fs = new FileStream(node.FullPath, FileMode.OpenOrCreate))
                {
                    using (StreamReader sr =new StreamReader(fs))
                    {
                        string Content=sr.ReadToEnd();
                        Rtbx_Output.Text = Content;
                    }    
                }    

            }    
        }
        private void treeView_DoubleClick(object sender, EventArgs e)
        {

        }
        private System.Windows.Forms.PictureBox pB1_Output;
    }
}
