﻿namespace Bank
{
    partial class TypeOfDeposits
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bDBankDataSet1 = new Bank.BDBankDataSet1();
            this.typeOfDepositsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeOfDepositsTableAdapter = new Bank.BDBankDataSet1TableAdapters.TypeOfDepositsTableAdapter();
            this.depositCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interestRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDBankDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfDepositsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Виды вкладов";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.depositCodeDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.conditionsDataGridViewTextBoxColumn,
            this.termDataGridViewTextBoxColumn,
            this.interestRateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.typeOfDepositsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // bDBankDataSet1
            // 
            this.bDBankDataSet1.DataSetName = "BDBankDataSet1";
            this.bDBankDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeOfDepositsBindingSource
            // 
            this.typeOfDepositsBindingSource.DataMember = "TypeOfDeposits";
            this.typeOfDepositsBindingSource.DataSource = this.bDBankDataSet1;
            // 
            // typeOfDepositsTableAdapter
            // 
            this.typeOfDepositsTableAdapter.ClearBeforeFill = true;
            // 
            // depositCodeDataGridViewTextBoxColumn
            // 
            this.depositCodeDataGridViewTextBoxColumn.DataPropertyName = "DepositCode";
            this.depositCodeDataGridViewTextBoxColumn.HeaderText = "DepositCode";
            this.depositCodeDataGridViewTextBoxColumn.Name = "depositCodeDataGridViewTextBoxColumn";
            this.depositCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conditionsDataGridViewTextBoxColumn
            // 
            this.conditionsDataGridViewTextBoxColumn.DataPropertyName = "Conditions";
            this.conditionsDataGridViewTextBoxColumn.HeaderText = "Conditions";
            this.conditionsDataGridViewTextBoxColumn.Name = "conditionsDataGridViewTextBoxColumn";
            this.conditionsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // termDataGridViewTextBoxColumn
            // 
            this.termDataGridViewTextBoxColumn.DataPropertyName = "Term";
            this.termDataGridViewTextBoxColumn.HeaderText = "Term";
            this.termDataGridViewTextBoxColumn.Name = "termDataGridViewTextBoxColumn";
            this.termDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // interestRateDataGridViewTextBoxColumn
            // 
            this.interestRateDataGridViewTextBoxColumn.DataPropertyName = "InterestRate";
            this.interestRateDataGridViewTextBoxColumn.HeaderText = "InterestRate";
            this.interestRateDataGridViewTextBoxColumn.Name = "interestRateDataGridViewTextBoxColumn";
            this.interestRateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // TypeOfDeposits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(700, 269);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "TypeOfDeposits";
            this.Text = "TypeOfDeposits";
            this.Load += new System.EventHandler(this.TypeOfDeposits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDBankDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfDepositsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BDBankDataSet1 bDBankDataSet1;
        private System.Windows.Forms.BindingSource typeOfDepositsBindingSource;
        private BDBankDataSet1TableAdapters.TypeOfDepositsTableAdapter typeOfDepositsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn depositCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interestRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}