using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawPosition
{
    public partial class Form1 : Form
    {
        Image OriginalImage;
        public Form1()
        {
            InitializeComponent();
        }



        public void openImage(string path){


            pcBox.Image = Image.FromFile(path);
            pcBoxOverView.Image = pcBox.Image;
            OriginalImage = pcBox.Image;

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

        private void pcBox_MouseUp(object sender, MouseEventArgs e)
        {
                        this.Cursor = new Cursor(Cursor.Current.Handle);
            int X2 = this.PointToClient(new Point(Cursor.Position.X, Cursor.Position.Y)).X;
            int Y2 = this.PointToClient(new Point(Cursor.Position.X, Cursor.Position.Y)).Y;
            int xCoordinate = Cursor.Position.X;
            int yCoordinate = Cursor.Position.Y;
            textBox1.Text = String.Format("{0}  -   {1}", e.X, e.Y);
        }



    }
}
