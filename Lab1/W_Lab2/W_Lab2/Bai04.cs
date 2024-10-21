using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace W_Lab2
{


    public partial class Bai04 : Form
    {
        
        List<Hocvien> addingHocviens= new List<Hocvien>();
        List<Hocvien> existHocviens = new List<Hocvien>();
        public Bai04()
        {
            InitializeComponent();
            Btn_Next.Enabled = false;
            Btn_Back.Enabled = false;
        }

        private void Btn_Add_1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Tbx_Name1.Text)
                || string.IsNullOrEmpty(Tbx_ID1.Text)
                || string.IsNullOrEmpty(Tbx_Phone1.Text)
                || string.IsNullOrEmpty(Tbx_Course1_1.Text)
                || string.IsNullOrEmpty(Tbx_Course1_2.Text)
                || string.IsNullOrEmpty(Tbx_Course1_3.Text))
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }

            //Check condition input
            if (!Check_Name(Tbx_Name1.Text) || !Check_ID(Tbx_ID1.Text) || !Check_Phone(Tbx_Phone1.Text) || !Check_Course(Tbx_Course1_1.Text)
                || !Check_Course(Tbx_Course1_2.Text) || !Check_Course(Tbx_Course1_3.Text))
            {
                MessageBox.Show("Một trong các trường nhập chưa đúng!");
                return;
            }

            // create object hocvien
            Hocvien hv = new Hocvien
            {
                Name = Tbx_Name1.Text,
                ID = int.Parse(Tbx_ID1.Text),
                Phone = Tbx_Phone1.Text,
                Scores = new float[3] { float.Parse(Tbx_Course1_1.Text), float.Parse(Tbx_Course1_2.Text), float.Parse(Tbx_Course1_3.Text) },
                average = -1,
            };

            addingHocviens.Add(hv);
            Update_Rtbx_ShowList(addingHocviens);
            Tbx_Name1.Text=Tbx_Phone1.Text=Tbx_ID1.Text=Tbx_Course1_3.Text=Tbx_Course1_1.Text=Tbx_Course1_2.Text=String.Empty;
        }
        private void Btn_Write_Click(object sender, EventArgs e)
        {
            string strInputFile = ".\\Source\\input4.json", strOutputFile = ".\\Source\\output4.json";

            /*FileStream fs = new FileStream(strInputFile, FileMode.OpenOrCreate);
            StreamReader rs = new StreamReader(fs); */
            /*BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream(strInputFile, FileMode.OpenOrCreate))
            {
                bf.Serialize(fs, hv);
            }*/


           /*
            // Read all from old jsonfile
            List<Hocvien> existHocviens = new List<Hocvien>();
            using (FileStream fs = new FileStream(strInputFile, FileMode.OpenOrCreate))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string jsonContent = sr.ReadToEnd();
                    existHocviens = JsonConvert.DeserializeObject<List<Hocvien>>(jsonContent);
                }

            }
           */

            
            using (StreamWriter sw = new StreamWriter(strInputFile))
            {
                JsonSerializer js= new JsonSerializer();
                js.Serialize(sw, addingHocviens);
            }

            MessageBox.Show("File has been written successfully!");
            addingHocviens.Clear();
            addingHocviens = new List<Hocvien>();
            return;
        }

        private void Btn_Read_Click(object sender, EventArgs e)
        {
            string strInputFile = ".\\Source\\input4.json", strOutputFile = ".\\Source\\output4.json";
            existHocviens=new List<Hocvien>();
            using (FileStream fs = new FileStream(strInputFile, FileMode.OpenOrCreate))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string jsonContent = sr.ReadToEnd();
                    existHocviens = JsonConvert.DeserializeObject<List<Hocvien>>(jsonContent);
                }

            }

            if(existHocviens == null)
            {
                MessageBox.Show("File rỗng!");
                return;
            }
            
            // Average
            foreach(Hocvien hv in  existHocviens)
            {
                hv.average = (hv.Scores[0] + hv.Scores[1] + hv.Scores[2]) / 3;
            }

            //Check Label Index
            if (Label_Index.Text == "0") Label_Index.Text = "1";
            if (existHocviens.Count == 1)
            {
                Btn_Back.Enabled = false;
                Btn_Next.Enabled = false;
            }
            else
            {
                Btn_Back.Enabled = false;
                Btn_Next.Enabled = true;
            }
            
            // Update Content
            Update_Selected_Index(int.Parse(Label_Index.Text)-1);
            Update_Rtbx_ShowList(existHocviens);


            using (StreamWriter sw = new StreamWriter(strOutputFile))
            {
                JsonSerializer js = new JsonSerializer();
                js.Serialize(sw, existHocviens);
            }    
        }

        private void Update_Selected_Index(int index)
        {
            
            Tbx_Name2.Text = existHocviens[index].Name;
            Tbx_ID2.Text = existHocviens[index].ID.ToString();
            Tbx_Phone2.Text= existHocviens[index].Phone;
            Tbx_Course2_1.Text= existHocviens[index].Scores[0].ToString();
            Tbx_Course2_2.Text= existHocviens[index].Scores[1].ToString();
            Tbx_Course2_3.Text = existHocviens[index].Scores[2].ToString();
            Tbx_Average2.Text = existHocviens[index].average.ToString();
        }

        private void Update_Rtbx_ShowList(List<Hocvien> tempHocviens)
        {
            //Clear RichTextBox
            Rtbx_ShowList.Text = String.Empty;
            if (existHocviens==null) return;
            foreach (Hocvien hv_temp in tempHocviens)
            {
                Rtbx_ShowList.Text += hv_temp.Name + System.Environment.NewLine;
                Rtbx_ShowList.Text += hv_temp.ID.ToString() + System.Environment.NewLine;
                Rtbx_ShowList.Text += hv_temp.Phone + System.Environment.NewLine;
                foreach (float score in hv_temp.Scores)
                    Rtbx_ShowList.Text += score.ToString() + System.Environment.NewLine;
                    
                if (hv_temp.average != -1) Rtbx_ShowList.Text += hv_temp.average.ToString() + System.Environment.NewLine;
                Rtbx_ShowList.Text += System.Environment.NewLine;
            }
        }

        private bool Check_Name(string Name)
        {
            for(int i=0; i<Name.Length; i++)
            {
                if (!char.IsLetter(Name[i]) && Name[i]!=' ')
                {
                    return false;
                }    
            }    
            return true;
        }

        private bool Check_ID(string ID)
        {
            for(int i=0; i<ID.Length; i++)
            {
                if (ID[i] < '0' || ID[i] > '9')
                    return false;
            }    
            return true;
        }

        private bool Check_Phone(string Phone)
        {
            if (Phone[0] != '0') return false;
            for (int i = 1; i < Phone.Length; i++) if (Phone[i] < '0' || Phone[i] > '9') return false;
            return true;
        }

        private bool Check_Course(string Course)
        {
            float temp;
            if(!float.TryParse( Course, out temp) || temp < 0 || temp>10)
            {
                return false;
            }
            return true;
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Btn_Back.Enabled = true;
            
            Label_Index.Text = (int.Parse(Label_Index.Text) - 1).ToString();
            if (int.Parse(Label_Index.Text) < existHocviens.Count) Btn_Next.Enabled = true;
            Update_Selected_Index(int.Parse(Label_Index.Text) - 1);
            
            if (Label_Index.Text=="1" || Label_Index.Text == "0")
            {
                Btn_Back.Enabled = false;
                Label_Index.Text = "1";
                return;
            }
            
        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {
            Btn_Next.Enabled = true;
            Label_Index.Text = (int.Parse(Label_Index.Text) + 1).ToString();
            Update_Selected_Index(int.Parse(Label_Index.Text) - 1);
            if (int.Parse(Label_Index.Text) >= existHocviens.Count && existHocviens.Count > 1)
            {

                Btn_Next.Enabled = false;
                Btn_Back.Enabled = true;
                return;
            }   
        }
    }

    public class Hocvien
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string Phone { get; set; }
        public float[] Scores { get; set; }
        public float average;
    }

}
