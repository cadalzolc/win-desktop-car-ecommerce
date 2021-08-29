using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public class Widget
    {
        public string Control_Index { get; set; } = "";
        public Control Control_Type { get; set; } = new Control();
        public Widget() { }
        public Widget(string Index, Control Ctl)
        {
            Control_Index = Index;
            Control_Type = Ctl;
        }
    }
}
