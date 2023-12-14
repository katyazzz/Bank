namespace Bank
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDepositNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepositPaymentsHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDepositPaymentsHistory
            // 
            this.dataGridViewDepositPaymentsHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepositPaymentsHistory.Location = new System.Drawing.Point(41, 112);
            this.dataGridViewDepositPaymentsHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDepositPaymentsHistory.Name = "dataGridViewDepositPaymentsHistory";
            this.dataGridViewDepositPaymentsHistory.RowTemplate.Height = 24;
            this.dataGridViewDepositPaymentsHistory.Size = new System.Drawing.Size(628, 201);
            this.dataGridViewDepositPaymentsHistory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "История выплат";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(38, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Поиск по вкладу:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxDepositNumber
            // 
            this.textBoxDepositNumber.Location = new System.Drawing.Point(173, 75);
            this.textBoxDepositNumber.Name = "textBoxDepositNumber";
            this.textBoxDepositNumber.Size = new System.Drawing.Size(130, 21);
            this.textBoxDepositNumber.TabIndex = 5;
            this.textBoxDepositNumber.TextChanged += new System.EventHandler(this.textBoxDepositNumber_TextChanged);
            // 
            // DepositPaymentsHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(711, 366);
            this.Controls.Add(this.textBoxDepositNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDepositPaymentsHistory);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDepositNumber;
    }
}