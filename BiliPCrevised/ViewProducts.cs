namespace BiliPC
{
    using System;
    using System.Windows.Forms;

    public partial class ViewProducts : Form
    {
        public ViewProducts()
        {
            this.InitializeComponent();
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
