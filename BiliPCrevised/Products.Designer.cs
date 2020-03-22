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
            this.ProductDataGrid = new System.Windows.Forms.DataGridView();
            this.GroupTextBox = new System.Windows.Forms.GroupBox();
            this.inStockFalseRadioBtn = new System.Windows.Forms.RadioButton();
            this.inStockTrueRadioBtn = new System.Windows.Forms.RadioButton();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.supplierBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.costBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.unitPriceBox = new System.Windows.Forms.TextBox();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.itemNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.searchItemBox = new System.Windows.Forms.TextBox();
            this.updateItemBtn = new System.Windows.Forms.Button();
            this.deleteItemBtn = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.refreshItemBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchItemBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGrid)).BeginInit();
            this.GroupTextBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductDataGrid
            // 
            this.ProductDataGrid.AllowUserToAddRows = false;
            this.ProductDataGrid.AllowUserToDeleteRows = false;
            this.ProductDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataGrid.Location = new System.Drawing.Point(25, 14);
            this.ProductDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.ProductDataGrid.Name = "ProductDataGrid";
            this.ProductDataGrid.ReadOnly = true;
            this.ProductDataGrid.RowHeadersWidth = 51;
            this.ProductDataGrid.RowTemplate.Height = 24;
            this.ProductDataGrid.Size = new System.Drawing.Size(897, 337);
            this.ProductDataGrid.TabIndex = 23;
            this.ProductDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDataGrid_CellClick);
            // 
            // GroupTextBox
            // 
            this.GroupTextBox.BackColor = System.Drawing.Color.MistyRose;
            this.GroupTextBox.Controls.Add(this.inStockFalseRadioBtn);
            this.GroupTextBox.Controls.Add(this.inStockTrueRadioBtn);
            this.GroupTextBox.Controls.Add(this.idBox);
            this.GroupTextBox.Controls.Add(this.label11);
            this.GroupTextBox.Controls.Add(this.categoryBox);
            this.GroupTextBox.Controls.Add(this.label10);
            this.GroupTextBox.Controls.Add(this.label9);
            this.GroupTextBox.Controls.Add(this.label8);
            this.GroupTextBox.Controls.Add(this.supplierBox);
            this.GroupTextBox.Controls.Add(this.label7);
            this.GroupTextBox.Controls.Add(this.costBox);
            this.GroupTextBox.Controls.Add(this.label6);
            this.GroupTextBox.Controls.Add(this.unitPriceBox);
            this.GroupTextBox.Controls.Add(this.quantityBox);
            this.GroupTextBox.Controls.Add(this.label4);
            this.GroupTextBox.Controls.Add(this.itemNameBox);
            this.GroupTextBox.Controls.Add(this.label2);
            this.GroupTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupTextBox.Location = new System.Drawing.Point(0, 356);
            this.GroupTextBox.Name = "GroupTextBox";
            this.GroupTextBox.Size = new System.Drawing.Size(945, 183);
            this.GroupTextBox.TabIndex = 45;
            this.GroupTextBox.TabStop = false;
            // 
            // inStockFalseRadioBtn
            // 
            this.inStockFalseRadioBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inStockFalseRadioBtn.AutoCheck = false;
            this.inStockFalseRadioBtn.AutoSize = true;
            this.inStockFalseRadioBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.inStockFalseRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inStockFalseRadioBtn.Location = new System.Drawing.Point(586, 144);
            this.inStockFalseRadioBtn.Margin = new System.Windows.Forms.Padding(2);
            this.inStockFalseRadioBtn.Name = "inStockFalseRadioBtn";
            this.inStockFalseRadioBtn.Size = new System.Drawing.Size(169, 28);
            this.inStockFalseRadioBtn.TabIndex = 62;
            this.inStockFalseRadioBtn.TabStop = true;
            this.inStockFalseRadioBtn.Text = "OUT OF STOCK";
            this.inStockFalseRadioBtn.UseVisualStyleBackColor = true;
            // 
            // inStockTrueRadioBtn
            // 
            this.inStockTrueRadioBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inStockTrueRadioBtn.AutoCheck = false;
            this.inStockTrueRadioBtn.AutoSize = true;
            this.inStockTrueRadioBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.inStockTrueRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inStockTrueRadioBtn.Location = new System.Drawing.Point(586, 116);
            this.inStockTrueRadioBtn.Margin = new System.Windows.Forms.Padding(2);
            this.inStockTrueRadioBtn.Name = "inStockTrueRadioBtn";
            this.inStockTrueRadioBtn.Size = new System.Drawing.Size(115, 28);
            this.inStockTrueRadioBtn.TabIndex = 61;
            this.inStockTrueRadioBtn.TabStop = true;
            this.inStockTrueRadioBtn.Text = "IN STOCK";
            this.inStockTrueRadioBtn.UseVisualStyleBackColor = true;
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
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(45, 19);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 18);
            this.label11.TabIndex = 59;
            this.label11.Text = "Item ID:";
            // 
            // categoryBox
            // 
            this.categoryBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBox.Location = new System.Drawing.Point(586, 86);
            this.categoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(336, 24);
            this.categoryBox.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(477, 92);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 18);
            this.label10.TabIndex = 57;
            this.label10.Text = "Category :";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(19, 140);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 18);
            this.label9.TabIndex = 56;
            this.label9.Text = "Unit Price :";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(499, 122);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 18);
            this.label8.TabIndex = 54;
            this.label8.Text = "Status :";
            // 
            // supplierBox
            // 
            this.supplierBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.supplierBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierBox.Location = new System.Drawing.Point(586, 48);
            this.supplierBox.Margin = new System.Windows.Forms.Padding(2);
            this.supplierBox.Name = "supplierBox";
            this.supplierBox.Size = new System.Drawing.Size(336, 24);
            this.supplierBox.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(485, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 18);
            this.label7.TabIndex = 52;
            this.label7.Text = "Supplier :";
            // 
            // costBox
            // 
            this.costBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.costBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costBox.Location = new System.Drawing.Point(586, 16);
            this.costBox.Margin = new System.Windows.Forms.Padding(2);
            this.costBox.Name = "costBox";
            this.costBox.Size = new System.Drawing.Size(336, 24);
            this.costBox.TabIndex = 51;
            this.costBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CostBox_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(514, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 18);
            this.label6.TabIndex = 50;
            this.label6.Text = "Cost :";
            // 
            // unitPriceBox
            // 
            this.unitPriceBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unitPriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPriceBox.Location = new System.Drawing.Point(128, 140);
            this.unitPriceBox.Margin = new System.Windows.Forms.Padding(2);
            this.unitPriceBox.Name = "unitPriceBox";
            this.unitPriceBox.Size = new System.Drawing.Size(336, 24);
            this.unitPriceBox.TabIndex = 49;
            this.unitPriceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CostBox_KeyPress);
            // 
            // quantityBox
            // 
            this.quantityBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quantityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityBox.Location = new System.Drawing.Point(128, 103);
            this.quantityBox.Margin = new System.Windows.Forms.Padding(2);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(336, 24);
            this.quantityBox.TabIndex = 48;
            this.quantityBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CostBox_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(29, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 47;
            this.label4.Text = "Quantity :";
            // 
            // itemNameBox
            // 
            this.itemNameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.itemNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameBox.Location = new System.Drawing.Point(128, 51);
            this.itemNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.itemNameBox.Multiline = true;
            this.itemNameBox.Name = "itemNameBox";
            this.itemNameBox.Size = new System.Drawing.Size(336, 38);
            this.itemNameBox.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(62, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 45;
            this.label2.Text = "Item :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.GroupTextBox);
            this.panel2.Controls.Add(this.ProductDataGrid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 539);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(541, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Search item:";
            // 
            // addItemBtn
            // 
            this.addItemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addItemBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.addItemBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addItemBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.addItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addItemBtn.Location = new System.Drawing.Point(156, 54);
            this.addItemBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(109, 31);
            this.addItemBtn.TabIndex = 36;
            this.addItemBtn.Text = "Add item";
            this.addItemBtn.UseVisualStyleBackColor = false;
            this.addItemBtn.Click += new System.EventHandler(this.AddItemBtn_Click);
            // 
            // searchItemBox
            // 
            this.searchItemBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchItemBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.searchItemBox.Location = new System.Drawing.Point(660, 61);
            this.searchItemBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchItemBox.Name = "searchItemBox";
            this.searchItemBox.Size = new System.Drawing.Size(193, 24);
            this.searchItemBox.TabIndex = 32;
            // 
            // updateItemBtn
            // 
            this.updateItemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateItemBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.updateItemBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.updateItemBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.updateItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateItemBtn.Location = new System.Drawing.Point(280, 54);
            this.updateItemBtn.Margin = new System.Windows.Forms.Padding(2);
            this.updateItemBtn.Name = "updateItemBtn";
            this.updateItemBtn.Size = new System.Drawing.Size(109, 31);
            this.updateItemBtn.TabIndex = 37;
            this.updateItemBtn.Text = "Update item";
            this.updateItemBtn.UseVisualStyleBackColor = false;
            this.updateItemBtn.Click += new System.EventHandler(this.UpdateItemBtn_Click);
            // 
            // deleteItemBtn
            // 
            this.deleteItemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteItemBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.deleteItemBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deleteItemBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.deleteItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteItemBtn.Location = new System.Drawing.Point(404, 54);
            this.deleteItemBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteItemBtn.Name = "deleteItemBtn";
            this.deleteItemBtn.Size = new System.Drawing.Size(109, 31);
            this.deleteItemBtn.TabIndex = 35;
            this.deleteItemBtn.Text = "Delete item";
            this.deleteItemBtn.UseVisualStyleBackColor = false;
            this.deleteItemBtn.Click += new System.EventHandler(this.DeleteItemBtn_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Products";
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
            // refreshItemBtn
            // 
            this.refreshItemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshItemBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.refreshItemBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.refreshItemBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.refreshItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshItemBtn.Location = new System.Drawing.Point(32, 54);
            this.refreshItemBtn.Margin = new System.Windows.Forms.Padding(2);
            this.refreshItemBtn.Name = "refreshItemBtn";
            this.refreshItemBtn.Size = new System.Drawing.Size(109, 31);
            this.refreshItemBtn.TabIndex = 38;
            this.refreshItemBtn.Text = "Refresh";
            this.refreshItemBtn.UseVisualStyleBackColor = false;
            this.refreshItemBtn.Click += new System.EventHandler(this.RefreshItemBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.searchItemBtn);
            this.panel1.Controls.Add(this.refreshItemBtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnX);
            this.panel1.Controls.Add(this.deleteItemBtn);
            this.panel1.Controls.Add(this.updateItemBtn);
            this.panel1.Controls.Add(this.searchItemBox);
            this.panel1.Controls.Add(this.addItemBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 100);
            this.panel1.TabIndex = 0;
            // 
            // searchItemBtn
            // 
            this.searchItemBtn.BackColor = System.Drawing.Color.Firebrick;
            this.searchItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchItemBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchItemBtn.Location = new System.Drawing.Point(849, 61);
            this.searchItemBtn.Name = "searchItemBtn";
            this.searchItemBtn.Size = new System.Drawing.Size(73, 24);
            this.searchItemBtn.TabIndex = 0;
            this.searchItemBtn.Text = "Search";
            this.searchItemBtn.UseVisualStyleBackColor = false;
            this.searchItemBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // Products
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(945, 639);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(945, 639);
            this.Name = "Products";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGrid)).EndInit();
            this.GroupTextBox.ResumeLayout(false);
            this.GroupTextBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductDataGrid;
        private System.Windows.Forms.GroupBox GroupTextBox;
        private System.Windows.Forms.RadioButton inStockFalseRadioBtn;
        private System.Windows.Forms.RadioButton inStockTrueRadioBtn;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox categoryBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox supplierBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox costBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox unitPriceBox;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox itemNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.TextBox searchItemBox;
        private System.Windows.Forms.Button updateItemBtn;
        private System.Windows.Forms.Button deleteItemBtn;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button refreshItemBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button searchItemBtn;
    }
}