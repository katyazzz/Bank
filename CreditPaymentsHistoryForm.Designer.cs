namespace Bank
{
    partial class CreditPaymentsHistoryForm
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
            this.dataGridViewCreditPaymentsHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCreditPaymentsHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCreditPaymentsHistory
            // 
            this.dataGridViewCreditPaymentsHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCreditPaymentsHistory.Location = new System.Drawing.Point(25, 128);
            this.dataGridViewCreditPaymentsHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewCreditPaymentsHistory.Name = "dataGridViewCreditPaymentsHistory";
            this.dataGridViewCreditPaymentsHistory.RowTemplate.Height = 24;
            this.dataGridViewCreditPaymentsHistory.Size = new System.Drawing.Size(543, 205);
            this.dataGridViewCreditPaymentsHistory.TabIndex = 0;
            this.dataGridViewCreditPaymentsHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCreditPaymentsHistory_CellContentClick);
            // 
            // CreditPaymentsHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dataGridViewCreditPaymentsHistory);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CreditPaymentsHistoryForm";
            this.Text = "CreditPaymentsHistoryForm";
            this.Load += new System.EventHandler(this.CreditPaymentsHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCreditPaymentsHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCreditPaymentsHistory;
    }
}