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
    public partial class Edit_Image : Form
    {
        Controller con = new Controller();
        int id;
        char Kind;
        byte[] img = null;
        bool New_Image = false;
        public Edit_Image(int ids,char kind)
        {
            InitializeComponent();
            if (kind == 'O')
            {if (ids == -2)
                    button2.Text = "إضافة";
                else if (ids == -3)
                    button2.Text = "تعديل";
                else if (ids == -4)
                    button2.Visible = false;
             }
            id = ids;
            Kind = kind;
        }

        private void Edit_Contract_Image_Load(object sender, EventArgs e)
        {
            DataTable d;
            if (Kind == 'P')
            {
                 d = con.getdatacolumn("File_Name", "Images", "Person_Id = "+id);
            }
            else if(Kind == 'O')
                d = con.getdatacolumn("File_Name", "other", "Image_id is not null");
            else
            {
                d = con.getdatacolumn("File_Name", "Images", "Apartment_id = " + id);
            }

            if (d == null)
                return;
            for(int i = 0;i <d.Rows.Count;i++)

            {
                comboBox1.Items.Add(d.Rows[i][0].ToString());
            }

            comboBox1.SelectedIndex = 0;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Byte[] IMG;
            if (Kind == 'P')
            {
                if (con.getvalue("count(*)", "Images", "File_Name = '" + comboBox1.Text + "' and Person_Id =" + id) == 0)
                {
                    pictureBox1.Image = null;
                    return;
                }
                IMG = con.getimage("File_Name = '" + comboBox1.Text + "' and Person_Id =" + id);

            }
            else if (Kind == 'O')
            {
                if (con.getvalue("count(*)", "other", "File_Name = '" + comboBox1.Text+"'") == 0)
                {
                    pictureBox1.Image = null;
                    return;
                }
                IMG = con.getOtherimage("File_Name = '" + comboBox1.Text + "'");

            }
            else
            {
                if (con.getvalue("count(*)", "Images", "File_Name = '" + comboBox1.Text + "' and Apartment_id =" + id) == 0)
                {
                    pictureBox1.Image = null;
                    return;
                }
                IMG = con.getimage("File_Name = '" + comboBox1.Text + "' and Apartment_id =" + id);

            }

            MemoryStream ms = new MemoryStream(IMG);
            pictureBox1.Image = Image.FromStream(ms);
            New_Image = false;
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
                New_Image = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (New_Image == false || comboBox1.Text == "")
            {
                MessageBoxs.mes.Show("لم يتم تغيير الصورة");
                return;
            }
            FileStream fs = new FileStream(pictureBox1.ImageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);
            if (Kind == 'P')
            {
                if (con.Editimage(img, comboBox1.Text, id.ToString(), "NULL") != 0)
                {
                    MessageBoxs.mes.Show("تم تعديل الصورة");
                }
                else
                {
                    MessageBoxs.mes.Show("لم يتم تعديل الصورة");
                }
            }
            else if(Kind == 'O')
            {
                if (con.EditOtherImage(img, comboBox1.Text) != 0)
                {
                    MessageBoxs.mes.Show("تم تعديل الصورة");
                }
                else
                {
                    MessageBoxs.mes.Show("لم يتم تعديل الصورة");
                }
            }
            else
            {
                if (con.Editimage(img, comboBox1.Text, "NULL", id.ToString()) != 0)
                {
                    MessageBoxs.mes.Show("تم تعديل الصورة");
                }
                else
                {
                    MessageBoxs.mes.Show("لم يتم تعديل الصورة");
                }
            }
        }

        private void comboBox1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
                return;
            if (Kind == 'P')
            {
                if (con.Delete_Image(comboBox1.Text, id.ToString(), "NULL") != 0)
                    MessageBoxs.mes.Show("تم حذف هذا النوع من الصور");
            }
            else if (Kind == 'O')
            {
                if (con.Delete_Other_Image(comboBox1.Text) != 0)
                    MessageBoxs.mes.Show("تم حذف هذا النوع من الصور");
            }
            else
            {
                if (con.Delete_Image(comboBox1.Text, "NULL", id.ToString()) != 0)
                    MessageBoxs.mes.Show("تم حذف هذا النوع من الصور");
            }

            comboBox1.Items.Remove(comboBox1.Text);
            comboBox1.Text = "";
            pictureBox1.Image = null;
            if (comboBox1.Items.Count > 0)
                comboBox1.Text = comboBox1.Items[0].ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
