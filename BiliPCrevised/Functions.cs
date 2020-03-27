namespace BiliPC
{
    using System;
    using System.Windows.Forms;

    public static class Functions
    {
        public static int CheckFields(Control groupTextBox)
        {
            if (groupTextBox == null)
            {
                throw new ArgumentNullException(nameof(groupTextBox));
            }

            int emptyField = 0;
            foreach (Control control in groupTextBox.Controls)
            {
                string controlType = control.GetType().ToString();
                if (controlType == "System.Windows.Forms.TextBox")
                {
                    TextBox txtBox = (TextBox)control;
                    if (string.IsNullOrEmpty(txtBox.Text))
                    {
                        emptyField += 1;
                    }
                }
            }

            return emptyField;
        }

        public static bool RestrictedKeyPressToDouble(KeyPressEventArgs e)
        {
            if (e == null)
            {
                throw new ArgumentNullException(nameof(e));
            }

            // ch 8 = backspace
            // ch 46 = decimal point
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                return e.Handled = true;
            }
            else
            {
                return e.Handled = false;
            }
        }

        public static bool RestrictedKeyPressToInt(KeyPressEventArgs e)
        {
            if (e == null)
            {
                throw new ArgumentNullException(nameof(e));
            }

            // ch 8 = backspace
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
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
