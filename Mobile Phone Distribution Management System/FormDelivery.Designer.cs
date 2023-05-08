
namespace Mobile_Phone_Distribution_Management_System
{
    partial class FormDelivery
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
            this.dataGridViewOrderQueue = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderQueue)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrderQueue
            // 
            this.dataGridViewOrderQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderQueue.Location = new System.Drawing.Point(45, 44);
            this.dataGridViewOrderQueue.Name = "dataGridViewOrderQueue";
            this.dataGridViewOrderQueue.Size = new System.Drawing.Size(693, 313);
            this.dataGridViewOrderQueue.TabIndex = 0;
            // 
            // FormDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewOrderQueue);
            this.Name = "FormDelivery";
            this.Text = "FormDelivery";
            this.Load += new System.EventHandler(this.FormDelivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderQueue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrderQueue;
    }
}