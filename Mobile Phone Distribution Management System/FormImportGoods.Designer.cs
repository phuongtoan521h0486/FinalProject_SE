
namespace Mobile_Phone_Distribution_Management_System
{
    partial class FormImportGoods
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
            this.components = new System.ComponentModel.Container();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxInformation = new System.Windows.Forms.GroupBox();
            this.labelInform = new System.Windows.Forms.Label();
            this.comboBoxSupplierList = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelTotalMoney = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAccountantName = new System.Windows.Forms.Label();
            this.panelCalendar = new System.Windows.Forms.Panel();
            this.buttonCreateGoodsReceived = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.tabPageCart = new System.Windows.Forms.TabPage();
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dataGridViewShopping = new System.Windows.Forms.DataGridView();
            this.tabPageProducts = new System.Windows.Forms.TabPage();
            this.panelBackground.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxInformation.SuspendLayout();
            this.panelCalendar.SuspendLayout();
            this.tabPageCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShopping)).BeginInit();
            this.tabPageProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.panelBackground.Controls.Add(this.tableLayoutPanel1);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(948, 538);
            this.panelBackground.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxInformation, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(948, 538);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBoxInformation
            // 
            this.groupBoxInformation.Controls.Add(this.labelInform);
            this.groupBoxInformation.Controls.Add(this.comboBoxSupplierList);
            this.groupBoxInformation.Controls.Add(this.labelName);
            this.groupBoxInformation.Controls.Add(this.labelTotalMoney);
            this.groupBoxInformation.Controls.Add(this.label1);
            this.groupBoxInformation.Controls.Add(this.labelAccountantName);
            this.groupBoxInformation.Controls.Add(this.panelCalendar);
            this.groupBoxInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInformation.ForeColor = System.Drawing.Color.White;
            this.groupBoxInformation.Location = new System.Drawing.Point(3, 3);
            this.groupBoxInformation.Name = "groupBoxInformation";
            this.groupBoxInformation.Size = new System.Drawing.Size(942, 182);
            this.groupBoxInformation.TabIndex = 2;
            this.groupBoxInformation.TabStop = false;
            this.groupBoxInformation.Text = "Information";
            // 
            // labelInform
            // 
            this.labelInform.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelInform.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInform.ForeColor = System.Drawing.Color.Lime;
            this.labelInform.Location = new System.Drawing.Point(3, 157);
            this.labelInform.Name = "labelInform";
            this.labelInform.Size = new System.Drawing.Size(717, 22);
            this.labelInform.TabIndex = 3;
            this.labelInform.Text = "Add success 00 ABC to Cart";
            this.labelInform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelInform.Visible = false;
            // 
            // comboBoxSupplierList
            // 
            this.comboBoxSupplierList.FormattingEnabled = true;
            this.comboBoxSupplierList.Location = new System.Drawing.Point(90, 58);
            this.comboBoxSupplierList.Name = "comboBoxSupplierList";
            this.comboBoxSupplierList.Size = new System.Drawing.Size(169, 21);
            this.comboBoxSupplierList.TabIndex = 2;
            this.comboBoxSupplierList.SelectedIndexChanged += new System.EventHandler(this.comboBoxSupplierList_SelectedIndexChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(175, 21);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 21);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "ABC";
            // 
            // labelTotalMoney
            // 
            this.labelTotalMoney.AutoSize = true;
            this.labelTotalMoney.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalMoney.Location = new System.Drawing.Point(9, 110);
            this.labelTotalMoney.Name = "labelTotalMoney";
            this.labelTotalMoney.Size = new System.Drawing.Size(150, 21);
            this.labelTotalMoney.TabIndex = 1;
            this.labelTotalMoney.Text = "Total Money: 123$";
            this.labelTotalMoney.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Supplier:";
            // 
            // labelAccountantName
            // 
            this.labelAccountantName.AutoSize = true;
            this.labelAccountantName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccountantName.Location = new System.Drawing.Point(9, 21);
            this.labelAccountantName.Name = "labelAccountantName";
            this.labelAccountantName.Size = new System.Drawing.Size(164, 21);
            this.labelAccountantName.TabIndex = 1;
            this.labelAccountantName.Text = "Accountant Name:";
            // 
            // panelCalendar
            // 
            this.panelCalendar.Controls.Add(this.buttonCreateGoodsReceived);
            this.panelCalendar.Controls.Add(this.labelDate);
            this.panelCalendar.Controls.Add(this.labelTime);
            this.panelCalendar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCalendar.Location = new System.Drawing.Point(720, 16);
            this.panelCalendar.Name = "panelCalendar";
            this.panelCalendar.Size = new System.Drawing.Size(219, 163);
            this.panelCalendar.TabIndex = 0;
            // 
            // buttonCreateGoodsReceived
            // 
            this.buttonCreateGoodsReceived.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonCreateGoodsReceived.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateGoodsReceived.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonCreateGoodsReceived.FlatAppearance.BorderSize = 0;
            this.buttonCreateGoodsReceived.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateGoodsReceived.Location = new System.Drawing.Point(0, 86);
            this.buttonCreateGoodsReceived.Name = "buttonCreateGoodsReceived";
            this.buttonCreateGoodsReceived.Size = new System.Drawing.Size(219, 77);
            this.buttonCreateGoodsReceived.TabIndex = 4;
            this.buttonCreateGoodsReceived.Text = "Create Goods Received";
            this.buttonCreateGoodsReceived.UseVisualStyleBackColor = false;
            this.buttonCreateGoodsReceived.Click += new System.EventHandler(this.buttonCreateGoodsReceived_Click);
            // 
            // labelDate
            // 
            this.labelDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(3, 23);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(213, 23);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Monday, May 2, 2023";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTime
            // 
            this.labelTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(60, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(100, 23);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "12:00:00";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Tick += new System.EventHandler(this.timerclock_Tick);
            // 
            // tabPageCart
            // 
            this.tabPageCart.Controls.Add(this.dataGridViewCart);
            this.tabPageCart.Location = new System.Drawing.Point(4, 22);
            this.tabPageCart.Name = "tabPageCart";
            this.tabPageCart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCart.Size = new System.Drawing.Size(934, 318);
            this.tabPageCart.TabIndex = 1;
            this.tabPageCart.Text = "Cart";
            this.tabPageCart.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCart.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.Size = new System.Drawing.Size(928, 312);
            this.dataGridViewCart.TabIndex = 0;
            this.dataGridViewCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCart_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageProducts);
            this.tabControl1.Controls.Add(this.tabPageCart);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 191);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(942, 344);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // dataGridViewShopping
            // 
            this.dataGridViewShopping.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewShopping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShopping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewShopping.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewShopping.Name = "dataGridViewShopping";
            this.dataGridViewShopping.Size = new System.Drawing.Size(928, 312);
            this.dataGridViewShopping.TabIndex = 0;
            this.dataGridViewShopping.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShopping_CellContentClick);
            this.dataGridViewShopping.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewShopping_CellFormatting);
            this.dataGridViewShopping.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewShopping_EditingControlShowing);
            // 
            // tabPageProducts
            // 
            this.tabPageProducts.Controls.Add(this.dataGridViewShopping);
            this.tabPageProducts.Location = new System.Drawing.Point(4, 22);
            this.tabPageProducts.Name = "tabPageProducts";
            this.tabPageProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProducts.Size = new System.Drawing.Size(934, 318);
            this.tabPageProducts.TabIndex = 0;
            this.tabPageProducts.Text = "Products";
            this.tabPageProducts.UseVisualStyleBackColor = true;
            // 
            // FormImportGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 538);
            this.Controls.Add(this.panelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormImportGoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormImportGoods";
            this.Load += new System.EventHandler(this.FormImportGoods_Load);
            this.panelBackground.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxInformation.ResumeLayout(false);
            this.groupBoxInformation.PerformLayout();
            this.panelCalendar.ResumeLayout(false);
            this.tabPageCart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShopping)).EndInit();
            this.tabPageProducts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxInformation;
        private System.Windows.Forms.Panel panelCalendar;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.ComboBox comboBoxSupplierList;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAccountantName;
        private System.Windows.Forms.Label labelInform;
        private System.Windows.Forms.Label labelTotalMoney;
        private System.Windows.Forms.Button buttonCreateGoodsReceived;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageProducts;
        private System.Windows.Forms.DataGridView dataGridViewShopping;
        private System.Windows.Forms.TabPage tabPageCart;
        private System.Windows.Forms.DataGridView dataGridViewCart;
    }
}