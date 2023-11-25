namespace Bank
{
    partial class CreateEmployeeForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsex = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnpas = new System.Windows.Forms.TextBox();
            this.txtspas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfio = new System.Windows.Forms.TextBox();
            this.txtpost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Staff_Creation = new System.Data.SqlClient.SqlCommand();
            this.Connection = new System.Data.SqlClient.SqlConnection();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(33, 308);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 28);
            this.button1.TabIndex = 21;
            this.button1.Text = "создать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(30, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Пол";
            // 
            // txtsex
            // 
            this.txtsex.AutoCompleteCustomSource.AddRange(new string[] {
            "м",
            "ж"});
            this.txtsex.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtsex.FormattingEnabled = true;
            this.txtsex.Location = new System.Drawing.Point(33, 211);
            this.txtsex.Margin = new System.Windows.Forms.Padding(2);
            this.txtsex.Name = "txtsex";
            this.txtsex.Size = new System.Drawing.Size(92, 25);
            this.txtsex.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(31, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Дата рождения";
            // 
            // txtbd
            // 
            this.txtbd.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbd.Location = new System.Drawing.Point(33, 159);
            this.txtbd.Margin = new System.Windows.Forms.Padding(2);
            this.txtbd.Name = "txtbd";
            this.txtbd.Size = new System.Drawing.Size(151, 24);
            this.txtbd.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(226, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Номер паспорта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Серия паспорта";
            // 
            // txtnpas
            // 
            this.txtnpas.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtnpas.Location = new System.Drawing.Point(229, 106);
            this.txtnpas.Margin = new System.Windows.Forms.Padding(2);
            this.txtnpas.Name = "txtnpas";
            this.txtnpas.Size = new System.Drawing.Size(154, 24);
            this.txtnpas.TabIndex = 14;
            // 
            // txtspas
            // 
            this.txtspas.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtspas.Location = new System.Drawing.Point(33, 106);
            this.txtspas.Margin = new System.Windows.Forms.Padding(2);
            this.txtspas.Name = "txtspas";
            this.txtspas.Size = new System.Drawing.Size(174, 24);
            this.txtspas.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Фамилия Имя Отчество";
            // 
            // txtfio
            // 
            this.txtfio.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtfio.Location = new System.Drawing.Point(33, 58);
            this.txtfio.Margin = new System.Windows.Forms.Padding(2);
            this.txtfio.Name = "txtfio";
            this.txtfio.Size = new System.Drawing.Size(174, 24);
            this.txtfio.TabIndex = 11;
            // 
            // txtpost
            // 
            this.txtpost.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtpost.Location = new System.Drawing.Point(33, 263);
            this.txtpost.Margin = new System.Windows.Forms.Padding(2);
            this.txtpost.Name = "txtpost";
            this.txtpost.Size = new System.Drawing.Size(174, 24);
            this.txtpost.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(30, 244);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Должность";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Staff_Creation
            // 
            this.Staff_Creation.CommandText = "CreateNewEmployee";
            this.Staff_Creation.CommandType = System.Data.CommandType.StoredProcedure;
            this.Staff_Creation.Connection = this.Connection;
            this.Staff_Creation.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PasSeries", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@PasNumber", System.Data.SqlDbType.Int, 6),
            new System.Data.SqlClient.SqlParameter("@FIO", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@BirthDay", System.Data.SqlDbType.Date),
            new System.Data.SqlClient.SqlParameter("@Sex", System.Data.SqlDbType.Char, 1),
            new System.Data.SqlClient.SqlParameter("@Post", System.Data.SqlDbType.VarChar)});
            // 
            // Connection
            // 
            this.Connection.ConnectionString = "Data Source=DESKTOP-JGVCKUM\\SQLEXPRESS;Initial Catalog=BDBank;Integrated Security" +
    "=True";
            this.Connection.FireInfoMessageEventOnUserErrors = false;
            // 
            // CreateEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtpost);
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
            this.Name = "CreateEmployeeForm";
            this.Text = "CreateEmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtsex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtbd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnpas;
        private System.Windows.Forms.TextBox txtspas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfio;
        private System.Windows.Forms.TextBox txtpost;
        private System.Windows.Forms.Label label6;
        private System.Data.SqlClient.SqlCommand Staff_Creation;
        private System.Data.SqlClient.SqlConnection Connection;
    }
}