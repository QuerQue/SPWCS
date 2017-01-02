using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPWCS
{
    class FormPrepare
    {
        static public Bitmap ConvertToBitmap(string fileName)
        {
            Bitmap bitmap;
            using (System.IO.Stream bmpStream = System.IO.File.Open(fileName, System.IO.FileMode.Open))
            {
                Image image = Image.FromStream(bmpStream);

                bitmap = new Bitmap(image);

            }
            return bitmap;
        }

    }
}
