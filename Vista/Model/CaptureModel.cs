using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Vista.Model
{
    class CaptureModel
    {

        public static String guessText(Control control)
        {
            Bitmap bitmap = CaptureModel.take(control);

            String result = ImagenModel.ImageFromText(bitmap);
            bool isOnlyNumber = CaptureModel.isOnlyDigit(result);
            if (!isOnlyNumber)
            {
                result = "0";
            }
            return result;
        }

        private static bool isOnlyDigit(String str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        private static Bitmap take(Control control)
        {
            Size size = control.ClientSize;
            Bitmap bitmap = new Bitmap(size.Width, size.Height);
            CaptureModel.castGraphic(size, bitmap, control);
            return bitmap;
        }
        private static void castGraphic(Size size, Bitmap bitmap, Control control)
        {
            Graphics g = Graphics.FromImage(bitmap);
            g.CopyFromScreen(control.PointToScreen(new Point(0, 0)), new Point(0, 0), new Size(size.Width, size.Height));
        }
    }
}
