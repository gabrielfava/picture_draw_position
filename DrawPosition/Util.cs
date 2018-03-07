using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawPosition
{
    class Util
    {



        public static Image Zoom (Image img, Size size){
            Bitmap bmp = new Bitmap(img, img.Width+(img.Width*size.Width/100),img.Height + (img.Height*size.Height/100));
            Graphics g = Graphics.FromImage(bmp);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bmp;
        
        }

    }
}
