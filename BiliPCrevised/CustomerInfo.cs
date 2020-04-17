namespace BiliPC
{
    using System;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    public partial class CustomerInfo : Form
    {
        public CustomerInfo()
        {
            this.InitializeComponent();
        }

        public static string CustomerName { get; set; }

        public static string ContactNo { get; set; }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            int emptyField = Functions.CheckFields(this.GroupTextBox);

            if (emptyField > 0)
            {
                // Message box showing unfilled textbox.
                string message = "Please fill all of the " + emptyField + " field/s.";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
            else if (this.TxtContactNumber.TextLength != 11)
            {
                // Message box showing contact number length check.
                string message = "Please check contact number input.";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
            else
            {
                CustomerName = this.TxtCustomerName.Text;
                ContactNo = this.TxtContactNumber.Text;
                this.Close();
            }
        }

        private void TxtContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            Functions.RestrictedKeyPressToInt(e);
        }
    }
}
