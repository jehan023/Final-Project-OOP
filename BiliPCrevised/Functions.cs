using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiliPC
{
    public static class Functions
    {
        public static int CheckFields(Control GroupTextBox)
        {
            int EmptyField = 0;
            try
            {
                foreach (Control control in GroupTextBox.Controls)
                {
                    string controlType = control.GetType().ToString();
                    if (controlType == "System.Windows.Forms.TextBox")
                    {
                        TextBox txtBox = (TextBox)control;
                        if (string.IsNullOrEmpty(txtBox.Text))
                        {
                            EmptyField += 1;
                        }
                    }
                }
                return EmptyField;
            }
            catch (ArgumentNullException)
            {
                return 0;
            }
        }

        public static bool RestrictedKeyPressToInt(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            // ch 8 = backspace, ch 46 = del key
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                return e.Handled = true;
            }
            else
            {
                return e.Handled = false;
            }
            
        }
    }
}
