using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawPosition
{
    public partial class Form1 : Form
    {
        int x_draw_start = 0;
        int y_draw_start = 0;

        int x_draw_end = 0;
        int y_draw_end = 0;

        bool AtDrawing = false;
        Image AtualImage;
        Image OriginalImage;
        public Form1()
        {
            InitializeComponent();
        }



        public void openImage(string path){


            pcBox.Image = Image.FromFile(path);
            pcBoxOverView.Image = pcBox.Image;
            OriginalImage = pcBox.Image;
            AtualImage = pcBox.Image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openImage("C:\\Users\\Gabriel Fava\\Desktop\\GIT\\picture_draw_position\\Images\\pic_1.jpg");
        }

        private void trackZoom_Scroll(object sender, EventArgs e)
        {
           // if (trackZoom.Value > 0)
           // {
            
                pcBox.Image = Util.Zoom(OriginalImage, new Size(trackZoom.Value, trackZoom.Value));
           // }
        }

        private void pcBox_Click(object sender, EventArgs e)
        {

        }



        private void btOpenFolder_Click(object sender, EventArgs e)
        {



            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    DirectoryInfo d = new DirectoryInfo(fbd.SelectedPath);//Assuming Test is your Folder
                    FileInfo[] Files = d.GetFiles(); //Getting Text files
     
                    foreach (FileInfo file in Files)
                    {
                        if (file.Extension.ToUpper() == ".JPG" || file.Extension.ToUpper() == ".TIF")
                            listImages.Items.Add(file.FullName);
                       
                    }
                }
            }


        }

        private void listImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = listImages.GetItemText(listImages.SelectedItem);

            openImage(text);
         
                


           
        }

        private void listImages_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pcBox_MouseDown(object sender, MouseEventArgs e)
        {
            x_draw_start = e.X;
            y_draw_start = e.Y;
            AtDrawing = true;
            textBox1.Text = String.Format("{0}  -   {1}", x_draw_start, y_draw_start);
        }


        private void pcBox_MouseUp(object sender, MouseEventArgs e)
        {
            AtDrawing = false;
            x_draw_end = e.X;
            y_draw_end = e.Y;

            textBox2.Text = String.Format("{0}  -   {1}", x_draw_end, y_draw_end);
        }

        private void pcBox_MouseMove(object sender, MouseEventArgs e)
        {
            x_draw_end = e.X;
            y_draw_end = e.Y;

            textBox2.Text = String.Format("{0}  -   {1}", x_draw_end, y_draw_end);
            Image tempDrawing = AtualImage;
            using (var graphics = Graphics.FromImage(tempDrawing))
            {
                graphics.DrawRectangle(new Pen(Color.Red, 1), new Rectangle(x_draw_start, y_draw_start, x_draw_end - x_draw_start, y_draw_end - y_draw_start));
            }
            pcBox.Image = tempDrawing;
        }

    }
}
