namespace BiliPC
{
    using System;
    using System.Windows.Forms;

    public partial class TransactionForm : Form
    {
        public TransactionForm()
        {
            this.InitializeComponent();
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
        }
    }
}
