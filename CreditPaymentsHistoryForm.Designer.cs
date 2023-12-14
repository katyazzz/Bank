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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCreditPaymentsHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCreditPaymentsHistory
            // 
            this.dataGridViewCreditPaymentsHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCreditPaymentsHistory.Location = new System.Drawing.Point(25, 114);
            this.dataGridViewCreditPaymentsHistory.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCreditPaymentsHistory.Name = "dataGridViewCreditPaymentsHistory";
            this.dataGridViewCreditPaymentsHistory.RowTemplate.Height = 24;
            this.dataGridViewCreditPaymentsHistory.Size = new System.Drawing.Size(648, 205);
            this.dataGridViewCreditPaymentsHistory.TabIndex = 0;
            this.dataGridViewCreditPaymentsHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCreditPaymentsHistory_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "История операций (кредиты)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Поиск по кредиту:";
            // 
            // CreditPaymentsHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(760, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCreditPaymentsHistory);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreditPaymentsHistoryForm";
            this.Text = "CreditPaymentsHistoryForm";
            this.Load += new System.EventHandler(this.CreditPaymentsHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCreditPaymentsHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCreditPaymentsHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}