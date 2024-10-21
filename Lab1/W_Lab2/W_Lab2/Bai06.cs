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
using System.Data.SQLite;
using DocumentFormat.OpenXml.EMMA;

namespace W_Lab2
{
    public partial class Bai06 : Form
    {
        string strConnect = $"Data Source={@".\\Source\\bai6.db"}";
        public Bai06()
        {
            InitializeComponent();
            CheckDataBase();
        }


        private void CheckDataBase()
        {
            string strPath = ".\\Source\\Bai6.db";
            if (!File.Exists(strPath))
            {
                SQLiteConnection.CreateFile(strPath);
                
                using (SQLiteConnection connect = new SQLiteConnection(strConnect)) 
                {
                    connect.Open();
                    string createTableQuery="CREATE TABLE IF NOT EXISTS MonAn " +
                        "(IDMA NVARCHAR(10), TenMonAn NVARCHAR(50), HinhAnh NVARCHAR(240), IDNCC NVARCHAR(10))";
                    using (SQLiteCommand createTableMonAn = new SQLiteCommand(createTableQuery, connect))
                    {
                        createTableMonAn.ExecuteNonQuery();
                    }


                    createTableQuery = "CREATE TABLE IF NOT EXISTS NguoiDung (IDNCC NVARCHAR(10), HoVaTen NVARCHAR(200), QuyenHan NVARCHAR(50))";
                    using (SQLiteCommand createTableOwner = new SQLiteCommand(createTableQuery, connect)) 
                    {
                        createTableOwner.ExecuteNonQuery();
                    }
                }
                InsertMonAn("MA01", "Mì xào giòn", @".\\Source\\Mixaogion.jpg", "NV047");
                InsertMonAn("MA02", "Bánh canh cá lóc", @".\\Source\\Banhcanhcaloc.jpg", "NV191");
                InsertMonAn("MA03", "Phở bò", @".\\Source\\BeMit.jpg", "NV012");
                InsertMonAn("MA04", "Tobokki", @".\\Source\\Tobokki.jpg", "NV666");
                InsertMonAn("MA05", "Mỉ Quảng Phú Chiêm", @".\\Source\\MiQuangPhuChiem.jpg", "NV121");
                InsertMonAn("MA06", "Bò kho cốt dừa", @".\\Source\\Bokho.jpg", "NV666");
                InsertMonAn("MA07", "Hủ tiếu gõ", @".\\Source\\Hutieugo.jpg", "NV777");
                InsertMonAn("MA08", "Hàu nướng", @".\\Source\\Haunuong.jpg", "NV047");

                InsertNguoiDung("NV047", "Thạch Hạo", "Cook");
                InsertNguoiDung("NV191", "Bạch Tiểu Thuần", "Watcher");
                InsertNguoiDung("NV012", "Tiêu Viêm", "Xem");
                InsertNguoiDung("NV666", "Mijin", "Cook");
                InsertNguoiDung("NV121", "Lã Thụ", "Tổng giám đốc");
                InsertNguoiDung("NV777", "La Phong", "Phụ bếp");

            }
            get_MonAn_FromDataBase();
            return;
        }

        private void InsertMonAn(string IDMA, string TenMonAn, string HinhAnh, string IDNCC)
        {
            using (SQLiteConnection connect = new SQLiteConnection(strConnect))
            {
                string insertData = "INSERT INTO MonAn ([IDMA],[TenMonAn],[HinhAnh],[IDNCC]) VALUES (@IDMA,@TenMonAn,@HinhAnh,@IDNCC)";
                using (SQLiteCommand command = new SQLiteCommand(insertData, connect))
                {
                    connect.Open();
                    command.Parameters.AddWithValue("@IDMA", IDMA);
                    command.Parameters.AddWithValue("@TenMonAn", TenMonAn);
                    command.Parameters.AddWithValue("@HinhAnh", HinhAnh);
                    command.Parameters.AddWithValue("@IDNCC", IDNCC);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void InsertNguoiDung(string IDNCC, string HoVaTen, string QuyenHan)
        {
            using (SQLiteConnection connect = new SQLiteConnection(strConnect))
            {
                string insertData = "INSERT INTO NguoiDung ([IDNCC],[HoVaTen],[QuyenHan]) VALUES (@IDNCC, @HoVaTen, @QuyenHan)";
                using (SQLiteCommand command = new SQLiteCommand(insertData, connect))
                {
                    connect.Open();
                    command.Parameters.AddWithValue("@IDNCC", IDNCC);
                    command.Parameters.AddWithValue("@HoVaTen", HoVaTen);
                    command.Parameters.AddWithValue("@QuyenHan", QuyenHan);
                    command.ExecuteNonQuery();
                }    
            }    
        }

        private void get_MonAn_FromDataBase()
        {
            using (SQLiteConnection connect = new SQLiteConnection(strConnect))
            {
                connect.Open();
                string query = "SELECT * FROM MonAn";
                using (SQLiteCommand command = new SQLiteCommand(query, connect))
                {
                    using(SQLiteDataReader reader = command.ExecuteReader()) 
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader.GetString(0));
                            item.SubItems.Add(reader.GetString(1));
                            item.SubItems.Add(reader.GetString(2));
                            item.SubItems.Add(reader.GetString(3));
                            listView.Items.Add(item);
                        }
                    }
                }
                connect.Close();
            }
        }

        private void get_HinhAnh_MonAn(string IDMA)
        {
            using (SQLiteConnection connect = new SQLiteConnection(strConnect))
            {
                connect.Open();
                string query = $"SELECT HinhAnh FROM MonAn WHERE IDMA ='{IDMA}'";
                using (SQLiteCommand command = new SQLiteCommand(query, connect))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string strImg=reader.GetString(0);
                            Image image = Image.FromFile(strImg);
                            pB1.Image = image;
                        }
                    }
                }
                connect.Close();    
            }
        }


        private void get_NguoiDung_FromDataBase(string IDMA)
        {
            
            using (SQLiteConnection connect = new SQLiteConnection(strConnect))
            {
                connect.Open();
                string query = $"SELECT ma.TenMonAn,nd.IDNCC, nd.HoVaTen FROM MonAn ma JOIN NguoiDung nd ON ma.IDNCC = nd.IDNCC WHERE IDMA = '{IDMA}'" ;
                using (SQLiteCommand command = new SQLiteCommand(query, connect))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Rtbx_Provider.Text = string.Empty;
                            string ma = reader.GetString(0), idncc = reader.GetString(1), ncc = reader.GetString(2);
                            Rtbx_Provider.Text = "Hôm nay ăn: " + System.Environment.NewLine;
                            Rtbx_Provider.Text += "Món ăn: " + ma + System.Environment.NewLine;
                            Rtbx_Provider.Text += "Người cung cấp: " + ncc + " - " + idncc;
                        }
                    }
                }
                connect.Close();
            }
        }

        private void Btn_Random_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(listView.Items.Count) ;
            ListViewItem item = listView.Items[randomIndex];
            string IDMA = item.SubItems[0].Text;
            get_HinhAnh_MonAn(IDMA);
            get_NguoiDung_FromDataBase(IDMA);

            //MessageBox.Show(treeView.Nodes[temp].Tag.ToString());
        }
    }
}
