﻿namespace Bank
{
    partial class DepositPaymentsHistoryForm
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
            this.dataGridViewDepositPaymentsHistory = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepositPaymentsHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDepositPaymentsHistory
            // 
            this.dataGridViewDepositPaymentsHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepositPaymentsHistory.Location = new System.Drawing.Point(34, 128);
            this.dataGridViewDepositPaymentsHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewDepositPaymentsHistory.Name = "dataGridViewDepositPaymentsHistory";
            this.dataGridViewDepositPaymentsHistory.RowTemplate.Height = 24;
            this.dataGridViewDepositPaymentsHistory.Size = new System.Drawing.Size(519, 174);
            this.dataGridViewDepositPaymentsHistory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "История выплат";
            // 
            // DepositPaymentsHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDepositPaymentsHistory);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DepositPaymentsHistoryForm";
            this.Text = "История выплат";
            this.Load += new System.EventHandler(this.DepositPaymentsHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepositPaymentsHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDepositPaymentsHistory;
        private System.Windows.Forms.Label label1;
    }
}