namespace BiliPC
{
    using System;
    using System.Windows.Forms;
    using MongoDB.Bson;

    public partial class TrackEmployees : Form
    {
        private readonly MongoCRUD db = new MongoCRUD("POS_Database");

        public TrackEmployees()
        {
            this.InitializeComponent();
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TrackEmployees_Load(object sender, EventArgs e)
        {
            this.RefreshDefault();
        }

        private void BtnShowAll_Click(object sender, EventArgs e)
        {
            this.RefreshDefault();
        }

        private void RefreshDefault()
        {
            this.cboAcctId.Text = string.Empty;
            var trackRecord = this.db.LoadRecords<TrackEmployeesModel>("TrackEmployees");
            this.dgdTrackEmployees.DataSource = trackRecord;
            foreach (var user in trackRecord)
            {
                if (!this.cboAcctId.Items.Contains(user.AcctId))
                {
                    this.cboAcctId.Items.Add(user.AcctId);
                }
            }
        }

        private void CboAcctId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ObjectId.TryParse(this.cboAcctId.Text, out ObjectId id))
            {
                var selectedRecord = this.db.LoadRecordsByGenericList<TrackEmployeesModel, ObjectId>("TrackEmployees", "AcctId", id);
                this.dgdTrackEmployees.DataSource = selectedRecord;
            }
        }
    }
}
