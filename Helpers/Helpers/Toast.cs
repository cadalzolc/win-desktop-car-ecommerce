using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public class Toast
    {

        #region " Message " 

        public static void Message(string Mesage)
        {
            MessageBox.Show(Mesage, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region " Required "

        public static void Required(string Mesage)
        {
            MessageBox.Show(Mesage, "Required Feilds", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Required(string Mesage, Control Ctl)
        {
            MessageBox.Show(Mesage, "Required Feilds", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Ctl.Focus();
        }

        #endregion

        #region " Error "

        public static void Error(string Mesage)
        {
            MessageBox.Show(Mesage, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        #region " Question " 

        public static DialogResult Question(string Mesage)
        {
            return MessageBox.Show(Mesage, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        #endregion

    }
}
