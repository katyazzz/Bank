namespace Bank
{
    partial class DepositPaymentsHistoryKlientForm
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
            this.dataGridHis = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHis)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridHis
            // 
            this.dataGridHis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHis.Location = new System.Drawing.Point(36, 86);
            this.dataGridHis.Name = "dataGridHis";
            this.dataGridHis.Size = new System.Drawing.Size(581, 229);
            this.dataGridHis.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "История операций (вклады)";
            // 
            // DepositPaymentsHistoryKlientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(666, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridHis);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DepositPaymentsHistoryKlientForm";
            this.Text = "DepositPaymentsHistoryKlientForm";
            this.Load += new System.EventHandler(this.DepositPaymentsHistoryKlientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridHis;
        private System.Windows.Forms.Label label1;
    }
}