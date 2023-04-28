
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelNumberOfOrders.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrossRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProduct)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelFunctions.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panelBackground.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.CustomFormat = "MMM dd, yyyy";
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(9, 14);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(90, 20);
            this.dateTimePickerStartDate.TabIndex = 0;
            this.dateTimePickerStartDate.ValueChanged += new System.EventHandler(this.dateTimePickerStartDate_ValueChanged);
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.CustomFormat = "MMM dd, yyyy";
            this.dateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(135, 14);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(93, 20);
            this.dateTimePickerEndDate.TabIndex = 1;
            this.dateTimePickerEndDate.ValueChanged += new System.EventHandler(this.dateTimePickerEndDate_ValueChanged);
            // 
            // buttonThisMonth
            // 
            this.buttonThisMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonThisMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonThisMonth.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.buttonThisMonth.FlatAppearance.BorderSize = 0;
            this.buttonThisMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThisMonth.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThisMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.buttonThisMonth.Location = new System.Drawing.Point(278, 59);
            this.buttonThisMonth.Name = "buttonThisMonth";
            this.buttonThisMonth.Size = new System.Drawing.Size(269, 50);
            this.buttonThisMonth.TabIndex = 2;
            this.buttonThisMonth.Text = "This Month";
            this.buttonThisMonth.UseVisualStyleBackColor = false;
            this.buttonThisMonth.Click += new System.EventHandler(this.buttonThisMonth_Click);
            // 
            // buttonLast30Days
            // 
            this.buttonLast30Days.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonLast30Days.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLast30Days.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.buttonLast30Days.FlatAppearance.BorderSize = 0;
            this.buttonLast30Days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLast30Days.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLast30Days.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.buttonLast30Days.Location = new System.Drawing.Point(278, 3);
            this.buttonLast30Days.Name = "buttonLast30Days";
            this.buttonLast30Days.Size = new System.Drawing.Size(269, 50);
            this.buttonLast30Days.TabIndex = 2;
            this.buttonLast30Days.Text = "Last 30 Days";
            this.buttonLast30Days.UseVisualStyleBackColor = false;
            this.buttonLast30Days.Click += new System.EventHandler(this.buttonLast30Days_Click);
            // 
            // buttonLast7Days
            // 
            this.buttonLast7Days.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonLast7Days.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLast7Days.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.buttonLast7Days.FlatAppearance.BorderSize = 0;
            this.buttonLast7Days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLast7Days.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLast7Days.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.buttonLast7Days.Location = new System.Drawing.Point(3, 59);
            this.buttonLast7Days.Name = "buttonLast7Days";
            this.buttonLast7Days.Size = new System.Drawing.Size(269, 50);
            this.buttonLast7Days.TabIndex = 2;
            this.buttonLast7Days.Text = "Last 7 Days";
            this.buttonLast7Days.UseVisualStyleBackColor = false;
            this.buttonLast7Days.Click += new System.EventHandler(this.buttonLast7Days_Click);
            // 
            // buttonToday
            // 
            this.buttonToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonToday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonToday.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.buttonToday.FlatAppearance.BorderSize = 0;
            this.buttonToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToday.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.buttonToday.Location = new System.Drawing.Point(3, 3);
            this.buttonToday.Name = "buttonToday";
            this.buttonToday.Size = new System.Drawing.Size(269, 50);
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
            this.buttonCustomDate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.buttonCustomDate.FlatAppearance.BorderSize = 0;
            this.buttonCustomDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomDate.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustomDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.buttonCustomDate.Location = new System.Drawing.Point(283, 3);
            this.buttonCustomDate.Name = "buttonCustomDate";
            this.buttonCustomDate.Size = new System.Drawing.Size(267, 41);
            this.buttonCustomDate.TabIndex = 2;
            this.buttonCustomDate.Text = "Custom";
            this.buttonCustomDate.UseVisualStyleBackColor = false;
            this.buttonCustomDate.Click += new System.EventHandler(this.buttonCustomDate_Click);
            // 
            // panelNumberOfOrders
            // 
            this.panelNumberOfOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.panelNumberOfOrders.Controls.Add(this.labelNumberOrders);
            this.panelNumberOfOrders.Controls.Add(this.labelText1);
            this.panelNumberOfOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNumberOfOrders.Location = new System.Drawing.Point(0, 0);
            this.panelNumberOfOrders.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.panelNumberOfOrders.Name = "panelNumberOfOrders";
            this.panelNumberOfOrders.Size = new System.Drawing.Size(399, 50);
            this.panelNumberOfOrders.TabIndex = 3;
            // 
            // labelNumberOrders
            // 
            this.labelNumberOrders.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelNumberOrders.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOrders.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelNumberOrders.Location = new System.Drawing.Point(0, 27);
            this.labelNumberOrders.Name = "labelNumberOrders";
            this.labelNumberOrders.Size = new System.Drawing.Size(399, 23);
            this.labelNumberOrders.TabIndex = 0;
            this.labelNumberOrders.Text = "100000";
            this.labelNumberOrders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelText1
            // 
            this.labelText1.AutoSize = true;
            this.labelText1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText1.ForeColor = System.Drawing.Color.Silver;
            this.labelText1.Location = new System.Drawing.Point(2, 3);
            this.labelText1.Name = "labelText1";
            this.labelText1.Size = new System.Drawing.Size(151, 21);
            this.labelText1.TabIndex = 0;
            this.labelText1.Text = "Number Of Orders";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.labelTotalRevenue);
            this.panel1.Controls.Add(this.labelText2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(409, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 50);
            this.panel1.TabIndex = 4;
            // 
            // labelTotalRevenue
            // 
            this.labelTotalRevenue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelTotalRevenue.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalRevenue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelTotalRevenue.Location = new System.Drawing.Point(0, 27);
            this.labelTotalRevenue.Name = "labelTotalRevenue";
            this.labelTotalRevenue.Size = new System.Drawing.Size(399, 23);
            this.labelTotalRevenue.TabIndex = 0;
            this.labelTotalRevenue.Text = "100000";
            this.labelTotalRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelText2
            // 
            this.labelText2.AutoSize = true;
            this.labelText2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText2.ForeColor = System.Drawing.Color.Silver;
            this.labelText2.Location = new System.Drawing.Point(13, 3);
            this.labelText2.Name = "labelText2";
            this.labelText2.Size = new System.Drawing.Size(123, 21);
            this.labelText2.TabIndex = 0;
            this.labelText2.Text = "Total Revenue";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.panel2.Controls.Add(this.labelTotalProfit);
            this.panel2.Controls.Add(this.labelText3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(818, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 50);
            this.panel2.TabIndex = 5;
            // 
            // labelTotalProfit
            // 
            this.labelTotalProfit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelTotalProfit.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalProfit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelTotalProfit.Location = new System.Drawing.Point(0, 27);
            this.labelTotalProfit.Name = "labelTotalProfit";
            this.labelTotalProfit.Size = new System.Drawing.Size(401, 23);
            this.labelTotalProfit.TabIndex = 0;
            this.labelTotalProfit.Text = "100000";
            this.labelTotalProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelText3
            // 
            this.labelText3.AutoSize = true;
            this.labelText3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText3.ForeColor = System.Drawing.Color.Silver;
            this.labelText3.Location = new System.Drawing.Point(13, 3);
            this.labelText3.Name = "labelText3";
            this.labelText3.Size = new System.Drawing.Size(92, 21);
            this.labelText3.TabIndex = 0;
            this.labelText3.Text = "Total Profit";
            // 
            // chartGrossRevenue
            // 
            this.chartGrossRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineWidth = 0;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea1.AxisX.MajorTickMark.Size = 3F;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.LabelStyle.Format = "${0:0,}K";
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineWidth = 0;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea1.AxisY.MajorTickMark.LineWidth = 0;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea1.Name = "ChartArea1";
            this.chartGrossRevenue.ChartAreas.Add(chartArea1);
            this.chartGrossRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            legend1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartGrossRevenue.Legends.Add(legend1);
            this.chartGrossRevenue.Location = new System.Drawing.Point(5, 0);
            this.chartGrossRevenue.Margin = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.chartGrossRevenue.Name = "chartGrossRevenue";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.MediumPurple;
            series1.MarkerSize = 10;
            series1.Name = "Series1";
            this.chartGrossRevenue.Series.Add(series1);
            this.chartGrossRevenue.Size = new System.Drawing.Size(883, 387);
            this.chartGrossRevenue.TabIndex = 6;
            this.chartGrossRevenue.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.WhiteSmoke;
            title1.Name = "Title1";
            title1.Text = "Gross Revenue";
            this.chartGrossRevenue.Titles.Add(title1);
            // 
            // chartTopProduct
            // 
            this.chartTopProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea2.Name = "ChartArea1";
            this.chartTopProduct.ChartAreas.Add(chartArea2);
            this.chartTopProduct.Dock = System.Windows.Forms.DockStyle.Left;
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.ForeColor = System.Drawing.Color.Silver;
            legend2.Name = "Legend1";
            this.chartTopProduct.Legends.Add(legend2);
            this.chartTopProduct.Location = new System.Drawing.Point(10, 70);
            this.chartTopProduct.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.chartTopProduct.Name = "chartTopProduct";
            this.chartTopProduct.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartTopProduct.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(160)))), ((int)(((byte)(139))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(188)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(220)))), ((int)(((byte)(205))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(153)))), ((int)(((byte)(254)))))};
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            series2.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            series2.BorderWidth = 8;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            series2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.chartTopProduct.Series.Add(series2);
            this.chartTopProduct.Size = new System.Drawing.Size(341, 560);
            this.chartTopProduct.TabIndex = 7;
            this.chartTopProduct.Text = "chart2";
            title2.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.ForeColor = System.Drawing.Color.WhiteSmoke;
            title2.Name = "Title1";
            title2.Text = "Top 5 Products";
            this.chartTopProduct.Titles.Add(title2);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.labelNumberProducts);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.labelNumberSuppliers);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.labelNumberResellers);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(5, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(323, 168);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(13, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Counter";
            // 
            // labelNumberProducts
            // 
            this.labelNumberProducts.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberProducts.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelNumberProducts.Location = new System.Drawing.Point(182, 91);
            this.labelNumberProducts.Name = "labelNumberProducts";
            this.labelNumberProducts.Size = new System.Drawing.Size(76, 23);
            this.labelNumberProducts.TabIndex = 0;
            this.labelNumberProducts.Text = "100000";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(13, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Number Of Products";
            // 
            // labelNumberSuppliers
            // 
            this.labelNumberSuppliers.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberSuppliers.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelNumberSuppliers.Location = new System.Drawing.Point(182, 57);
            this.labelNumberSuppliers.Name = "labelNumberSuppliers";
            this.labelNumberSuppliers.Size = new System.Drawing.Size(76, 23);
            this.labelNumberSuppliers.TabIndex = 0;
            this.labelNumberSuppliers.Text = "100000";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(13, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Number Of Suppliers";
            // 
            // labelNumberResellers
            // 
            this.labelNumberResellers.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberResellers.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelNumberResellers.Location = new System.Drawing.Point(182, 29);
            this.labelNumberResellers.Name = "labelNumberResellers";
            this.labelNumberResellers.Size = new System.Drawing.Size(76, 23);
            this.labelNumberResellers.TabIndex = 0;
            this.labelNumberResellers.Text = "100000";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(13, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number Of Resellers";
            // 
            // panelFunctions
            // 
            this.panelFunctions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.panelFunctions.Controls.Add(this.tableLayoutPanel3);
            this.panelFunctions.Controls.Add(this.buttonCustomDate);
            this.panelFunctions.Controls.Add(this.buttonOK);
            this.panelFunctions.Controls.Add(this.label1);
            this.panelFunctions.Controls.Add(this.labelEndDate);
            this.panelFunctions.Controls.Add(this.labelStartDate);
            this.panelFunctions.Controls.Add(this.dateTimePickerEndDate);
            this.panelFunctions.Controls.Add(this.dateTimePickerStartDate);
            this.panelFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFunctions.Location = new System.Drawing.Point(328, 0);
            this.panelFunctions.Margin = new System.Windows.Forms.Padding(0);
            this.panelFunctions.Name = "panelFunctions";
            this.panelFunctions.Size = new System.Drawing.Size(560, 168);
            this.panelFunctions.TabIndex = 8;
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(550, 112);
            this.tableLayoutPanel3.TabIndex = 3;
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(110, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "-";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEndDate
            // 
            this.labelEndDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndDate.ForeColor = System.Drawing.Color.Silver;
            this.labelEndDate.Location = new System.Drawing.Point(135, 13);
            this.labelEndDate.MinimumSize = new System.Drawing.Size(93, 0);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(93, 21);
            this.labelEndDate.TabIndex = 0;
            this.labelEndDate.Text = "Apr 28, 2023";
            this.labelEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelEndDate.Click += new System.EventHandler(this.labelEndDate_Click);
            // 
            // labelStartDate
            // 
            this.labelStartDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartDate.ForeColor = System.Drawing.Color.Silver;
            this.labelStartDate.Location = new System.Drawing.Point(6, 13);
            this.labelStartDate.MinimumSize = new System.Drawing.Size(93, 0);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(93, 21);
            this.labelStartDate.TabIndex = 0;
            this.labelStartDate.Text = "Apr 28, 2023";
            this.labelStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelStartDate.Click += new System.EventHandler(this.labelStartDate_Click);
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.panelBackground.Controls.Add(this.tableLayoutPanel4);
            this.panelBackground.Controls.Add(this.chartTopProduct);
            this.panelBackground.Controls.Add(this.tableLayoutPanel1);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Padding = new System.Windows.Forms.Padding(10);
            this.panelBackground.Size = new System.Drawing.Size(1249, 640);
            this.panelBackground.TabIndex = 9;
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
            this.tableLayoutPanel4.Size = new System.Drawing.Size(888, 560);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.63102F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.36898F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panelFunctions, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 392);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(888, 168);
            this.tableLayoutPanel2.TabIndex = 9;
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1229, 60);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 640);
            this.Controls.Add(this.panelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1130, 594);
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
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
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panelBackground.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelStartDate;
    }
}