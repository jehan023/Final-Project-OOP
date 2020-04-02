namespace BiliPC
{
    using System;
    using System.Windows.Forms;

    public partial class InventoryReport : Form
    {
        public InventoryReport()
        {
            this.InitializeComponent();
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
