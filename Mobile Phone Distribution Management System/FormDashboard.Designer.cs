
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title13 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title14 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.buttonThisMonth = new System.Windows.Forms.Button();
            this.buttonLast30Days = new System.Windows.Forms.Button();
            this.buttonLast7Days = new System.Windows.Forms.Button();
            this.buttonToday = new System.Windows.Forms.Button();
            this.buttonCustomDate = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.panelNumberOfOrders = new System.Windows.Forms.Panel();
            this.labelText1 = new System.Windows.Forms.Label();
            this.labelNumberOrders = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTotalRevenue = new System.Windows.Forms.Label();
            this.labelText2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTotalProfit = new System.Windows.Forms.Label();
            this.labelText3 = new System.Windows.Forms.Label();
            this.chartGrossRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTopProduct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelNumberResellers = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNumberSuppliers = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelNumberProducts = new System.Windows.Forms.Label();
            this.panelNumberOfOrders.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrossRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProduct)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.CustomFormat = "MMM dd, yyyy";
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(666, 390);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(112, 20);
            this.dateTimePickerStartDate.TabIndex = 0;
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.CustomFormat = "MMM dd, yyyy";
            this.dateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(792, 390);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(112, 20);
            this.dateTimePickerEndDate.TabIndex = 1;
            // 
            // buttonThisMonth
            // 
            this.buttonThisMonth.Location = new System.Drawing.Point(897, 515);
            this.buttonThisMonth.Name = "buttonThisMonth";
            this.buttonThisMonth.Size = new System.Drawing.Size(213, 76);
            this.buttonThisMonth.TabIndex = 2;
            this.buttonThisMonth.Text = "This Month";
            this.buttonThisMonth.UseVisualStyleBackColor = true;
            this.buttonThisMonth.Click += new System.EventHandler(this.buttonThisMonth_Click);
            // 
            // buttonLast30Days
            // 
            this.buttonLast30Days.Location = new System.Drawing.Point(897, 428);
            this.buttonLast30Days.Name = "buttonLast30Days";
            this.buttonLast30Days.Size = new System.Drawing.Size(213, 76);
            this.buttonLast30Days.TabIndex = 2;
            this.buttonLast30Days.Text = "Last 30 Days";
            this.buttonLast30Days.UseVisualStyleBackColor = true;
            this.buttonLast30Days.Click += new System.EventHandler(this.buttonLast30Days_Click);
            // 
            // buttonLast7Days
            // 
            this.buttonLast7Days.Location = new System.Drawing.Point(666, 515);
            this.buttonLast7Days.Name = "buttonLast7Days";
            this.buttonLast7Days.Size = new System.Drawing.Size(213, 76);
            this.buttonLast7Days.TabIndex = 2;
            this.buttonLast7Days.Text = "Last 7 Days";
            this.buttonLast7Days.UseVisualStyleBackColor = true;
            this.buttonLast7Days.Click += new System.EventHandler(this.buttonLast7Days_Click);
            // 
            // buttonToday
            // 
            this.buttonToday.Location = new System.Drawing.Point(666, 428);
            this.buttonToday.Name = "buttonToday";
            this.buttonToday.Size = new System.Drawing.Size(213, 76);
            this.buttonToday.TabIndex = 2;
            this.buttonToday.Text = "Today";
            this.buttonToday.UseVisualStyleBackColor = true;
            this.buttonToday.Click += new System.EventHandler(this.buttonToday_Click);
            // 
            // buttonCustomDate
            // 
            this.buttonCustomDate.Location = new System.Drawing.Point(958, 381);
            this.buttonCustomDate.Name = "buttonCustomDate";
            this.buttonCustomDate.Size = new System.Drawing.Size(152, 40);
            this.buttonCustomDate.TabIndex = 2;
            this.buttonCustomDate.Text = "Custom";
            this.buttonCustomDate.UseVisualStyleBackColor = true;
            this.buttonCustomDate.Click += new System.EventHandler(this.buttonCustomDate_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(910, 382);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(40, 40);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // panelNumberOfOrders
            // 
            this.panelNumberOfOrders.BackColor = System.Drawing.Color.White;
            this.panelNumberOfOrders.Controls.Add(this.labelNumberOrders);
            this.panelNumberOfOrders.Controls.Add(this.labelText1);
            this.panelNumberOfOrders.Location = new System.Drawing.Point(12, 12);
            this.panelNumberOfOrders.Name = "panelNumberOfOrders";
            this.panelNumberOfOrders.Size = new System.Drawing.Size(220, 57);
            this.panelNumberOfOrders.TabIndex = 3;
            // 
            // labelText1
            // 
            this.labelText1.AutoSize = true;
            this.labelText1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText1.Location = new System.Drawing.Point(13, 0);
            this.labelText1.Name = "labelText1";
            this.labelText1.Size = new System.Drawing.Size(151, 21);
            this.labelText1.TabIndex = 0;
            this.labelText1.Text = "Number Of Orders";
            // 
            // labelNumberOrders
            // 
            this.labelNumberOrders.AutoSize = true;
            this.labelNumberOrders.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOrders.Location = new System.Drawing.Point(13, 21);
            this.labelNumberOrders.Name = "labelNumberOrders";
            this.labelNumberOrders.Size = new System.Drawing.Size(76, 23);
            this.labelNumberOrders.TabIndex = 0;
            this.labelNumberOrders.Text = "100000";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelTotalRevenue);
            this.panel1.Controls.Add(this.labelText2);
            this.panel1.Location = new System.Drawing.Point(238, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 57);
            this.panel1.TabIndex = 4;
            // 
            // labelTotalRevenue
            // 
            this.labelTotalRevenue.AutoSize = true;
            this.labelTotalRevenue.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalRevenue.Location = new System.Drawing.Point(13, 21);
            this.labelTotalRevenue.Name = "labelTotalRevenue";
            this.labelTotalRevenue.Size = new System.Drawing.Size(76, 23);
            this.labelTotalRevenue.TabIndex = 0;
            this.labelTotalRevenue.Text = "100000";
            // 
            // labelText2
            // 
            this.labelText2.AutoSize = true;
            this.labelText2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText2.Location = new System.Drawing.Point(13, 0);
            this.labelText2.Name = "labelText2";
            this.labelText2.Size = new System.Drawing.Size(123, 21);
            this.labelText2.TabIndex = 0;
            this.labelText2.Text = "Total Revenue";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.labelTotalProfit);
            this.panel2.Controls.Add(this.labelText3);
            this.panel2.Location = new System.Drawing.Point(555, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 57);
            this.panel2.TabIndex = 5;
            // 
            // labelTotalProfit
            // 
            this.labelTotalProfit.AutoSize = true;
            this.labelTotalProfit.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalProfit.Location = new System.Drawing.Point(13, 21);
            this.labelTotalProfit.Name = "labelTotalProfit";
            this.labelTotalProfit.Size = new System.Drawing.Size(76, 23);
            this.labelTotalProfit.TabIndex = 0;
            this.labelTotalProfit.Text = "100000";
            // 
            // labelText3
            // 
            this.labelText3.AutoSize = true;
            this.labelText3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText3.Location = new System.Drawing.Point(13, 0);
            this.labelText3.Name = "labelText3";
            this.labelText3.Size = new System.Drawing.Size(92, 21);
            this.labelText3.TabIndex = 0;
            this.labelText3.Text = "Total Profit";
            // 
            // chartGrossRevenue
            // 
            chartArea13.Name = "ChartArea1";
            this.chartGrossRevenue.ChartAreas.Add(chartArea13);
            legend13.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend13.Name = "Legend1";
            this.chartGrossRevenue.Legends.Add(legend13);
            this.chartGrossRevenue.Location = new System.Drawing.Point(360, 75);
            this.chartGrossRevenue.Name = "chartGrossRevenue";
            series13.ChartArea = "ChartArea1";
            series13.Legend = "Legend1";
            series13.Name = "Series1";
            this.chartGrossRevenue.Series.Add(series13);
            this.chartGrossRevenue.Size = new System.Drawing.Size(750, 300);
            this.chartGrossRevenue.TabIndex = 6;
            this.chartGrossRevenue.Text = "chart1";
            title13.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title13.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title13.Name = "Title1";
            title13.Text = "Gross Revenue";
            this.chartGrossRevenue.Titles.Add(title13);
            // 
            // chartTopProduct
            // 
            chartArea14.Name = "ChartArea1";
            this.chartTopProduct.ChartAreas.Add(chartArea14);
            legend14.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend14.Name = "Legend1";
            this.chartTopProduct.Legends.Add(legend14);
            this.chartTopProduct.Location = new System.Drawing.Point(13, 78);
            this.chartTopProduct.Name = "chartTopProduct";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series14.IsValueShownAsLabel = true;
            series14.LabelForeColor = System.Drawing.Color.White;
            series14.Legend = "Legend1";
            series14.Name = "Series1";
            this.chartTopProduct.Series.Add(series14);
            this.chartTopProduct.Size = new System.Drawing.Size(341, 513);
            this.chartTopProduct.TabIndex = 7;
            this.chartTopProduct.Text = "chart2";
            title14.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title14.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title14.Name = "Title1";
            title14.Text = "Top 5 Products";
            this.chartTopProduct.Titles.Add(title14);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.labelNumberProducts);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.labelNumberSuppliers);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.labelNumberResellers);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(360, 381);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 210);
            this.panel3.TabIndex = 3;
            // 
            // labelNumberResellers
            // 
            this.labelNumberResellers.AutoSize = true;
            this.labelNumberResellers.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberResellers.Location = new System.Drawing.Point(182, 29);
            this.labelNumberResellers.Name = "labelNumberResellers";
            this.labelNumberResellers.Size = new System.Drawing.Size(76, 23);
            this.labelNumberResellers.TabIndex = 0;
            this.labelNumberResellers.Text = "100000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number Of Resellers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Counter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Number Of Suppliers";
            // 
            // labelNumberSuppliers
            // 
            this.labelNumberSuppliers.AutoSize = true;
            this.labelNumberSuppliers.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberSuppliers.Location = new System.Drawing.Point(182, 82);
            this.labelNumberSuppliers.Name = "labelNumberSuppliers";
            this.labelNumberSuppliers.Size = new System.Drawing.Size(76, 23);
            this.labelNumberSuppliers.TabIndex = 0;
            this.labelNumberSuppliers.Text = "100000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Number Of Products";
            // 
            // labelNumberProducts
            // 
            this.labelNumberProducts.AutoSize = true;
            this.labelNumberProducts.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberProducts.Location = new System.Drawing.Point(182, 137);
            this.labelNumberProducts.Name = "labelNumberProducts";
            this.labelNumberProducts.Size = new System.Drawing.Size(76, 23);
            this.labelNumberProducts.TabIndex = 0;
            this.labelNumberProducts.Text = "100000";
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 600);
            this.Controls.Add(this.chartTopProduct);
            this.Controls.Add(this.chartGrossRevenue);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelNumberOfOrders);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCustomDate);
            this.Controls.Add(this.buttonToday);
            this.Controls.Add(this.buttonLast7Days);
            this.Controls.Add(this.buttonLast30Days);
            this.Controls.Add(this.buttonThisMonth);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.dateTimePickerStartDate);
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
    }
}