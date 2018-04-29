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
    public partial class Images : Form
    {
     public   static List<Image> K = new List<Image>();
        public Images(Image k)
        {
            InitializeComponent();
            //  pictureBox1.Image = k;
            
            imageSlider1.Refresh();
           // Show_Pic.ActiveForm.cha
        }

        public static void Draw_Picture(Image g)
        {
            K.Add(g);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void Images_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < K.Count; i++)
                imageSlider1.Images.Add(K[i]);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Print_String(string s,Point q)
        {/*
            Font arialFont = new Font("Arial", 10);
            Point c = new Point(1000, 2000);
            //  MessageBoxs.mes.Show(PointToClient(Cursor.Position).ToString());
            //  graphics.ScaleTransform(2, 2);
            MessageBoxs.mes.Show(graphics.PageUnit.ToString());
            graphics.DrawString(s, arialFont, Brushes.Red, c);
            graphics.DrawString("hello", new Font("arial", 70, FontStyle.Regular), Brushes.Brown, new Point(1000, 2000));

            pictureBox1.Image = bitmap; 
            pictureBox1.Refresh();
            */
           // MessageBoxs.mes.Show(PointToClient(Cursor.Position).ToString());
        }

        private void Images_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            printDialog1.Document = printDocument1;
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pictureBox1.Image,0,0, pictureBox1.Image.Width,pictureBox1.Image.Height);
           
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();

        }
    }
}
