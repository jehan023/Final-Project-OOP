namespace BiliPC
{
    partial class TransactionForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnX = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.itemDropDown = new System.Windows.Forms.ComboBox();
            this.transacationIdBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.changeBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.amountReceivedBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addDiscountBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.printReceiptBtn = new System.Windows.Forms.Button();
            this.unitPriceBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalPriceBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.removeItemBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.totalUnitPriceBox = new System.Windows.Forms.TextBox();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.btnX);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 56);
            this.panel1.TabIndex = 0;
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
            this.btnX.Location = new System.Drawing.Point(920, 0);
            this.btnX.Margin = new System.Windows.Forms.Padding(2);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(25, 27);
            this.btnX.TabIndex = 1;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Transaction";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.itemDropDown);
            this.panel2.Controls.Add(this.transacationIdBox);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.addDiscountBtn);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.printReceiptBtn);
            this.panel2.Controls.Add(this.unitPriceBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.addItemBtn);
            this.panel2.Controls.Add(this.removeItemBtn);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.totalUnitPriceBox);
            this.panel2.Controls.Add(this.quantityBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 583);
            this.panel2.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(500, 31);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 24);
            this.label10.TabIndex = 60;
            this.label10.Text = "Category :";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(599, 31);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(192, 28);
            this.comboBox2.TabIndex = 59;
            // 
            // itemDropDown
            // 
            this.itemDropDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.itemDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemDropDown.FormattingEnabled = true;
            this.itemDropDown.Location = new System.Drawing.Point(78, 31);
            this.itemDropDown.Margin = new System.Windows.Forms.Padding(2);
            this.itemDropDown.Name = "itemDropDown";
            this.itemDropDown.Size = new System.Drawing.Size(372, 28);
            this.itemDropDown.TabIndex = 58;
            // 
            // transacationIdBox
            // 
            this.transacationIdBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.transacationIdBox.BackColor = System.Drawing.Color.DarkGray;
            this.transacationIdBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transacationIdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transacationIdBox.Location = new System.Drawing.Point(158, 6);
            this.transacationIdBox.Margin = new System.Windows.Forms.Padding(2);
            this.transacationIdBox.Name = "transacationIdBox";
            this.transacationIdBox.ReadOnly = true;
            this.transacationIdBox.Size = new System.Drawing.Size(633, 19);
            this.transacationIdBox.TabIndex = 57;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.changeBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.amountReceivedBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(15, 414);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 158);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            // 
            // changeBox
            // 
            this.changeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.changeBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.changeBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBox.Location = new System.Drawing.Point(27, 111);
            this.changeBox.Margin = new System.Windows.Forms.Padding(2);
            this.changeBox.Name = "changeBox";
            this.changeBox.ReadOnly = true;
            this.changeBox.Size = new System.Drawing.Size(312, 39);
            this.changeBox.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(23, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 24);
            this.label7.TabIndex = 56;
            this.label7.Text = "Change";
            // 
            // amountReceivedBox
            // 
            this.amountReceivedBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.amountReceivedBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.amountReceivedBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountReceivedBox.Location = new System.Drawing.Point(27, 36);
            this.amountReceivedBox.Margin = new System.Windows.Forms.Padding(2);
            this.amountReceivedBox.Name = "amountReceivedBox";
            this.amountReceivedBox.Size = new System.Drawing.Size(312, 39);
            this.amountReceivedBox.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(23, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 24);
            this.label6.TabIndex = 54;
            this.label6.Text = "Amount Received";
            // 
            // addDiscountBtn
            // 
            this.addDiscountBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addDiscountBtn.BackColor = System.Drawing.Color.Tan;
            this.addDiscountBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addDiscountBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.addDiscountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDiscountBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDiscountBtn.Location = new System.Drawing.Point(618, 525);
            this.addDiscountBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addDiscountBtn.Name = "addDiscountBtn";
            this.addDiscountBtn.Size = new System.Drawing.Size(132, 45);
            this.addDiscountBtn.TabIndex = 53;
            this.addDiscountBtn.Text = "ADD DISCOUNT";
            this.addDiscountBtn.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(11, 5);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 24);
            this.label8.TabIndex = 56;
            this.label8.Text = "Transaction ID: ";
            // 
            // printReceiptBtn
            // 
            this.printReceiptBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.printReceiptBtn.BackColor = System.Drawing.Color.LightCoral;
            this.printReceiptBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.printReceiptBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.printReceiptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printReceiptBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printReceiptBtn.Location = new System.Drawing.Point(774, 524);
            this.printReceiptBtn.Margin = new System.Windows.Forms.Padding(2);
            this.printReceiptBtn.Name = "printReceiptBtn";
            this.printReceiptBtn.Size = new System.Drawing.Size(132, 45);
            this.printReceiptBtn.TabIndex = 52;
            this.printReceiptBtn.Text = "PRINT RECEIPT";
            this.printReceiptBtn.UseVisualStyleBackColor = false;
            // 
            // unitPriceBox
            // 
            this.unitPriceBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unitPriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPriceBox.Location = new System.Drawing.Point(279, 70);
            this.unitPriceBox.Margin = new System.Windows.Forms.Padding(2);
            this.unitPriceBox.Name = "unitPriceBox";
            this.unitPriceBox.ReadOnly = true;
            this.unitPriceBox.Size = new System.Drawing.Size(171, 26);
            this.unitPriceBox.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(164, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 50;
            this.label3.Text = "Unit Price :";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.totalPriceBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(417, 414);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 98);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            // 
            // totalPriceBox
            // 
            this.totalPriceBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalPriceBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.totalPriceBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceBox.Location = new System.Drawing.Point(19, 39);
            this.totalPriceBox.Margin = new System.Windows.Forms.Padding(2);
            this.totalPriceBox.Name = "totalPriceBox";
            this.totalPriceBox.ReadOnly = true;
            this.totalPriceBox.Size = new System.Drawing.Size(466, 45);
            this.totalPriceBox.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(15, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 54;
            this.label5.Text = "Total Price";
            // 
            // addItemBtn
            // 
            this.addItemBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addItemBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.addItemBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addItemBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.addItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addItemBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemBtn.Location = new System.Drawing.Point(810, 54);
            this.addItemBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(109, 41);
            this.addItemBtn.TabIndex = 48;
            this.addItemBtn.Text = "ADD";
            this.addItemBtn.UseVisualStyleBackColor = false;
            // 
            // removeItemBtn
            // 
            this.removeItemBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.removeItemBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.removeItemBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.removeItemBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.removeItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeItemBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeItemBtn.Location = new System.Drawing.Point(810, 6);
            this.removeItemBtn.Margin = new System.Windows.Forms.Padding(2);
            this.removeItemBtn.Name = "removeItemBtn";
            this.removeItemBtn.Size = new System.Drawing.Size(109, 41);
            this.removeItemBtn.TabIndex = 47;
            this.removeItemBtn.Text = "REMOVE";
            this.removeItemBtn.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(454, 69);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 24);
            this.label9.TabIndex = 46;
            this.label9.Text = "Total Unit Price:";
            // 
            // totalUnitPriceBox
            // 
            this.totalUnitPriceBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalUnitPriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalUnitPriceBox.Location = new System.Drawing.Point(599, 66);
            this.totalUnitPriceBox.Margin = new System.Windows.Forms.Padding(2);
            this.totalUnitPriceBox.Name = "totalUnitPriceBox";
            this.totalUnitPriceBox.ReadOnly = true;
            this.totalUnitPriceBox.Size = new System.Drawing.Size(192, 26);
            this.totalUnitPriceBox.TabIndex = 45;
            // 
            // quantityBox
            // 
            this.quantityBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quantityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityBox.Location = new System.Drawing.Point(78, 69);
            this.quantityBox.Margin = new System.Windows.Forms.Padding(2);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(64, 26);
            this.quantityBox.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(23, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 43;
            this.label4.Text = "Qty :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 41;
            this.label2.Text = "Item :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(904, 301);
            this.dataGridView1.TabIndex = 0;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(945, 639);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(945, 639);
            this.Name = "TransactionForm";
            this.Text = "TransactionForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox totalUnitPriceBox;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox unitPriceBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.Button removeItemBtn;
        private System.Windows.Forms.Button addDiscountBtn;
        private System.Windows.Forms.Button printReceiptBtn;
        private System.Windows.Forms.TextBox totalPriceBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox changeBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox amountReceivedBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox transacationIdBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox itemDropDown;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label10;
    }
}