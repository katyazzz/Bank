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
            this.txtspas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtnpas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.button8 = new System.Windows.Forms.Button();
            this.Connection = new System.Data.SqlClient.SqlConnection();
            this.ShowPerAc = new System.Data.SqlClient.SqlCommand();
            this.ShowVklad = new System.Data.SqlClient.SqlCommand();
            this.button9 = new System.Windows.Forms.Button();
            this.history_credit = new System.Windows.Forms.Button();
            this.ShowCredit = new System.Data.SqlClient.SqlCommand();
            this.history_trans = new System.Windows.Forms.Button();
            this.history_dep = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sotr_tb = new System.Windows.Forms.TextBox();
            this.post_tb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCredit)).BeginInit();
            this.SuspendLayout();
            // 
            // txtspas
            // 
            this.txtspas.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtspas.Location = new System.Drawing.Point(24, 39);
            this.txtspas.Margin = new System.Windows.Forms.Padding(2);
            this.txtspas.Name = "txtspas";
            this.txtspas.Size = new System.Drawing.Size(116, 24);
            this.txtspas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Серия паспорта";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(542, 27);
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
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(355, 27);
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
            this.txtnpas.Location = new System.Drawing.Point(168, 39);
            this.txtnpas.Margin = new System.Windows.Forms.Padding(2);
            this.txtnpas.Name = "txtnpas";
            this.txtnpas.Size = new System.Drawing.Size(116, 24);
            this.txtnpas.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(165, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Номер паспорта";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1190, 87);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridPA
            // 
            this.dataGridPA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPA.Location = new System.Drawing.Point(26, 191);
            this.dataGridPA.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridPA.Name = "dataGridPA";
            this.dataGridPA.RowHeadersWidth = 51;
            this.dataGridPA.RowTemplate.Height = 24;
            this.dataGridPA.Size = new System.Drawing.Size(630, 81);
            this.dataGridPA.TabIndex = 7;
            this.dataGridPA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Счета";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(24, 294);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Вклады";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(22, 414);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "Кредиты";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(86, 160);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 27);
            this.button3.TabIndex = 11;
            this.button3.Text = "открыть новый счет";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridDep
            // 
            this.dataGridDep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDep.Location = new System.Drawing.Point(26, 321);
            this.dataGridDep.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridDep.Name = "dataGridDep";
            this.dataGridDep.RowHeadersWidth = 51;
            this.dataGridDep.RowTemplate.Height = 24;
            this.dataGridDep.Size = new System.Drawing.Size(787, 71);
            this.dataGridDep.TabIndex = 12;
            // 
            // dataGridCredit
            // 
            this.dataGridCredit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCredit.Location = new System.Drawing.Point(24, 439);
            this.dataGridCredit.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridCredit.Name = "dataGridCredit";
            this.dataGridCredit.RowHeadersWidth = 51;
            this.dataGridCredit.RowTemplate.Height = 24;
            this.dataGridCredit.Size = new System.Drawing.Size(789, 95);
            this.dataGridCredit.TabIndex = 13;
            // 
            // new_dep
            // 
            this.new_dep.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.new_dep.Location = new System.Drawing.Point(86, 291);
            this.new_dep.Margin = new System.Windows.Forms.Padding(2);
            this.new_dep.Name = "new_dep";
            this.new_dep.Size = new System.Drawing.Size(172, 25);
            this.new_dep.TabIndex = 14;
            this.new_dep.Text = "открыть новый вклад";
            this.new_dep.UseVisualStyleBackColor = true;
            // 
            // new_credit
            // 
            this.new_credit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.new_credit.Location = new System.Drawing.Point(86, 408);
            this.new_credit.Margin = new System.Windows.Forms.Padding(2);
            this.new_credit.Name = "new_credit";
            this.new_credit.Size = new System.Drawing.Size(172, 25);
            this.new_credit.TabIndex = 15;
            this.new_credit.Text = "открыть новый кредит";
            this.new_credit.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(704, 185);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 27);
            this.button6.TabIndex = 16;
            this.button6.Text = "пополнение";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(704, 216);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(109, 27);
            this.button7.TabIndex = 17;
            this.button7.Text = "снятие";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(704, 247);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(109, 27);
            this.button8.TabIndex = 18;
            this.button8.Text = "перевод";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // Connection
            // 
            this.Connection.ConnectionString = "Data Source=DESKTOP-JGVCKUM\\SQLEXPRESS;Initial Catalog=BDBank;Integrated Security" +
    "=True;Pooling=False";
            this.Connection.FireInfoMessageEventOnUserErrors = false;
            // 
            // ShowPerAc
            // 
            this.ShowPerAc.CommandText = "SELECT AccountNumber, DateOfOpening, Balance, Stat, DateOfClosing\r\nFROM     dbo.G" +
    "etClientAccountsInfo(@PasSeries, @PasNumber) AS GetClientAccountsInfo_1";
            this.ShowPerAc.Connection = this.Connection;
            this.ShowPerAc.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PasSeries", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@PasNumber", System.Data.SqlDbType.Int)});
            // 
            // ShowVklad
            // 
            this.ShowVklad.CommandText = "SELECT ID_Deposit, StartDate, EndDate, Summa, Stat\r\nFROM     dbo.GetClientDeposit" +
    "s(@PasSeries, @PasNumber) AS GetClientDeposits_1";
            this.ShowVklad.Connection = this.Connection;
            this.ShowVklad.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PasSeries", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@PasNumber", System.Data.SqlDbType.Int)});
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(482, 161);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(174, 26);
            this.button9.TabIndex = 19;
            this.button9.Text = "заблокировать счет";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // history_credit
            // 
            this.history_credit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.history_credit.Location = new System.Drawing.Point(274, 408);
            this.history_credit.Margin = new System.Windows.Forms.Padding(2);
            this.history_credit.Name = "history_credit";
            this.history_credit.Size = new System.Drawing.Size(238, 26);
            this.history_credit.TabIndex = 20;
            this.history_credit.Text = "показать историю погашения";
            this.history_credit.UseVisualStyleBackColor = true;
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
            this.history_trans.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.history_trans.Location = new System.Drawing.Point(262, 161);
            this.history_trans.Margin = new System.Windows.Forms.Padding(2);
            this.history_trans.Name = "history_trans";
            this.history_trans.Size = new System.Drawing.Size(216, 26);
            this.history_trans.TabIndex = 21;
            this.history_trans.Text = "показать историю по счету";
            this.history_trans.UseVisualStyleBackColor = true;
            this.history_trans.Click += new System.EventHandler(this.button11_Click);
            // 
            // history_dep
            // 
            this.history_dep.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.history_dep.Location = new System.Drawing.Point(274, 291);
            this.history_dep.Margin = new System.Windows.Forms.Padding(2);
            this.history_dep.Name = "history_dep";
            this.history_dep.Size = new System.Drawing.Size(238, 25);
            this.history_dep.TabIndex = 22;
            this.history_dep.Text = "показать историю выплат";
            this.history_dep.UseVisualStyleBackColor = true;
            this.history_dep.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(704, 27);
            this.button13.Margin = new System.Windows.Forms.Padding(2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(154, 34);
            this.button13.TabIndex = 23;
            this.button13.Text = "создать сотрудника";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(21, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Клиент:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(87, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 23);
            this.textBox1.TabIndex = 25;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(971, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Сотрудник";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // sotr_tb
            // 
            this.sotr_tb.Location = new System.Drawing.Point(1050, 13);
            this.sotr_tb.Name = "sotr_tb";
            this.sotr_tb.Size = new System.Drawing.Size(100, 20);
            this.sotr_tb.TabIndex = 27;
            // 
            // post_tb
            // 
            this.post_tb.Location = new System.Drawing.Point(1050, 42);
            this.post_tb.Name = "post_tb";
            this.post_tb.Size = new System.Drawing.Size(100, 20);
            this.post_tb.TabIndex = 28;
            // 
            // Staff_glav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 620);
            this.Controls.Add(this.post_tb);
            this.Controls.Add(this.sotr_tb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.history_dep);
            this.Controls.Add(this.history_trans);
            this.Controls.Add(this.history_credit);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnpas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtspas);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Staff_glav";
            this.Text = "Главная(Сотрудник)";
            this.Load += new System.EventHandler(this.Staff_glav_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCredit)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
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
        private System.Windows.Forms.Button button8;
        private System.Data.SqlClient.SqlConnection Connection;
        private System.Data.SqlClient.SqlCommand ShowPerAc;
        private System.Data.SqlClient.SqlCommand ShowVklad;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button history_credit;
        private System.Data.SqlClient.SqlCommand ShowCredit;
        private System.Windows.Forms.Button history_trans;
        private System.Windows.Forms.Button history_dep;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sotr_tb;
        private System.Windows.Forms.TextBox post_tb;
    }
}