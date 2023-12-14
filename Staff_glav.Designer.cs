namespace Bank
{
    partial class Staff_glav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff_glav));
            this.txtspas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtnpas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridPA = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridDep = new System.Windows.Forms.DataGridView();
            this.dataGridCredit = new System.Windows.Forms.DataGridView();
            this.new_dep = new System.Windows.Forms.Button();
            this.new_credit = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.TransferMoneybtn = new System.Windows.Forms.Button();
            this.Connection = new System.Data.SqlClient.SqlConnection();
            this.ShowPerAc = new System.Data.SqlClient.SqlCommand();
            this.ShowVklad = new System.Data.SqlClient.SqlCommand();
            this.frozebtn = new System.Windows.Forms.Button();
            this.history_credit = new System.Windows.Forms.Button();
            this.ShowCredit = new System.Data.SqlClient.SqlCommand();
            this.history_trans = new System.Windows.Forms.Button();
            this.history_dep = new System.Windows.Forms.Button();
            this.CreateStaff = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sotr_tb = new System.Windows.Forms.TextBox();
            this.post_tb = new System.Windows.Forms.TextBox();
            this.closebtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.typeDep = new System.Windows.Forms.Button();
            this.typeKre = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtboxPhone = new System.Windows.Forms.TextBox();
            this.txtBoxMail = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtStaffMail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtStaffPhone = new System.Windows.Forms.TextBox();
            this.btnSaveStaffInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCredit)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtspas
            // 
            this.txtspas.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtspas.Location = new System.Drawing.Point(11, 39);
            this.txtspas.Margin = new System.Windows.Forms.Padding(2);
            this.txtspas.Name = "txtspas";
            this.txtspas.Size = new System.Drawing.Size(116, 24);
            this.txtspas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FloralWhite;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Серия паспорта";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(2)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(567, 24);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "создать клиента";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(2)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(380, 24);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "показать информацию";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtnpas
            // 
            this.txtnpas.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtnpas.Location = new System.Drawing.Point(167, 39);
            this.txtnpas.Margin = new System.Windows.Forms.Padding(2);
            this.txtnpas.Name = "txtnpas";
            this.txtnpas.Size = new System.Drawing.Size(116, 24);
            this.txtnpas.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FloralWhite;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(164, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Номер паспорта";
            // 
            // dataGridPA
            // 
            this.dataGridPA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPA.Location = new System.Drawing.Point(26, 191);
            this.dataGridPA.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridPA.Name = "dataGridPA";
            this.dataGridPA.RowHeadersWidth = 51;
            this.dataGridPA.RowTemplate.Height = 24;
            this.dataGridPA.Size = new System.Drawing.Size(787, 94);
            this.dataGridPA.TabIndex = 7;
            this.dataGridPA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Счета";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(24, 294);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Вклады";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(25, 443);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Кредиты";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(2)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(360, 160);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 27);
            this.button3.TabIndex = 11;
            this.button3.Text = "открыть новый счет";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridDep
            // 
            this.dataGridDep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDep.Location = new System.Drawing.Point(23, 323);
            this.dataGridDep.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridDep.Name = "dataGridDep";
            this.dataGridDep.RowHeadersWidth = 51;
            this.dataGridDep.RowTemplate.Height = 24;
            this.dataGridDep.Size = new System.Drawing.Size(787, 94);
            this.dataGridDep.TabIndex = 12;
            // 
            // dataGridCredit
            // 
            this.dataGridCredit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCredit.Location = new System.Drawing.Point(23, 476);
            this.dataGridCredit.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridCredit.Name = "dataGridCredit";
            this.dataGridCredit.RowHeadersWidth = 51;
            this.dataGridCredit.RowTemplate.Height = 24;
            this.dataGridCredit.Size = new System.Drawing.Size(789, 95);
            this.dataGridCredit.TabIndex = 13;
            // 
            // new_dep
            // 
            this.new_dep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(2)))));
            this.new_dep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.new_dep.FlatAppearance.BorderSize = 0;
            this.new_dep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_dep.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.new_dep.ForeColor = System.Drawing.Color.White;
            this.new_dep.Location = new System.Drawing.Point(360, 294);
            this.new_dep.Margin = new System.Windows.Forms.Padding(2);
            this.new_dep.Name = "new_dep";
            this.new_dep.Size = new System.Drawing.Size(174, 25);
            this.new_dep.TabIndex = 14;
            this.new_dep.Text = "открыть новый вклад";
            this.new_dep.UseVisualStyleBackColor = false;
            this.new_dep.Click += new System.EventHandler(this.new_dep_Click);
            // 
            // new_credit
            // 
            this.new_credit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(2)))));
            this.new_credit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.new_credit.FlatAppearance.BorderSize = 0;
            this.new_credit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_credit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.new_credit.ForeColor = System.Drawing.Color.White;
            this.new_credit.Location = new System.Drawing.Point(360, 437);
            this.new_credit.Margin = new System.Windows.Forms.Padding(2);
            this.new_credit.Name = "new_credit";
            this.new_credit.Size = new System.Drawing.Size(174, 25);
            this.new_credit.TabIndex = 15;
            this.new_credit.Text = "открыть новый кредит";
            this.new_credit.UseVisualStyleBackColor = false;
            this.new_credit.Click += new System.EventHandler(this.new_credit_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(2)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(827, 193);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(127, 27);
            this.button6.TabIndex = 16;
            this.button6.Text = "пополнение";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(2)))));
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(827, 224);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(127, 27);
            this.button7.TabIndex = 17;
            this.button7.Text = "снятие";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // TransferMoneybtn
            // 
            this.TransferMoneybtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(2)))));
            this.TransferMoneybtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransferMoneybtn.FlatAppearance.BorderSize = 0;
            this.TransferMoneybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransferMoneybtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransferMoneybtn.ForeColor = System.Drawing.Color.White;
            this.TransferMoneybtn.Location = new System.Drawing.Point(827, 255);
            this.TransferMoneybtn.Margin = new System.Windows.Forms.Padding(2);
            this.TransferMoneybtn.Name = "TransferMoneybtn";
            this.TransferMoneybtn.Size = new System.Drawing.Size(127, 27);
            this.TransferMoneybtn.TabIndex = 18;
            this.TransferMoneybtn.Text = "перевод";
            this.TransferMoneybtn.UseVisualStyleBackColor = false;
            this.TransferMoneybtn.Click += new System.EventHandler(this.TransferMoneybtn_Click);
            // 
            // Connection
            // 
            this.Connection.ConnectionString = "Data Source=DESKTOP-JGVCKUM\\SQLEXPRESS;Initial Catalog=BDBank;Integrated Security" +
    "=True;Pooling=False";
            this.Connection.FireInfoMessageEventOnUserErrors = false;
            // 
            // ShowPerAc
            // 
            this.ShowPerAc.CommandText = resources.GetString("ShowPerAc.CommandText");
            this.ShowPerAc.Connection = this.Connection;
            this.ShowPerAc.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PasSeries", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@PasNumber", System.Data.SqlDbType.Int)});
            // 
            // ShowVklad
            // 
            this.ShowVklad.CommandText = "SELECT        ID_Deposit, StartDate AS [Дата начала], EndDate AS [Дата окончания]" +
    ", Summa AS Сумма, Stat AS Статус\r\nFROM            dbo.GetClientDeposits(@PasSeri" +
    "es, @PasNumber) AS GetClientDeposits_1";
            this.ShowVklad.Connection = this.Connection;
            this.ShowVklad.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PasSeries", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@PasNumber", System.Data.SqlDbType.Int)});
            // 
            // frozebtn
            // 
            this.frozebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(2)))));
            this.frozebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frozebtn.FlatAppearance.BorderSize = 0;
            this.frozebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frozebtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.frozebtn.ForeColor = System.Drawing.Color.White;
            this.frozebtn.Location = new System.Drawing.Point(964, 209);
            this.frozebtn.Margin = new System.Windows.Forms.Padding(2);
            this.frozebtn.Name = "frozebtn";
            this.frozebtn.Size = new System.Drawing.Size(157, 26);
            this.frozebtn.TabIndex = 19;
            this.frozebtn.Text = "заблокировать счет";
            this.frozebtn.UseVisualStyleBackColor = false;
            this.frozebtn.Click += new System.EventHandler(this.button9_Click);
            // 
            // history_credit
            // 
            this.history_credit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(2)))));
            this.history_credit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.history_credit.FlatAppearance.BorderSize = 0;
            this.history_credit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.history_credit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.history_credit.ForeColor = System.Drawing.Color.White;
            this.history_credit.Location = new System.Drawing.Point(106, 437);
            this.history_credit.Margin = new System.Windows.Forms.Padding(2);
            this.history_credit.Name = "history_credit";
            this.history_credit.Size = new System.Drawing.Size(240, 26);
            this.history_credit.TabIndex = 20;
            this.history_credit.Text = "показать историю погашения";
            this.history_credit.UseVisualStyleBackColor = false;
            this.history_credit.Click += new System.EventHandler(this.history_credit_Click);
            // 
            // ShowCredit
            // 
            this.ShowCredit.CommandText = "SELECT [Дата начала], [Дата окончания], Сумма, Название, Условия, Срок\r\nFROM     " +
    "dbo.GetCreditInfoForClient(@PasSeries, @PasNumber) AS GetCreditInfoForClient_1";
            this.ShowCredit.Connection = this.Connection;
            this.ShowCredit.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PasSeries", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@PasNumber", System.Data.SqlDbType.Int)});
            // 
            // history_trans
            // 
            this.history_trans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(2)))));
            this.history_trans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.history_trans.FlatAppearance.BorderSize = 0;
            this.history_trans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.history_trans.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.history_trans.ForeColor = System.Drawing.Color.White;
            this.history_trans.Location = new System.Drawing.Point(106, 160);
            this.history_trans.Margin = new System.Windows.Forms.Padding(2);
            this.history_trans.Name = "history_trans";
            this.history_trans.Size = new System.Drawing.Size(218, 26);
            this.history_trans.TabIndex = 21;
            this.history_trans.Text = "показать историю по счету";
            this.history_trans.UseVisualStyleBackColor = false;
            this.history_trans.Click += new System.EventHandler(this.button11_Click);
            // 
            // history_dep
            // 
            this.history_dep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(2)))));
            this.history_dep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.history_dep.FlatAppearance.BorderSize = 0;
            this.history_dep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.history_dep.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.history_dep.ForeColor = System.Drawing.Color.White;
            this.history_dep.Location = new System.Drawing.Point(106, 294);
            this.history_dep.Margin = new System.Windows.Forms.Padding(2);
            this.history_dep.Name = "history_dep";
            this.history_dep.Size = new System.Drawing.Size(240, 25);
            this.history_dep.TabIndex = 22;
            this.history_dep.Text = "показать историю выплат";
            this.history_dep.UseVisualStyleBackColor = false;
            this.history_dep.Click += new System.EventHandler(this.button12_Click);
            // 
            // CreateStaff
            // 
            this.CreateStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(2)))));
            this.CreateStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateStaff.FlatAppearance.BorderSize = 0;
            this.CreateStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateStaff.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateStaff.ForeColor = System.Drawing.Color.Transparent;
            this.CreateStaff.Location = new System.Drawing.Point(729, 24);
            this.CreateStaff.Margin = new System.Windows.Forms.Padding(2);
            this.CreateStaff.Name = "CreateStaff";
            this.CreateStaff.Size = new System.Drawing.Size(170, 34);
            this.CreateStaff.TabIndex = 23;
            this.CreateStaff.Text = "создать сотрудника";
            this.CreateStaff.UseVisualStyleBackColor = false;
            this.CreateStaff.Click += new System.EventHandler(this.button13_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(7, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Клиент:";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFIO.Location = new System.Drawing.Point(73, 20);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.ReadOnly = true;
            this.textBoxFIO.Size = new System.Drawing.Size(295, 23);
            this.textBoxFIO.TabIndex = 25;
            this.textBoxFIO.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FloralWhite;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(994, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Сотрудник";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // sotr_tb
            // 
            this.sotr_tb.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sotr_tb.Location = new System.Drawing.Point(1094, 9);
            this.sotr_tb.Name = "sotr_tb";
            this.sotr_tb.ReadOnly = true;
            this.sotr_tb.Size = new System.Drawing.Size(215, 26);
            this.sotr_tb.TabIndex = 27;
            this.sotr_tb.TextChanged += new System.EventHandler(this.sotr_tb_TextChanged);
            // 
            // post_tb
            // 
            this.post_tb.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.post_tb.Location = new System.Drawing.Point(1094, 37);
            this.post_tb.Name = "post_tb";
            this.post_tb.ReadOnly = true;
            this.post_tb.Size = new System.Drawing.Size(215, 26);
            this.post_tb.TabIndex = 28;
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(2)))));
            this.closebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebtn.FlatAppearance.BorderSize = 0;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.ForeColor = System.Drawing.Color.White;
            this.closebtn.Location = new System.Drawing.Point(562, 160);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(153, 26);
            this.closebtn.TabIndex = 29;
            this.closebtn.Text = "закрыть счет";
            this.closebtn.UseVisualStyleBackColor = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(2)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(964, 239);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(157, 26);
            this.button5.TabIndex = 30;
            this.button5.Text = "разблокировать счет";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(2)))));
            this.ChangePasswordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangePasswordButton.FlatAppearance.BorderSize = 0;
            this.ChangePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChangePasswordButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangePasswordButton.ForeColor = System.Drawing.Color.Black;
            this.ChangePasswordButton.Location = new System.Drawing.Point(1094, 70);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(134, 23);
            this.ChangePasswordButton.TabIndex = 31;
            this.ChangePasswordButton.Text = "сменить пароль";
            this.ChangePasswordButton.UseVisualStyleBackColor = false;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(2)))));
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.Black;
            this.ExitButton.Location = new System.Drawing.Point(1234, 70);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 32;
            this.ExitButton.Text = "выйти";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FloralWhite;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(994, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Должность";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtnpas);
            this.groupBox1.Controls.Add(this.txtspas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 81);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные Клиента";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(1075, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 23);
            this.label9.TabIndex = 6;
            // 
            // typeDep
            // 
            this.typeDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(2)))));
            this.typeDep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.typeDep.FlatAppearance.BorderSize = 0;
            this.typeDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typeDep.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeDep.ForeColor = System.Drawing.Color.White;
            this.typeDep.Location = new System.Drawing.Point(543, 294);
            this.typeDep.Margin = new System.Windows.Forms.Padding(2);
            this.typeDep.Name = "typeDep";
            this.typeDep.Size = new System.Drawing.Size(127, 26);
            this.typeDep.TabIndex = 35;
            this.typeDep.Text = "виды вкладов";
            this.typeDep.UseVisualStyleBackColor = false;
            this.typeDep.Click += new System.EventHandler(this.typeDep_Click);
            // 
            // typeKre
            // 
            this.typeKre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(2)))));
            this.typeKre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.typeKre.FlatAppearance.BorderSize = 0;
            this.typeKre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typeKre.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeKre.ForeColor = System.Drawing.Color.White;
            this.typeKre.Location = new System.Drawing.Point(543, 437);
            this.typeKre.Margin = new System.Windows.Forms.Padding(2);
            this.typeKre.Name = "typeKre";
            this.typeKre.Size = new System.Drawing.Size(127, 26);
            this.typeKre.TabIndex = 36;
            this.typeKre.Text = "виды кредитов";
            this.typeKre.UseVisualStyleBackColor = false;
            this.typeKre.Click += new System.EventHandler(this.typeKre_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(374, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 37;
            this.label10.Text = "Телефон";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(653, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 16);
            this.label11.TabIndex = 38;
            this.label11.Text = "Почта";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtboxPhone
            // 
            this.txtboxPhone.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtboxPhone.Location = new System.Drawing.Point(447, 20);
            this.txtboxPhone.Name = "txtboxPhone";
            this.txtboxPhone.Size = new System.Drawing.Size(200, 23);
            this.txtboxPhone.TabIndex = 39;
            // 
            // txtBoxMail
            // 
            this.txtBoxMail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxMail.Location = new System.Drawing.Point(706, 20);
            this.txtBoxMail.Name = "txtBoxMail";
            this.txtBoxMail.Size = new System.Drawing.Size(182, 23);
            this.txtBoxMail.TabIndex = 40;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtBoxMail);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtboxPhone);
            this.groupBox2.Controls.Add(this.textBoxFIO);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(23, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1010, 54);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Персональные данные";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(2)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(906, 20);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 23);
            this.btnUpdate.TabIndex = 41;
            this.btnUpdate.Text = "обновить";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(1054, 530);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 16);
            this.label12.TabIndex = 42;
            this.label12.Text = "Телефон";
            // 
            // txtStaffMail
            // 
            this.txtStaffMail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtStaffMail.Location = new System.Drawing.Point(1127, 556);
            this.txtStaffMail.Name = "txtStaffMail";
            this.txtStaffMail.Size = new System.Drawing.Size(182, 23);
            this.txtStaffMail.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(1074, 559);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 16);
            this.label13.TabIndex = 43;
            this.label13.Text = "Почта";
            // 
            // txtStaffPhone
            // 
            this.txtStaffPhone.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtStaffPhone.Location = new System.Drawing.Point(1127, 527);
            this.txtStaffPhone.Name = "txtStaffPhone";
            this.txtStaffPhone.Size = new System.Drawing.Size(182, 23);
            this.txtStaffPhone.TabIndex = 44;
            // 
            // btnSaveStaffInfo
            // 
            this.btnSaveStaffInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(2)))));
            this.btnSaveStaffInfo.FlatAppearance.BorderSize = 0;
            this.btnSaveStaffInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveStaffInfo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveStaffInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveStaffInfo.Location = new System.Drawing.Point(1218, 585);
            this.btnSaveStaffInfo.Name = "btnSaveStaffInfo";
            this.btnSaveStaffInfo.Size = new System.Drawing.Size(91, 23);
            this.btnSaveStaffInfo.TabIndex = 46;
            this.btnSaveStaffInfo.Text = "обновить";
            this.btnSaveStaffInfo.UseVisualStyleBackColor = false;
            this.btnSaveStaffInfo.Click += new System.EventHandler(this.btnSaveStaffInfo_Click);
            // 
            // Staff_glav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1340, 620);
            this.Controls.Add(this.btnSaveStaffInfo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtStaffMail);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.typeKre);
            this.Controls.Add(this.txtStaffPhone);
            this.Controls.Add(this.typeDep);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.post_tb);
            this.Controls.Add(this.sotr_tb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CreateStaff);
            this.Controls.Add(this.history_dep);
            this.Controls.Add(this.history_trans);
            this.Controls.Add(this.history_credit);
            this.Controls.Add(this.frozebtn);
            this.Controls.Add(this.TransferMoneybtn);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.new_credit);
            this.Controls.Add(this.new_dep);
            this.Controls.Add(this.dataGridCredit);
            this.Controls.Add(this.dataGridDep);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridPA);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Staff_glav";
            this.Text = "Главная(Сотрудник)";
            this.Load += new System.EventHandler(this.Staff_glav_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCredit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtspas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtnpas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridPA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridDep;
        private System.Windows.Forms.DataGridView dataGridCredit;
        private System.Windows.Forms.Button new_dep;
        private System.Windows.Forms.Button new_credit;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button TransferMoneybtn;
        private System.Data.SqlClient.SqlConnection Connection;
        private System.Data.SqlClient.SqlCommand ShowPerAc;
        private System.Data.SqlClient.SqlCommand ShowVklad;
        private System.Windows.Forms.Button frozebtn;
        private System.Windows.Forms.Button history_credit;
        private System.Data.SqlClient.SqlCommand ShowCredit;
        private System.Windows.Forms.Button history_trans;
        private System.Windows.Forms.Button history_dep;
        private System.Windows.Forms.Button CreateStaff;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sotr_tb;
        private System.Windows.Forms.TextBox post_tb;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button typeDep;
        private System.Windows.Forms.Button typeKre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtboxPhone;
        private System.Windows.Forms.TextBox txtBoxMail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtStaffMail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtStaffPhone;
        private System.Windows.Forms.Button btnSaveStaffInfo;
    }
}