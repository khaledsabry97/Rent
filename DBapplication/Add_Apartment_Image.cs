using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DBapplication
{
    public partial class Add_Apartment_Image : Form
    {
        string File_Name = "";
        Controller con = new Controller();
    public  static  Dictionary<string, byte[]> Images = new Dictionary<string, byte[]>();
        public Add_Apartment_Image()
        {
            InitializeComponent();
            if (comboBox1.Items.Count > 0)
            comboBox1.Text = comboBox1.Text = comboBox1.Items[comboBox1.Items.Count - 1].ToString();

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if enter key pressed take the combobox text
            if (e.KeyChar == (char)13)
            {
                if (checkBox1.Checked == true)
                {
                    if (comboBox1.Text == "")
                        return;
                    comboBox1.Items.Add(comboBox1.Text);
                    checkBox1.Checked = false;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            File_Name = comboBox1.Text;
            pictureBox1.Image = null;
            if (!Images.ContainsKey(File_Name))
                return;
            MemoryStream ms = new MemoryStream(Images[File_Name]);
            pictureBox1.Image = Image.FromStream(ms);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {

                comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
                comboBox1.Text = "";
            }
            else
            {
                comboBox1.Text = comboBox1.Items[comboBox1.Items.Count - 1].ToString();
                comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ALL Files(*.*)|*.*";
            ofd.Title = "إختر صورة";
            ofd.Multiselect = false;
            

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (Images.ContainsKey(comboBox1.Text))
            {
                MessageBoxs.mes.Show("تم حفظ الصورة");
                return;
            }
            if (File_Name == ""||comboBox1.Text  == "")
            {
                MessageBoxs.mes.Show("من فضلك إختر نوع صورة أولًا");
                return;
            }
            if (pictureBox1.Image == null)
            {
                MessageBoxs.mes.Show("من فضلك إختر صورة أولًا");
                return;
            }
            byte[] img = null;
            FileStream fs = new FileStream(pictureBox1.ImageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);
            Images.Add(File_Name, img);
            File_Name = "";
            MessageBoxs.mes.Show("تم حفظ الصورة");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
                return;

            MessageBoxs.mes.Show("تم حذف هذا النوع من الصور");
            if (Images.ContainsKey(File_Name))
                Images.Remove(comboBox1.Text);
            comboBox1.Items.Remove(comboBox1.Text);
            comboBox1.Text = "";
            pictureBox1.Image = null;
            if (comboBox1.Items.Count > 0)
                comboBox1.Text = comboBox1.Items[0].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add_Apartment.LoadImage(Images);
            Close();
        }

        private void Add_Apartment_Image_Load(object sender, EventArgs e)
        {

        }
    }
}
