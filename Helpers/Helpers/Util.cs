using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public class Util
    {

        #region " Controls "

        public static IEnumerable<Widget> Controls(Form Containers)
        {
            var Arr = new List<Widget>();
            foreach (Control Ctl in Containers.Controls)
            {
                switch (Ctl.GetType().Name)
                {
                    case "GroupBox":
                        var ArrGP = Controls(Ctl as GroupBox);
                        Arr.AddRange(ArrGP);
                        break;
                    case "Panel":
                        var ArrPL = Controls(Ctl as Panel);
                        Arr.AddRange(ArrPL);
                        break;
                    case "TextBox":
                    case "ComboBox":
                        Arr.Add(new Widget(Ctl.TabIndex.ToString(), Ctl));
                        break;
                }
            }
            return Arr.OrderBy(r => r.Control_Index);
        }

        public static IEnumerable<Widget> Controls(Control Containers)
        {
            var Arr = new List<Widget>();
            foreach (Control Ctl in Containers.Controls)
            {
                switch (Ctl.GetType().Name)
                {
                    case "GroupBox":
                        var ArrGP = Controls(Ctl as GroupBox);
                        Arr.AddRange(ArrGP);
                        break;
                    case "Panel":
                        var ArrPL = Controls(Ctl as Panel);
                        Arr.AddRange(ArrPL);
                        break;
                    case "TextBox":
                    case "ComboBox":
                        Arr.Add(new Widget(string.Format("{0}{1}", Containers.TabIndex, Ctl.TabIndex), Ctl));
                        break;
                }
            }
            return Arr.OrderBy(r => r.Control_Index);
        }

        #endregion

        #region " Image To Base64 "

        public static string ImageToBase64(Image Img, ImageFormat Format)
        {
            using (var MS = new MemoryStream())
            {
                Img.Save(MS, Format);
                return Convert.ToBase64String(MS.ToArray());
            }
        }

        #endregion

        #region " Base64 To Image "

        public static Image Base64Image(string Base64)
        {
            var Bytes = Convert.FromBase64String(Base64);
            using (var MS = new MemoryStream(Bytes, 0, Bytes.Length))
            {
                MS.Write(Bytes, 0, Bytes.Length);
                return Image.FromStream(MS, true);
            }
        }

        #endregion

    }
}