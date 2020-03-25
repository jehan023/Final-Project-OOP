namespace BiliPC
{
    partial class Products
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
            this.dgdProduct = new System.Windows.Forms.DataGridView();
            this.GroupTextBox = new System.Windows.Forms.GroupBox();
            this.radInStockFalse = new System.Windows.Forms.RadioButton();
            this.radInStockTrue = new System.Windows.Forms.RadioButton();
            this.idBox = new System.Windows.Forms.TextBox();
            this.lblItemID = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblInStock = new System.Windows.Forms.Label();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.lblSearchItem = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtSearchItem = new System.Windows.Forms.TextBox();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.lblProducts = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRefreshItem = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.CategoryBox = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.searchItemBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgdProduct)).BeginInit();
            this.GroupTextBox.SuspendLayout();
            this.pnlBackground.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgdProduct
            // 
            this.dgdProduct.AllowUserToAddRows = false;
            this.dgdProduct.AllowUserToDeleteRows = false;
            this.dgdProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgdProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdProduct.Location = new System.Drawing.Point(25, 16);
            this.dgdProduct.Margin = new System.Windows.Forms.Padding(2);
            this.dgdProduct.MultiSelect = false;
            this.dgdProduct.Name = "dgdProduct";
            this.dgdProduct.ReadOnly = true;
            this.dgdProduct.RowHeadersWidth = 51;
            this.dgdProduct.RowTemplate.Height = 24;
            this.dgdProduct.Size = new System.Drawing.Size(897, 337);
            this.dgdProduct.TabIndex = 23;
            this.dgdProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgdProduct_CellClick);
            // 
            // GroupTextBox
            // 
            this.GroupTextBox.BackColor = System.Drawing.Color.MistyRose;
            this.GroupTextBox.Controls.Add(this.radInStockFalse);
            this.GroupTextBox.Controls.Add(this.radInStockTrue);
            this.GroupTextBox.Controls.Add(this.idBox);
            this.GroupTextBox.Controls.Add(this.lblItemID);
            this.GroupTextBox.Controls.Add(this.txtCategory);
            this.GroupTextBox.Controls.Add(this.label10);
            this.GroupTextBox.Controls.Add(this.lblUnitPrice);
            this.GroupTextBox.Controls.Add(this.lblInStock);
            this.GroupTextBox.Controls.Add(this.txtSupplier);
            this.GroupTextBox.Controls.Add(this.lblSupplier);
            this.GroupTextBox.Controls.Add(this.txtCost);
            this.GroupTextBox.Controls.Add(this.lblCost);
            this.GroupTextBox.Controls.Add(this.txtUnitPrice);
            this.GroupTextBox.Controls.Add(this.txtQuantity);
            this.GroupTextBox.Controls.Add(this.lblQuantity);
            this.GroupTextBox.Controls.Add(this.txtItemName);
            this.GroupTextBox.Controls.Add(this.lblItemName);
            this.GroupTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupTextBox.Location = new System.Drawing.Point(0, 356);
            this.GroupTextBox.Name = "GroupTextBox";
            this.GroupTextBox.Size = new System.Drawing.Size(945, 183);
            this.GroupTextBox.TabIndex = 45;
            this.GroupTextBox.TabStop = false;
            // 
            // radInStockFalse
            // 
            this.radInStockFalse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radInStockFalse.AutoCheck = false;
            this.radInStockFalse.AutoSize = true;
            this.radInStockFalse.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.radInStockFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radInStockFalse.Location = new System.Drawing.Point(586, 144);
            this.radInStockFalse.Margin = new System.Windows.Forms.Padding(2);
            this.radInStockFalse.Name = "radInStockFalse";
            this.radInStockFalse.Size = new System.Drawing.Size(169, 28);
            this.radInStockFalse.TabIndex = 62;
            this.radInStockFalse.TabStop = true;
            this.radInStockFalse.Text = "OUT OF STOCK";
            this.radInStockFalse.UseVisualStyleBackColor = true;
            // 
            // radInStockTrue
            // 
            this.radInStockTrue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radInStockTrue.AutoCheck = false;
            this.radInStockTrue.AutoSize = true;
            this.radInStockTrue.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.radInStockTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radInStockTrue.Location = new System.Drawing.Point(586, 116);
            this.radInStockTrue.Margin = new System.Windows.Forms.Padding(2);
            this.radInStockTrue.Name = "radInStockTrue";
            this.radInStockTrue.Size = new System.Drawing.Size(115, 28);
            this.radInStockTrue.TabIndex = 61;
            this.radInStockTrue.TabStop = true;
            this.radInStockTrue.Text = "IN STOCK";
            this.radInStockTrue.UseVisualStyleBackColor = true;
            // 
            // idBox
            // 
            this.idBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBox.Location = new System.Drawing.Point(128, 16);
            this.idBox.Margin = new System.Windows.Forms.Padding(2);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(336, 24);
            this.idBox.TabIndex = 60;
            // 
            // lblItemID
            // 
            this.lblItemID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblItemID.AutoSize = true;
            this.lblItemID.BackColor = System.Drawing.Color.Transparent;
            this.lblItemID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemID.ForeColor = System.Drawing.Color.Black;
            this.lblItemID.Location = new System.Drawing.Point(45, 19);
            this.lblItemID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(69, 18);
            this.lblItemID.TabIndex = 59;
            this.lblItemID.Text = "Item ID:";
            // 
            // txtCategory
            // 
            this.txtCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.Location = new System.Drawing.Point(586, 86);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(336, 24);
            this.txtCategory.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(477, 89);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 18);
            this.label10.TabIndex = 57;
            this.label10.Text = "Category :";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblUnitPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.ForeColor = System.Drawing.Color.Black;
            this.lblUnitPrice.Location = new System.Drawing.Point(19, 140);
            this.lblUnitPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(95, 18);
            this.lblUnitPrice.TabIndex = 56;
            this.lblUnitPrice.Text = "Unit Price :";
            // 
            // lblInStock
            // 
            this.lblInStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInStock.AutoSize = true;
            this.lblInStock.BackColor = System.Drawing.Color.Transparent;
            this.lblInStock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInStock.ForeColor = System.Drawing.Color.Black;
            this.lblInStock.Location = new System.Drawing.Point(499, 122);
            this.lblInStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInStock.Name = "lblInStock";
            this.lblInStock.Size = new System.Drawing.Size(69, 18);
            this.lblInStock.TabIndex = 54;
            this.lblInStock.Text = "Status :";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplier.Location = new System.Drawing.Point(586, 52);
            this.txtSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(336, 24);
            this.txtSupplier.TabIndex = 53;
            // 
            // lblSupplier
            // 
            this.lblSupplier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.BackColor = System.Drawing.Color.Transparent;
            this.lblSupplier.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.ForeColor = System.Drawing.Color.Black;
            this.lblSupplier.Location = new System.Drawing.Point(485, 55);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(83, 18);
            this.lblSupplier.TabIndex = 52;
            this.lblSupplier.Text = "Supplier :";
            // 
            // txtCost
            // 
            this.txtCost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(586, 16);
            this.txtCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(336, 24);
            this.txtCost.TabIndex = 51;
            this.txtCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CostBox_KeyPress);
            // 
            // lblCost
            // 
            this.lblCost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCost.AutoSize = true;
            this.lblCost.BackColor = System.Drawing.Color.Transparent;
            this.lblCost.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.ForeColor = System.Drawing.Color.Black;
            this.lblCost.Location = new System.Drawing.Point(514, 19);
            this.lblCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(54, 18);
            this.lblCost.TabIndex = 50;
            this.lblCost.Text = "Cost :";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Location = new System.Drawing.Point(128, 140);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(336, 24);
            this.txtUnitPrice.TabIndex = 49;
            this.txtUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CostBox_KeyPress);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(128, 103);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(336, 24);
            this.txtQuantity.TabIndex = 48;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CostBox_KeyPress);
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.Black;
            this.lblQuantity.Location = new System.Drawing.Point(29, 106);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(85, 18);
            this.lblQuantity.TabIndex = 47;
            this.lblQuantity.Text = "Quantity :";
            // 
            // txtItemName
            // 
            this.txtItemName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(128, 51);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(2);
            this.txtItemName.Multiline = true;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtItemName.Size = new System.Drawing.Size(336, 38);
            this.txtItemName.TabIndex = 46;
            // 
            // lblItemName
            // 
            this.lblItemName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblItemName.AutoSize = true;
            this.lblItemName.BackColor = System.Drawing.Color.Transparent;
            this.lblItemName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.Color.Black;
            this.lblItemName.Location = new System.Drawing.Point(62, 54);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(52, 18);
            this.lblItemName.TabIndex = 45;
            this.lblItemName.Text = "Item :";
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.MistyRose;
            this.pnlBackground.Controls.Add(this.GroupTextBox);
            this.pnlBackground.Controls.Add(this.dgdProduct);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Location = new System.Drawing.Point(0, 100);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(945, 539);
            this.pnlBackground.TabIndex = 1;
            // 
            // lblSearchItem
            // 
            this.lblSearchItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchItem.AutoSize = true;
            this.lblSearchItem.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchItem.ForeColor = System.Drawing.Color.White;
            this.lblSearchItem.Location = new System.Drawing.Point(536, 65);
            this.lblSearchItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchItem.Name = "lblSearchItem";
            this.lblSearchItem.Size = new System.Drawing.Size(109, 18);
            this.lblSearchItem.TabIndex = 33;
            this.lblSearchItem.Text = "Search item:";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddItem.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAddItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Location = new System.Drawing.Point(138, 54);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(109, 31);
            this.btnAddItem.TabIndex = 36;
            this.btnAddItem.Text = "Add item";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
            // 
            // txtSearchItem
            // 
            this.txtSearchItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtSearchItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchItem.Location = new System.Drawing.Point(655, 62);
            this.txtSearchItem.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchItem.Name = "txtSearchItem";
            this.txtSearchItem.Size = new System.Drawing.Size(193, 24);
            this.txtSearchItem.TabIndex = 32;
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdateItem.BackColor = System.Drawing.Color.SpringGreen;
            this.btnUpdateItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdateItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnUpdateItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateItem.Location = new System.Drawing.Point(251, 54);
            this.btnUpdateItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(109, 31);
            this.btnUpdateItem.TabIndex = 37;
            this.btnUpdateItem.Text = "Update item";
            this.btnUpdateItem.UseVisualStyleBackColor = false;
            this.btnUpdateItem.Click += new System.EventHandler(this.BtnUpdateItem_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteItem.BackColor = System.Drawing.Color.SpringGreen;
            this.btnDeleteItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeleteItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteItem.Location = new System.Drawing.Point(364, 54);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(109, 31);
            this.btnDeleteItem.TabIndex = 35;
            this.btnDeleteItem.Text = "Delete item";
            this.btnDeleteItem.UseVisualStyleBackColor = false;
            this.btnDeleteItem.Click += new System.EventHandler(this.BtnDeleteItem_Click);
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
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.ForeColor = System.Drawing.Color.White;
            this.lblProducts.Location = new System.Drawing.Point(18, 9);
            this.lblProducts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(157, 37);
            this.lblProducts.TabIndex = 1;
            this.lblProducts.Text = "Products";
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
            // btnRefreshItem
            // 
            this.btnRefreshItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefreshItem.BackColor = System.Drawing.Color.SpringGreen;
            this.btnRefreshItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRefreshItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRefreshItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshItem.Location = new System.Drawing.Point(25, 54);
            this.btnRefreshItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefreshItem.Name = "btnRefreshItem";
            this.btnRefreshItem.Size = new System.Drawing.Size(109, 31);
            this.btnRefreshItem.TabIndex = 38;
            this.btnRefreshItem.Text = "Refresh";
            this.btnRefreshItem.UseVisualStyleBackColor = false;
            this.btnRefreshItem.Click += new System.EventHandler(this.BtnRefreshItem_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Firebrick;
            this.pnlTop.Controls.Add(this.CategoryBox);
            this.pnlTop.Controls.Add(this.lblCategory);
            this.pnlTop.Controls.Add(this.searchItemBtn);
            this.pnlTop.Controls.Add(this.btnRefreshItem);
            this.pnlTop.Controls.Add(this.label5);
            this.pnlTop.Controls.Add(this.lblProducts);
            this.pnlTop.Controls.Add(this.btnX);
            this.pnlTop.Controls.Add(this.btnDeleteItem);
            this.pnlTop.Controls.Add(this.btnUpdateItem);
            this.pnlTop.Controls.Add(this.txtSearchItem);
            this.pnlTop.Controls.Add(this.btnAddItem);
            this.pnlTop.Controls.Add(this.lblSearchItem);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(945, 100);
            this.pnlTop.TabIndex = 0;
            // 
            // CategoryBox
            // 
            this.CategoryBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CategoryBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CategoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryBox.FormattingEnabled = true;
            this.CategoryBox.Location = new System.Drawing.Point(655, 30);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(193, 26);
            this.CategoryBox.TabIndex = 40;
            this.CategoryBox.SelectedIndexChanged += new System.EventHandler(this.CategoryBox_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(558, 33);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(87, 18);
            this.lblCategory.TabIndex = 39;
            this.lblCategory.Text = "Category:";
            // 
            // searchItemBtn
            // 
            this.searchItemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchItemBtn.BackColor = System.Drawing.Color.IndianRed;
            this.searchItemBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.searchItemBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.searchItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchItemBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchItemBtn.Location = new System.Drawing.Point(849, 62);
            this.searchItemBtn.Name = "searchItemBtn";
            this.searchItemBtn.Size = new System.Drawing.Size(75, 25);
            this.searchItemBtn.TabIndex = 0;
            this.searchItemBtn.Text = "Search";
            this.searchItemBtn.UseVisualStyleBackColor = false;
            this.searchItemBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // Products
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(945, 639);
            this.Controls.Add(this.pnlBackground);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(945, 639);
            this.Name = "Products";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.dgdProduct)).EndInit();
            this.GroupTextBox.ResumeLayout(false);
            this.GroupTextBox.PerformLayout();
            this.pnlBackground.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgdProduct;
        private System.Windows.Forms.GroupBox GroupTextBox;
        private System.Windows.Forms.RadioButton radInStockFalse;
        private System.Windows.Forms.RadioButton radInStockTrue;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblInStock;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Label lblSearchItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox txtSearchItem;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRefreshItem;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button searchItemBtn;
        private System.Windows.Forms.ComboBox CategoryBox;
        private System.Windows.Forms.Label lblCategory;
    }
}