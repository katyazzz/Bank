namespace Bank
{
    partial class CreditPaymentsHistoryKlientForm
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
            this.dataGridHis.Location = new System.Drawing.Point(32, 68);
            this.dataGridHis.Name = "dataGridHis";
            this.dataGridHis.Size = new System.Drawing.Size(583, 263);
            this.dataGridHis.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "История операций (кредиты)";
            // 
            // CreditPaymentsHistoryKlientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 367);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridHis);
            this.Name = "CreditPaymentsHistoryKlientForm";
            this.Text = "CreditPaymentsHistoryKlientForm";
            this.Load += new System.EventHandler(this.CreditPaymentsHistoryKlientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridHis;
        private System.Windows.Forms.Label label1;
    }
}