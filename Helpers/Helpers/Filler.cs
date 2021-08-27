using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public class Filler
    {
        #region " Load  "

        public static void Load(ComboBox Cbo, DataTable DT, string Display, string Value, int Selected = -1)
        {
            Cbo.DataSource = null;
            Cbo.DataSource = DT;
            Cbo.DisplayMember = Display;
            Cbo.ValueMember = Value;
            Cbo.SelectedIndex = Selected;
        }
        #endregion

    }
}