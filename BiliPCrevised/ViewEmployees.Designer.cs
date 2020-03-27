namespace BiliPC
{
    partial class ViewEmployees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.txtSearchEmployee = new System.Windows.Forms.TextBox();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.lblSearchEmployee = new System.Windows.Forms.Label();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.GroupTextBox = new System.Windows.Forms.GroupBox();
            this.txtAcctID = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.radAdminFalse = new System.Windows.Forms.RadioButton();
            this.radAdminTrue = new System.Windows.Forms.RadioButton();
            this.lblWage = new System.Windows.Forms.Label();
            this.lblAccType = new System.Windows.Forms.Label();
            this.txtAcctPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtAcctUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtAcctWorkhours = new System.Windows.Forms.TextBox();
            this.txtAcctWage = new System.Windows.Forms.TextBox();
            this.lblWorkhours = new System.Windows.Forms.Label();
            this.txtAcctName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.dgdEmployee = new System.Windows.Forms.DataGridView();
            this.pnlTop.SuspendLayout();
            this.pnlBackground.SuspendLayout();
            this.GroupTextBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlTop.Controls.Add(this.btnSearchEmployee);
            this.pnlTop.Controls.Add(this.btnRefresh);
            this.pnlTop.Controls.Add(this.label5);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.btnX);
            this.pnlTop.Controls.Add(this.btnDeleteAccount);
            this.pnlTop.Controls.Add(this.btnUpdateAccount);
            this.pnlTop.Controls.Add(this.txtSearchEmployee);
            this.pnlTop.Controls.Add(this.btnAddAccount);
            this.pnlTop.Controls.Add(this.lblSearchEmployee);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(945, 100);
            this.pnlTop.TabIndex = 1;
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchEmployee.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearchEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearchEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchEmployee.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearchEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSearchEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEmployee.ForeColor = System.Drawing.Color.White;
            this.btnSearchEmployee.Location = new System.Drawing.Point(847, 56);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(75, 25);
            this.btnSearchEmployee.TabIndex = 39;
            this.btnSearchEmployee.Text = "Search";
            this.btnSearchEmployee.UseVisualStyleBackColor = false;
            this.btnSearchEmployee.Click += new System.EventHandler(this.BtnSearchEmployee_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.BackColor = System.Drawing.Color.SpringGreen;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(25, 54);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(109, 31);
            this.btnRefresh.TabIndex = 35;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(74, -50);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employees";
            // 
            // btnX
            // 
            this.btnX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnX.BackColor = System.Drawing.Color.IndianRed;
            this.btnX.FlatAppearance.BorderSize = 0;
            this.btnX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.Color.Black;
            this.btnX.Location = new System.Drawing.Point(921, 0);
            this.btnX.Margin = new System.Windows.Forms.Padding(2);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(25, 27);
            this.btnX.TabIndex = 0;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.BtnX_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteAccount.BackColor = System.Drawing.Color.SpringGreen;
            this.btnDeleteAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeleteAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAccount.Location = new System.Drawing.Point(364, 54);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(109, 31);
            this.btnDeleteAccount.TabIndex = 38;
            this.btnDeleteAccount.Text = "Delete";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.BtnDeleteAccount_Click);
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdateAccount.BackColor = System.Drawing.Color.SpringGreen;
            this.btnUpdateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdateAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnUpdateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAccount.Location = new System.Drawing.Point(251, 54);
            this.btnUpdateAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(109, 31);
            this.btnUpdateAccount.TabIndex = 37;
            this.btnUpdateAccount.Text = "Update";
            this.btnUpdateAccount.UseVisualStyleBackColor = false;
            this.btnUpdateAccount.Click += new System.EventHandler(this.BtnUpdateAccount_Click);
            // 
            // txtSearchEmployee
            // 
            this.txtSearchEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchEmployee.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtSearchEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchEmployee.Location = new System.Drawing.Point(658, 57);
            this.txtSearchEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.Size = new System.Drawing.Size(186, 24);
            this.txtSearchEmployee.TabIndex = 40;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddAccount.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAddAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAccount.Location = new System.Drawing.Point(138, 54);
            this.btnAddAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(109, 31);
            this.btnAddAccount.TabIndex = 36;
            this.btnAddAccount.Text = "Add new";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.BtnAddAccount_Click);
            // 
            // lblSearchEmployee
            // 
            this.lblSearchEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchEmployee.AutoSize = true;
            this.lblSearchEmployee.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchEmployee.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchEmployee.ForeColor = System.Drawing.Color.White;
            this.lblSearchEmployee.Location = new System.Drawing.Point(501, 60);
            this.lblSearchEmployee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchEmployee.Name = "lblSearchEmployee";
            this.lblSearchEmployee.Size = new System.Drawing.Size(153, 18);
            this.lblSearchEmployee.TabIndex = 39;
            this.lblSearchEmployee.Text = "Search Employee:";
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlBackground.Controls.Add(this.GroupTextBox);
            this.pnlBackground.Controls.Add(this.dgdEmployee);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Location = new System.Drawing.Point(0, 100);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(945, 539);
            this.pnlBackground.TabIndex = 41;
            // 
            // GroupTextBox
            // 
            this.GroupTextBox.BackColor = System.Drawing.Color.Transparent;
            this.GroupTextBox.Controls.Add(this.txtAcctID);
            this.GroupTextBox.Controls.Add(this.lblUserID);
            this.GroupTextBox.Controls.Add(this.radAdminFalse);
            this.GroupTextBox.Controls.Add(this.radAdminTrue);
            this.GroupTextBox.Controls.Add(this.lblWage);
            this.GroupTextBox.Controls.Add(this.lblAccType);
            this.GroupTextBox.Controls.Add(this.txtAcctPassword);
            this.GroupTextBox.Controls.Add(this.lblPassword);
            this.GroupTextBox.Controls.Add(this.txtAcctUsername);
            this.GroupTextBox.Controls.Add(this.lblUsername);
            this.GroupTextBox.Controls.Add(this.txtAcctWorkhours);
            this.GroupTextBox.Controls.Add(this.txtAcctWage);
            this.GroupTextBox.Controls.Add(this.lblWorkhours);
            this.GroupTextBox.Controls.Add(this.txtAcctName);
            this.GroupTextBox.Controls.Add(this.lblName);
            this.GroupTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupTextBox.Location = new System.Drawing.Point(0, 353);
            this.GroupTextBox.Name = "GroupTextBox";
            this.GroupTextBox.Size = new System.Drawing.Size(945, 186);
            this.GroupTextBox.TabIndex = 43;
            this.GroupTextBox.TabStop = false;
            // 
            // txtAcctID
            // 
            this.txtAcctID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAcctID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcctID.Location = new System.Drawing.Point(136, 22);
            this.txtAcctID.Margin = new System.Windows.Forms.Padding(2);
            this.txtAcctID.Name = "txtAcctID";
            this.txtAcctID.ReadOnly = true;
            this.txtAcctID.Size = new System.Drawing.Size(336, 28);
            this.txtAcctID.TabIndex = 45;
            // 
            // lblUserID
            // 
            this.lblUserID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserID.AutoSize = true;
            this.lblUserID.BackColor = System.Drawing.Color.Transparent;
            this.lblUserID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.Black;
            this.lblUserID.Location = new System.Drawing.Point(46, 24);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(89, 22);
            this.lblUserID.TabIndex = 44;
            this.lblUserID.Text = "User ID :";
            // 
            // radAdminFalse
            // 
            this.radAdminFalse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radAdminFalse.AutoSize = true;
            this.radAdminFalse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radAdminFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAdminFalse.Location = new System.Drawing.Point(594, 130);
            this.radAdminFalse.Margin = new System.Windows.Forms.Padding(2);
            this.radAdminFalse.Name = "radAdminFalse";
            this.radAdminFalse.Size = new System.Drawing.Size(114, 28);
            this.radAdminFalse.TabIndex = 58;
            this.radAdminFalse.TabStop = true;
            this.radAdminFalse.Text = "Employee";
            this.radAdminFalse.UseVisualStyleBackColor = true;
            // 
            // radAdminTrue
            // 
            this.radAdminTrue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radAdminTrue.AutoSize = true;
            this.radAdminTrue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radAdminTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAdminTrue.Location = new System.Drawing.Point(594, 99);
            this.radAdminTrue.Margin = new System.Windows.Forms.Padding(2);
            this.radAdminTrue.Name = "radAdminTrue";
            this.radAdminTrue.Size = new System.Drawing.Size(83, 28);
            this.radAdminTrue.TabIndex = 57;
            this.radAdminTrue.TabStop = true;
            this.radAdminTrue.Text = "Admin";
            this.radAdminTrue.UseVisualStyleBackColor = true;
            // 
            // lblWage
            // 
            this.lblWage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWage.AutoSize = true;
            this.lblWage.BackColor = System.Drawing.Color.Transparent;
            this.lblWage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWage.ForeColor = System.Drawing.Color.Black;
            this.lblWage.Location = new System.Drawing.Point(62, 104);
            this.lblWage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWage.Name = "lblWage";
            this.lblWage.Size = new System.Drawing.Size(73, 22);
            this.lblWage.TabIndex = 48;
            this.lblWage.Text = "Wage :";
            // 
            // lblAccType
            // 
            this.lblAccType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAccType.AutoSize = true;
            this.lblAccType.BackColor = System.Drawing.Color.Transparent;
            this.lblAccType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccType.ForeColor = System.Drawing.Color.Black;
            this.lblAccType.Location = new System.Drawing.Point(490, 101);
            this.lblAccType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccType.Name = "lblAccType";
            this.lblAccType.Size = new System.Drawing.Size(102, 22);
            this.lblAccType.TabIndex = 56;
            this.lblAccType.Text = "Acc type :";
            // 
            // txtAcctPassword
            // 
            this.txtAcctPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAcctPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcctPassword.Location = new System.Drawing.Point(594, 57);
            this.txtAcctPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtAcctPassword.Name = "txtAcctPassword";
            this.txtAcctPassword.PasswordChar = '*';
            this.txtAcctPassword.Size = new System.Drawing.Size(336, 28);
            this.txtAcctPassword.TabIndex = 55;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(481, 60);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(111, 22);
            this.lblPassword.TabIndex = 54;
            this.lblPassword.Text = "Password :";
            // 
            // txtAcctUsername
            // 
            this.txtAcctUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAcctUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcctUsername.Location = new System.Drawing.Point(594, 22);
            this.txtAcctUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtAcctUsername.Name = "txtAcctUsername";
            this.txtAcctUsername.Size = new System.Drawing.Size(336, 28);
            this.txtAcctUsername.TabIndex = 53;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Black;
            this.lblUsername.Location = new System.Drawing.Point(477, 24);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(114, 22);
            this.lblUsername.TabIndex = 52;
            this.lblUsername.Text = "Username :";
            // 
            // txtAcctWorkhours
            // 
            this.txtAcctWorkhours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAcctWorkhours.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcctWorkhours.Location = new System.Drawing.Point(136, 144);
            this.txtAcctWorkhours.Margin = new System.Windows.Forms.Padding(2);
            this.txtAcctWorkhours.Name = "txtAcctWorkhours";
            this.txtAcctWorkhours.Size = new System.Drawing.Size(336, 28);
            this.txtAcctWorkhours.TabIndex = 51;
            this.txtAcctWorkhours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAcctWage_KeyPress);
            // 
            // txtAcctWage
            // 
            this.txtAcctWage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAcctWage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcctWage.Location = new System.Drawing.Point(136, 101);
            this.txtAcctWage.Margin = new System.Windows.Forms.Padding(2);
            this.txtAcctWage.Name = "txtAcctWage";
            this.txtAcctWage.Size = new System.Drawing.Size(336, 28);
            this.txtAcctWage.TabIndex = 49;
            this.txtAcctWage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAcctWage_KeyPress);
            // 
            // lblWorkhours
            // 
            this.lblWorkhours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWorkhours.AutoSize = true;
            this.lblWorkhours.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkhours.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkhours.ForeColor = System.Drawing.Color.Black;
            this.lblWorkhours.Location = new System.Drawing.Point(23, 147);
            this.lblWorkhours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWorkhours.Name = "lblWorkhours";
            this.lblWorkhours.Size = new System.Drawing.Size(112, 22);
            this.lblWorkhours.TabIndex = 50;
            this.lblWorkhours.Text = "Workhr(s) :";
            // 
            // txtAcctName
            // 
            this.txtAcctName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAcctName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcctName.Location = new System.Drawing.Point(136, 60);
            this.txtAcctName.Margin = new System.Windows.Forms.Padding(2);
            this.txtAcctName.Name = "txtAcctName";
            this.txtAcctName.Size = new System.Drawing.Size(336, 28);
            this.txtAcctName.TabIndex = 47;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(62, 63);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 22);
            this.lblName.TabIndex = 46;
            this.lblName.Text = "Name :";
            // 
            // dgdEmployee
            // 
            this.dgdEmployee.AllowUserToAddRows = false;
            this.dgdEmployee.AllowUserToDeleteRows = false;
            this.dgdEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgdEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdEmployee.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdEmployee.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgdEmployee.Location = new System.Drawing.Point(25, 16);
            this.dgdEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.dgdEmployee.MultiSelect = false;
            this.dgdEmployee.Name = "dgdEmployee";
            this.dgdEmployee.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgdEmployee.RowHeadersWidth = 51;
            this.dgdEmployee.RowTemplate.Height = 24;
            this.dgdEmployee.Size = new System.Drawing.Size(897, 337);
            this.dgdEmployee.TabIndex = 42;
            this.dgdEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgdEmployee_CellClick);
            // 
            // ViewEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 639);
            this.Controls.Add(this.pnlBackground);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(945, 639);
            this.Name = "ViewEmployees";
            this.Text = "ViewEmployees";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBackground.ResumeLayout(false);
            this.GroupTextBox.ResumeLayout(false);
            this.GroupTextBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnUpdateAccount;
        private System.Windows.Forms.TextBox txtSearchEmployee;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Label lblSearchEmployee;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.GroupBox GroupTextBox;
        private System.Windows.Forms.TextBox txtAcctID;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.RadioButton radAdminFalse;
        private System.Windows.Forms.RadioButton radAdminTrue;
        private System.Windows.Forms.Label lblWage;
        private System.Windows.Forms.Label lblAccType;
        private System.Windows.Forms.TextBox txtAcctPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtAcctUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtAcctWorkhours;
        private System.Windows.Forms.TextBox txtAcctWage;
        private System.Windows.Forms.Label lblWorkhours;
        private System.Windows.Forms.TextBox txtAcctName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgdEmployee;
        private System.Windows.Forms.Button btnSearchEmployee;
    }
}