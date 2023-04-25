
namespace Mobile_Phone_Distribution_Management_System
{
    partial class FormDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.buttonThisMonth = new System.Windows.Forms.Button();
            this.buttonLast30Days = new System.Windows.Forms.Button();
            this.buttonLast7Days = new System.Windows.Forms.Button();
            this.buttonToday = new System.Windows.Forms.Button();
            this.buttonCustomDate = new System.Windows.Forms.Button();
            this.panelNumberOfOrders = new System.Windows.Forms.Panel();
            this.labelNumberOrders = new System.Windows.Forms.Label();
            this.labelText1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTotalRevenue = new System.Windows.Forms.Label();
            this.labelText2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTotalProfit = new System.Windows.Forms.Label();
            this.labelText3 = new System.Windows.Forms.Label();
            this.chartGrossRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTopProduct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNumberProducts = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelNumberSuppliers = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNumberResellers = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelFunctions = new System.Windows.Forms.Panel();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonOK = new System.Windows.Forms.Button();
            this.panelNumberOfOrders.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrossRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProduct)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelFunctions.SuspendLayout();
            this.panelBackground.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.CustomFormat = "MMM dd, yyyy";
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(3, 11);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(112, 20);
            this.dateTimePickerStartDate.TabIndex = 0;
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.CustomFormat = "MMM dd, yyyy";
            this.dateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(121, 11);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(112, 20);
            this.dateTimePickerEndDate.TabIndex = 1;
            // 
            // buttonThisMonth
            // 
            this.buttonThisMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonThisMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonThisMonth.FlatAppearance.BorderSize = 0;
            this.buttonThisMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThisMonth.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThisMonth.ForeColor = System.Drawing.Color.White;
            this.buttonThisMonth.Location = new System.Drawing.Point(232, 40);
            this.buttonThisMonth.Name = "buttonThisMonth";
            this.buttonThisMonth.Size = new System.Drawing.Size(224, 32);
            this.buttonThisMonth.TabIndex = 2;
            this.buttonThisMonth.Text = "This Month";
            this.buttonThisMonth.UseVisualStyleBackColor = false;
            this.buttonThisMonth.Click += new System.EventHandler(this.buttonThisMonth_Click);
            // 
            // buttonLast30Days
            // 
            this.buttonLast30Days.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonLast30Days.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLast30Days.FlatAppearance.BorderSize = 0;
            this.buttonLast30Days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLast30Days.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLast30Days.ForeColor = System.Drawing.Color.White;
            this.buttonLast30Days.Location = new System.Drawing.Point(232, 3);
            this.buttonLast30Days.Name = "buttonLast30Days";
            this.buttonLast30Days.Size = new System.Drawing.Size(224, 31);
            this.buttonLast30Days.TabIndex = 2;
            this.buttonLast30Days.Text = "Last 30 Days";
            this.buttonLast30Days.UseVisualStyleBackColor = false;
            this.buttonLast30Days.Click += new System.EventHandler(this.buttonLast30Days_Click);
            // 
            // buttonLast7Days
            // 
            this.buttonLast7Days.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonLast7Days.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLast7Days.FlatAppearance.BorderSize = 0;
            this.buttonLast7Days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLast7Days.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLast7Days.ForeColor = System.Drawing.Color.White;
            this.buttonLast7Days.Location = new System.Drawing.Point(3, 40);
            this.buttonLast7Days.Name = "buttonLast7Days";
            this.buttonLast7Days.Size = new System.Drawing.Size(223, 32);
            this.buttonLast7Days.TabIndex = 2;
            this.buttonLast7Days.Text = "Last 7 Days";
            this.buttonLast7Days.UseVisualStyleBackColor = false;
            this.buttonLast7Days.Click += new System.EventHandler(this.buttonLast7Days_Click);
            // 
            // buttonToday
            // 
            this.buttonToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonToday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonToday.FlatAppearance.BorderSize = 0;
            this.buttonToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToday.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToday.ForeColor = System.Drawing.Color.White;
            this.buttonToday.Location = new System.Drawing.Point(3, 3);
            this.buttonToday.Name = "buttonToday";
            this.buttonToday.Size = new System.Drawing.Size(223, 31);
            this.buttonToday.TabIndex = 2;
            this.buttonToday.Text = "Today";
            this.buttonToday.UseVisualStyleBackColor = false;
            this.buttonToday.Click += new System.EventHandler(this.buttonToday_Click);
            // 
            // buttonCustomDate
            // 
            this.buttonCustomDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCustomDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonCustomDate.FlatAppearance.BorderSize = 0;
            this.buttonCustomDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomDate.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustomDate.ForeColor = System.Drawing.Color.White;
            this.buttonCustomDate.Location = new System.Drawing.Point(283, 3);
            this.buttonCustomDate.Name = "buttonCustomDate";
            this.buttonCustomDate.Size = new System.Drawing.Size(176, 41);
            this.buttonCustomDate.TabIndex = 2;
            this.buttonCustomDate.Text = "Custom";
            this.buttonCustomDate.UseVisualStyleBackColor = false;
            this.buttonCustomDate.Click += new System.EventHandler(this.buttonCustomDate_Click);
            // 
            // panelNumberOfOrders
            // 
            this.panelNumberOfOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panelNumberOfOrders.Controls.Add(this.labelNumberOrders);
            this.panelNumberOfOrders.Controls.Add(this.labelText1);
            this.panelNumberOfOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNumberOfOrders.Location = new System.Drawing.Point(0, 0);
            this.panelNumberOfOrders.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.panelNumberOfOrders.Name = "panelNumberOfOrders";
            this.panelNumberOfOrders.Size = new System.Drawing.Size(355, 50);
            this.panelNumberOfOrders.TabIndex = 3;
            // 
            // labelNumberOrders
            // 
            this.labelNumberOrders.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelNumberOrders.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOrders.ForeColor = System.Drawing.Color.White;
            this.labelNumberOrders.Location = new System.Drawing.Point(0, 27);
            this.labelNumberOrders.Name = "labelNumberOrders";
            this.labelNumberOrders.Size = new System.Drawing.Size(355, 23);
            this.labelNumberOrders.TabIndex = 0;
            this.labelNumberOrders.Text = "100000";
            this.labelNumberOrders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelText1
            // 
            this.labelText1.AutoSize = true;
            this.labelText1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText1.ForeColor = System.Drawing.Color.White;
            this.labelText1.Location = new System.Drawing.Point(2, 3);
            this.labelText1.Name = "labelText1";
            this.labelText1.Size = new System.Drawing.Size(151, 21);
            this.labelText1.TabIndex = 0;
            this.labelText1.Text = "Number Of Orders";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.labelTotalRevenue);
            this.panel1.Controls.Add(this.labelText2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(365, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 50);
            this.panel1.TabIndex = 4;
            // 
            // labelTotalRevenue
            // 
            this.labelTotalRevenue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelTotalRevenue.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalRevenue.ForeColor = System.Drawing.Color.White;
            this.labelTotalRevenue.Location = new System.Drawing.Point(0, 27);
            this.labelTotalRevenue.Name = "labelTotalRevenue";
            this.labelTotalRevenue.Size = new System.Drawing.Size(355, 23);
            this.labelTotalRevenue.TabIndex = 0;
            this.labelTotalRevenue.Text = "100000";
            this.labelTotalRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelText2
            // 
            this.labelText2.AutoSize = true;
            this.labelText2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText2.ForeColor = System.Drawing.Color.White;
            this.labelText2.Location = new System.Drawing.Point(13, 3);
            this.labelText2.Name = "labelText2";
            this.labelText2.Size = new System.Drawing.Size(123, 21);
            this.labelText2.TabIndex = 0;
            this.labelText2.Text = "Total Revenue";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.labelTotalProfit);
            this.panel2.Controls.Add(this.labelText3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(730, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 50);
            this.panel2.TabIndex = 5;
            // 
            // labelTotalProfit
            // 
            this.labelTotalProfit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelTotalProfit.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalProfit.ForeColor = System.Drawing.Color.White;
            this.labelTotalProfit.Location = new System.Drawing.Point(0, 27);
            this.labelTotalProfit.Name = "labelTotalProfit";
            this.labelTotalProfit.Size = new System.Drawing.Size(356, 23);
            this.labelTotalProfit.TabIndex = 0;
            this.labelTotalProfit.Text = "100000";
            this.labelTotalProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelText3
            // 
            this.labelText3.AutoSize = true;
            this.labelText3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText3.ForeColor = System.Drawing.Color.White;
            this.labelText3.Location = new System.Drawing.Point(13, 3);
            this.labelText3.Name = "labelText3";
            this.labelText3.Size = new System.Drawing.Size(92, 21);
            this.labelText3.TabIndex = 0;
            this.labelText3.Text = "Total Profit";
            // 
            // chartGrossRevenue
            // 
            this.chartGrossRevenue.BackColor = System.Drawing.Color.Linen;
            chartArea7.BackColor = System.Drawing.Color.Linen;
            chartArea7.Name = "ChartArea1";
            this.chartGrossRevenue.ChartAreas.Add(chartArea7);
            this.chartGrossRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            legend7.BackColor = System.Drawing.Color.Linen;
            legend7.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend7.Name = "Legend1";
            this.chartGrossRevenue.Legends.Add(legend7);
            this.chartGrossRevenue.Location = new System.Drawing.Point(0, 0);
            this.chartGrossRevenue.Margin = new System.Windows.Forms.Padding(0);
            this.chartGrossRevenue.Name = "chartGrossRevenue";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chartGrossRevenue.Series.Add(series7);
            this.chartGrossRevenue.Size = new System.Drawing.Size(755, 332);
            this.chartGrossRevenue.TabIndex = 6;
            this.chartGrossRevenue.Text = "chart1";
            title7.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title7.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title7.Name = "Title1";
            title7.Text = "Gross Revenue";
            this.chartGrossRevenue.Titles.Add(title7);
            // 
            // chartTopProduct
            // 
            this.chartTopProduct.BackColor = System.Drawing.Color.Linen;
            chartArea8.BackColor = System.Drawing.Color.Linen;
            chartArea8.Name = "ChartArea1";
            this.chartTopProduct.ChartAreas.Add(chartArea8);
            this.chartTopProduct.Dock = System.Windows.Forms.DockStyle.Left;
            legend8.BackColor = System.Drawing.Color.Linen;
            legend8.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend8.Name = "Legend1";
            this.chartTopProduct.Legends.Add(legend8);
            this.chartTopProduct.Location = new System.Drawing.Point(10, 70);
            this.chartTopProduct.Margin = new System.Windows.Forms.Padding(0);
            this.chartTopProduct.Name = "chartTopProduct";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series8.IsValueShownAsLabel = true;
            series8.LabelForeColor = System.Drawing.Color.White;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chartTopProduct.Series.Add(series8);
            this.chartTopProduct.Size = new System.Drawing.Size(341, 475);
            this.chartTopProduct.TabIndex = 7;
            this.chartTopProduct.Text = "chart2";
            title8.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title8.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title8.Name = "Title1";
            title8.Text = "Top 5 Products";
            this.chartTopProduct.Titles.Add(title8);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.labelNumberProducts);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.labelNumberSuppliers);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.labelNumberResellers);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 131);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Counter";
            // 
            // labelNumberProducts
            // 
            this.labelNumberProducts.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberProducts.ForeColor = System.Drawing.Color.White;
            this.labelNumberProducts.Location = new System.Drawing.Point(182, 91);
            this.labelNumberProducts.Name = "labelNumberProducts";
            this.labelNumberProducts.Size = new System.Drawing.Size(76, 23);
            this.labelNumberProducts.TabIndex = 0;
            this.labelNumberProducts.Text = "100000";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Number Of Products";
            // 
            // labelNumberSuppliers
            // 
            this.labelNumberSuppliers.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberSuppliers.ForeColor = System.Drawing.Color.White;
            this.labelNumberSuppliers.Location = new System.Drawing.Point(182, 57);
            this.labelNumberSuppliers.Name = "labelNumberSuppliers";
            this.labelNumberSuppliers.Size = new System.Drawing.Size(76, 23);
            this.labelNumberSuppliers.TabIndex = 0;
            this.labelNumberSuppliers.Text = "100000";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Number Of Suppliers";
            // 
            // labelNumberResellers
            // 
            this.labelNumberResellers.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberResellers.ForeColor = System.Drawing.Color.White;
            this.labelNumberResellers.Location = new System.Drawing.Point(182, 29);
            this.labelNumberResellers.Name = "labelNumberResellers";
            this.labelNumberResellers.Size = new System.Drawing.Size(76, 23);
            this.labelNumberResellers.TabIndex = 0;
            this.labelNumberResellers.Text = "100000";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number Of Resellers";
            // 
            // panelFunctions
            // 
            this.panelFunctions.BackColor = System.Drawing.Color.Linen;
            this.panelFunctions.Controls.Add(this.tableLayoutPanel3);
            this.panelFunctions.Controls.Add(this.buttonCustomDate);
            this.panelFunctions.Controls.Add(this.buttonOK);
            this.panelFunctions.Controls.Add(this.dateTimePickerEndDate);
            this.panelFunctions.Controls.Add(this.dateTimePickerStartDate);
            this.panelFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFunctions.Location = new System.Drawing.Point(277, 3);
            this.panelFunctions.Name = "panelFunctions";
            this.panelFunctions.Size = new System.Drawing.Size(469, 131);
            this.panelFunctions.TabIndex = 8;
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelBackground.Controls.Add(this.tableLayoutPanel4);
            this.panelBackground.Controls.Add(this.chartTopProduct);
            this.panelBackground.Controls.Add(this.tableLayoutPanel1);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Padding = new System.Windows.Forms.Padding(10);
            this.panelBackground.Size = new System.Drawing.Size(1116, 555);
            this.panelBackground.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.panelNumberOfOrders, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1096, 60);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.63102F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.36898F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panelFunctions, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 335);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(749, 137);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.buttonToday, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonLast7Days, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.buttonThisMonth, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.buttonLast30Days, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 50);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(459, 75);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.chartGrossRevenue, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(351, 70);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(755, 475);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.buttonOK.BackgroundImage = global::Mobile_Phone_Distribution_Management_System.Properties.Resources.ok;
            this.buttonOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonOK.FlatAppearance.BorderSize = 0;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            this.buttonOK.Location = new System.Drawing.Point(237, 3);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(40, 41);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 555);
            this.Controls.Add(this.panelBackground);
            this.MinimumSize = new System.Drawing.Size(1130, 594);
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            this.panelNumberOfOrders.ResumeLayout(false);
            this.panelNumberOfOrders.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrossRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProduct)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelFunctions.ResumeLayout(false);
            this.panelBackground.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Button buttonThisMonth;
        private System.Windows.Forms.Button buttonLast30Days;
        private System.Windows.Forms.Button buttonLast7Days;
        private System.Windows.Forms.Button buttonToday;
        private System.Windows.Forms.Button buttonCustomDate;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Panel panelNumberOfOrders;
        private System.Windows.Forms.Label labelNumberOrders;
        private System.Windows.Forms.Label labelText1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTotalRevenue;
        private System.Windows.Forms.Label labelText2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTotalProfit;
        private System.Windows.Forms.Label labelText3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrossRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopProduct;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNumberProducts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelNumberSuppliers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNumberResellers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelFunctions;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    }
}