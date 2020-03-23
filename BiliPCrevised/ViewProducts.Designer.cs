namespace BiliPC
{
    partial class ViewProducts
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
            this.lblSearchItem = new System.Windows.Forms.Label();
            this.txtSearchItem = new System.Windows.Forms.TextBox();
            this.btnX = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnSearchItem = new System.Windows.Forms.Button();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblViewProducts = new System.Windows.Forms.Label();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.dgdViewProducts = new System.Windows.Forms.DataGridView();
            this.pnlTop.SuspendLayout();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchItem
            // 
            this.lblSearchItem.AutoSize = true;
            this.lblSearchItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchItem.ForeColor = System.Drawing.Color.White;
            this.lblSearchItem.Location = new System.Drawing.Point(26, 76);
            this.lblSearchItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchItem.Name = "lblSearchItem";
            this.lblSearchItem.Size = new System.Drawing.Size(126, 22);
            this.lblSearchItem.TabIndex = 15;
            this.lblSearchItem.Text = "Search item:";
            // 
            // txtSearchItem
            // 
            this.txtSearchItem.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearchItem.Location = new System.Drawing.Point(159, 75);
            this.txtSearchItem.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchItem.Name = "txtSearchItem";
            this.txtSearchItem.Size = new System.Drawing.Size(360, 24);
            this.txtSearchItem.TabIndex = 14;
            // 
            // btnX
            // 
            this.btnX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnX.BackColor = System.Drawing.Color.Firebrick;
            this.btnX.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnX.FlatAppearance.BorderSize = 0;
            this.btnX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
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
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Maroon;
            this.pnlTop.Controls.Add(this.btnShowAll);
            this.pnlTop.Controls.Add(this.btnSearchItem);
            this.pnlTop.Controls.Add(this.cboCategory);
            this.pnlTop.Controls.Add(this.lblCategory);
            this.pnlTop.Controls.Add(this.lblViewProducts);
            this.pnlTop.Controls.Add(this.lblSearchItem);
            this.pnlTop.Controls.Add(this.txtSearchItem);
            this.pnlTop.Controls.Add(this.btnX);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(945, 117);
            this.pnlTop.TabIndex = 1;
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.SpringGreen;
            this.btnShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowAll.ForeColor = System.Drawing.Color.Black;
            this.btnShowAll.Location = new System.Drawing.Point(832, 40);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(88, 28);
            this.btnShowAll.TabIndex = 20;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.BtnShowAll_Click);
            // 
            // btnSearchItem
            // 
            this.btnSearchItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearchItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchItem.ForeColor = System.Drawing.Color.White;
            this.btnSearchItem.Location = new System.Drawing.Point(519, 74);
            this.btnSearchItem.Name = "btnSearchItem";
            this.btnSearchItem.Size = new System.Drawing.Size(75, 26);
            this.btnSearchItem.TabIndex = 19;
            this.btnSearchItem.Text = "Search";
            this.btnSearchItem.UseVisualStyleBackColor = true;
            this.btnSearchItem.Click += new System.EventHandler(this.BtnSearchItem_Click);
            // 
            // cboCategory
            // 
            this.cboCategory.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cboCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(757, 74);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(163, 26);
            this.cboCategory.TabIndex = 18;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.CboCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(653, 76);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(100, 22);
            this.lblCategory.TabIndex = 17;
            this.lblCategory.Text = "Category:";
            // 
            // lblViewProducts
            // 
            this.lblViewProducts.AutoSize = true;
            this.lblViewProducts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewProducts.ForeColor = System.Drawing.Color.White;
            this.lblViewProducts.Location = new System.Drawing.Point(26, 21);
            this.lblViewProducts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblViewProducts.Name = "lblViewProducts";
            this.lblViewProducts.Size = new System.Drawing.Size(241, 37);
            this.lblViewProducts.TabIndex = 16;
            this.lblViewProducts.Text = "View Products";
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.SystemColors.Info;
            this.pnlBackground.Controls.Add(this.dgdViewProducts);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Location = new System.Drawing.Point(0, 117);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(945, 522);
            this.pnlBackground.TabIndex = 2;
            // 
            // dgdViewProducts
            // 
            this.dgdViewProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgdViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdViewProducts.Location = new System.Drawing.Point(26, 22);
            this.dgdViewProducts.Name = "dgdViewProducts";
            this.dgdViewProducts.Size = new System.Drawing.Size(894, 430);
            this.dgdViewProducts.TabIndex = 0;
            // 
            // ViewProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 639);
            this.Controls.Add(this.pnlBackground);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(944, 639);
            this.Name = "ViewProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ViewProducts";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgdViewProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSearchItem;
        private System.Windows.Forms.TextBox txtSearchItem;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.DataGridView dgdViewProducts;
        private System.Windows.Forms.Label lblViewProducts;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnSearchItem;
        private System.Windows.Forms.Button btnShowAll;
    }
}