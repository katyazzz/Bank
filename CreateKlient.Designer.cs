namespace Bank
{
    partial class CreateKlient
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
            this.txtfio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtspas = new System.Windows.Forms.TextBox();
            this.txtnpas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsex = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bDBankDataSet = new Bank.BDBankDataSet();
            this.depositPaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depositPaymentTableAdapter = new Bank.BDBankDataSetTableAdapters.DepositPaymentTableAdapter();
            this.Connect = new System.Data.SqlClient.SqlConnection();
            this.Klient_Creation = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.bDBankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositPaymentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtfio
            // 
            this.txtfio.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtfio.Location = new System.Drawing.Point(47, 39);
            this.txtfio.Margin = new System.Windows.Forms.Padding(2);
            this.txtfio.Name = "txtfio";
            this.txtfio.Size = new System.Drawing.Size(174, 24);
            this.txtfio.TabIndex = 0;
            this.txtfio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(45, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фамилия Имя Отчество";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtspas
            // 
            this.txtspas.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtspas.Location = new System.Drawing.Point(47, 87);
            this.txtspas.Margin = new System.Windows.Forms.Padding(2);
            this.txtspas.Name = "txtspas";
            this.txtspas.Size = new System.Drawing.Size(174, 24);
            this.txtspas.TabIndex = 2;
            // 
            // txtnpas
            // 
            this.txtnpas.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtnpas.Location = new System.Drawing.Point(243, 87);
            this.txtnpas.Margin = new System.Windows.Forms.Padding(2);
            this.txtnpas.Name = "txtnpas";
            this.txtnpas.Size = new System.Drawing.Size(154, 24);
            this.txtnpas.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(44, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Серия паспорта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(240, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Номер паспорта";
            // 
            // txtbd
            // 
            this.txtbd.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbd.Location = new System.Drawing.Point(47, 140);
            this.txtbd.Margin = new System.Windows.Forms.Padding(2);
            this.txtbd.Name = "txtbd";
            this.txtbd.Size = new System.Drawing.Size(151, 24);
            this.txtbd.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(45, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дата рождения";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtsex
            // 
            this.txtsex.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtsex.FormattingEnabled = true;
            this.txtsex.Location = new System.Drawing.Point(47, 192);
            this.txtsex.Margin = new System.Windows.Forms.Padding(2);
            this.txtsex.Name = "txtsex";
            this.txtsex.Size = new System.Drawing.Size(92, 25);
            this.txtsex.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(44, 173);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Пол";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(2)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(47, 231);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "создать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bDBankDataSet
            // 
            this.bDBankDataSet.DataSetName = "BDBankDataSet";
            this.bDBankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // depositPaymentBindingSource
            // 
            this.depositPaymentBindingSource.DataMember = "DepositPayment";
            this.depositPaymentBindingSource.DataSource = this.bDBankDataSet;
            // 
            // depositPaymentTableAdapter
            // 
            this.depositPaymentTableAdapter.ClearBeforeFill = true;
            // 
            // Connect
            // 
            this.Connect.ConnectionString = "Data Source=DESKTOP-JGVCKUM\\SQLEXPRESS;Initial Catalog=BDBank;Integrated Security" +
    "=True;Pooling=False";
            this.Connect.FireInfoMessageEventOnUserErrors = false;
            // 
            // Klient_Creation
            // 
            this.Klient_Creation.CommandText = "NewKlient";
            this.Klient_Creation.CommandType = System.Data.CommandType.StoredProcedure;
            this.Klient_Creation.Connection = this.Connect;
            this.Klient_Creation.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PasSeries", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@PasNumber", System.Data.SqlDbType.Int, 6),
            new System.Data.SqlClient.SqlParameter("@FIO", System.Data.SqlDbType.VarChar, 100),
            new System.Data.SqlClient.SqlParameter("@bd", System.Data.SqlDbType.DateTime),
            new System.Data.SqlClient.SqlParameter("@sex", System.Data.SqlDbType.Char, 1)});
            // 
            // CreateKlient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnpas);
            this.Controls.Add(this.txtspas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfio);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateKlient";
            this.Text = "СозданиеКлиента";
            this.Load += new System.EventHandler(this.CreateKlient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDBankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositPaymentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtspas;
        private System.Windows.Forms.TextBox txtnpas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtbd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtsex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private BDBankDataSet bDBankDataSet;
        private System.Windows.Forms.BindingSource depositPaymentBindingSource;
        private BDBankDataSetTableAdapters.DepositPaymentTableAdapter depositPaymentTableAdapter;
        private System.Data.SqlClient.SqlConnection Connect;
        private System.Data.SqlClient.SqlCommand Klient_Creation;
    }
}