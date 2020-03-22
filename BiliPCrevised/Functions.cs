using System;
using System.Windows.Forms;

namespace BiliPC
{
    public static class Functions
    {
        public static int CheckFields(Control GroupTextBox)
        {
            if (GroupTextBox == null)
            {
                throw new ArgumentNullException(nameof(GroupTextBox));
            }
            int EmptyField = 0;
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

        public static bool RestrictedKeyPressToInt(KeyPressEventArgs e)
        {
            if (e == null)
            {
                throw new ArgumentNullException(nameof(e));
            }
            
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
