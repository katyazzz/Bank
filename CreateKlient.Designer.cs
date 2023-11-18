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
            this.txtid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bDBankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositPaymentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtfio
            // 
            this.txtfio.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtfio.Location = new System.Drawing.Point(63, 48);
            this.txtfio.Name = "txtfio";
            this.txtfio.Size = new System.Drawing.Size(230, 28);
            this.txtfio.TabIndex = 0;
            this.txtfio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(60, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фамилия Имя Отчество";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtspas
            // 
            this.txtspas.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtspas.Location = new System.Drawing.Point(63, 107);
            this.txtspas.Name = "txtspas";
            this.txtspas.Size = new System.Drawing.Size(230, 28);
            this.txtspas.TabIndex = 2;
            // 
            // txtnpas
            // 
            this.txtnpas.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtnpas.Location = new System.Drawing.Point(324, 107);
            this.txtnpas.Name = "txtnpas";
            this.txtnpas.Size = new System.Drawing.Size(204, 28);
            this.txtnpas.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(59, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Серия паспорта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(320, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Номер паспорта";
            // 
            // txtbd
            // 
            this.txtbd.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbd.Location = new System.Drawing.Point(63, 172);
            this.txtbd.Name = "txtbd";
            this.txtbd.Size = new System.Drawing.Size(200, 28);
            this.txtbd.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(60, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дата рождения";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtsex
            // 
            this.txtsex.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtsex.FormattingEnabled = true;
            this.txtsex.Location = new System.Drawing.Point(63, 236);
            this.txtsex.Name = "txtsex";
            this.txtsex.Size = new System.Drawing.Size(121, 28);
            this.txtsex.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(59, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Пол";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(63, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "создать";
            this.button1.UseVisualStyleBackColor = true;
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
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(634, 324);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 22);
            this.txtid.TabIndex = 11;
            // 
            // CreateKlient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtid);
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
        private System.Windows.Forms.TextBox txtid;
    }
}