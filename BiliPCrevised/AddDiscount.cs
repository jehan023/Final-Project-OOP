namespace BiliPC
{
    using System;
    using System.Globalization;
    using System.Windows.Forms;

    public partial class AddDiscount : Form
    {
        public AddDiscount()
        {
            this.InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
