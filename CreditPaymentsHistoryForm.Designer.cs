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
            this.dataGridViewCreditPaymentsHistory.Location = new System.Drawing.Point(33, 157);
            this.dataGridViewCreditPaymentsHistory.Name = "dataGridViewCreditPaymentsHistory";
            this.dataGridViewCreditPaymentsHistory.RowTemplate.Height = 24;
            this.dataGridViewCreditPaymentsHistory.Size = new System.Drawing.Size(724, 252);
            this.dataGridViewCreditPaymentsHistory.TabIndex = 0;
            // 
            // CreditPaymentsHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewCreditPaymentsHistory);
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