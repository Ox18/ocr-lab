using System;
using System.Windows.Forms;

namespace Vista.Controller
{
    public class CaptureController
    {
        public static String guessText(Control control)
        {
            return Model.CaptureModel.guessText(control);
        }
    }
}
