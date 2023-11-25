using System.Collections.Generic;
using System.Windows.Forms;
using System;

namespace Bank
{
    partial class Klient_glav
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
            this.btntransfer = new System.Windows.Forms.Button();
            this.btnhistoryPA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnfreeze = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btnhistoryDeposit = new System.Windows.Forms.Button();
            this.btnhistoryCredit = new System.Windows.Forms.Button();
            this.tbFIOKlient = new System.Windows.Forms.TextBox();
            this.dataGridPA = new System.Windows.Forms.DataGridView();
            this.dataGridDep = new System.Windows.Forms.DataGridView();
            this.dataGridCredit = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCredit)).BeginInit();
            this.SuspendLayout();
            // 
            // btntransfer
            // 
            this.btntransfer.BackColor = System.Drawing.SystemColors.Info;
            this.btntransfer.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btntransfer.Location = new System.Drawing.Point(692, 220);
            this.btntransfer.Margin = new System.Windows.Forms.Padding(2);
            this.btntransfer.Name = "btntransfer";
            this.btntransfer.Size = new System.Drawing.Size(193, 28);
            this.btntransfer.TabIndex = 0;
            this.btntransfer.Text = "Выполнить перевод";
            this.btntransfer.UseVisualStyleBackColor = false;
            this.btntransfer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnhistoryPA
            // 
            this.btnhistoryPA.BackColor = System.Drawing.SystemColors.Info;
            this.btnhistoryPA.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnhistoryPA.Location = new System.Drawing.Point(692, 154);
            this.btnhistoryPA.Margin = new System.Windows.Forms.Padding(2);
            this.btnhistoryPA.Name = "btnhistoryPA";
            this.btnhistoryPA.Size = new System.Drawing.Size(193, 28);
            this.btnhistoryPA.TabIndex = 1;
            this.btnhistoryPA.Text = "История операций";
            this.btnhistoryPA.UseVisualStyleBackColor = false;
            this.btnhistoryPA.Click += new System.EventHandler(this.btnhistoryPA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Платежные счета";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(32, 294);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Вклады";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(28, 464);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Кредиты";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(810, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 30);
            this.button3.TabIndex = 8;
            this.button3.Text = "поменять пароль";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnfreeze
            // 
            this.btnfreeze.BackColor = System.Drawing.SystemColors.Info;
            this.btnfreeze.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnfreeze.Location = new System.Drawing.Point(692, 187);
            this.btnfreeze.Name = "btnfreeze";
            this.btnfreeze.Size = new System.Drawing.Size(193, 28);
            this.btnfreeze.TabIndex = 9;
            this.btnfreeze.Text = "заблокировать счет";
            this.btnfreeze.UseVisualStyleBackColor = false;
            this.btnfreeze.Click += new System.EventHandler(this.btnfreeze_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(33, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Здравствуйте!";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(810, 53);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 30);
            this.button5.TabIndex = 11;
            this.button5.Text = "выйти";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnhistoryDeposit
            // 
            this.btnhistoryDeposit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnhistoryDeposit.Location = new System.Drawing.Point(692, 321);
            this.btnhistoryDeposit.Margin = new System.Windows.Forms.Padding(2);
            this.btnhistoryDeposit.Name = "btnhistoryDeposit";
            this.btnhistoryDeposit.Size = new System.Drawing.Size(193, 28);
            this.btnhistoryDeposit.TabIndex = 12;
            this.btnhistoryDeposit.Text = "История операций";
            this.btnhistoryDeposit.UseVisualStyleBackColor = true;
            this.btnhistoryDeposit.Click += new System.EventHandler(this.btnhistoryDeposit_Click);
            // 
            // btnhistoryCredit
            // 
            this.btnhistoryCredit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnhistoryCredit.Location = new System.Drawing.Point(692, 490);
            this.btnhistoryCredit.Margin = new System.Windows.Forms.Padding(2);
            this.btnhistoryCredit.Name = "btnhistoryCredit";
            this.btnhistoryCredit.Size = new System.Drawing.Size(193, 28);
            this.btnhistoryCredit.TabIndex = 13;
            this.btnhistoryCredit.Text = "История операций";
            this.btnhistoryCredit.UseVisualStyleBackColor = true;
            // 
            // tbFIOKlient
            // 
            this.tbFIOKlient.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFIOKlient.Location = new System.Drawing.Point(36, 62);
            this.tbFIOKlient.Name = "tbFIOKlient";
            this.tbFIOKlient.Size = new System.Drawing.Size(303, 23);
            this.tbFIOKlient.TabIndex = 14;
            // 
            // dataGridPA
            // 
            this.dataGridPA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPA.Location = new System.Drawing.Point(32, 154);
            this.dataGridPA.Name = "dataGridPA";
            this.dataGridPA.Size = new System.Drawing.Size(640, 126);
            this.dataGridPA.TabIndex = 15;
            // 
            // dataGridDep
            // 
            this.dataGridDep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDep.Location = new System.Drawing.Point(32, 321);
            this.dataGridDep.Name = "dataGridDep";
            this.dataGridDep.Size = new System.Drawing.Size(640, 126);
            this.dataGridDep.TabIndex = 16;
            // 
            // dataGridCredit
            // 
            this.dataGridCredit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCredit.Location = new System.Drawing.Point(32, 490);
            this.dataGridCredit.Name = "dataGridCredit";
            this.dataGridCredit.Size = new System.Drawing.Size(640, 105);
            this.dataGridCredit.TabIndex = 17;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Info;
            this.btnRefresh.Location = new System.Drawing.Point(597, 95);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(117, 23);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "обновление";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // Klient_glav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 652);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridCredit);
            this.Controls.Add(this.dataGridDep);
            this.Controls.Add(this.dataGridPA);
            this.Controls.Add(this.tbFIOKlient);
            this.Controls.Add(this.btnhistoryCredit);
            this.Controls.Add(this.btnhistoryDeposit);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnfreeze);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnhistoryPA);
            this.Controls.Add(this.btntransfer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Klient_glav";
            this.Text = "Главная (Клиент)";
            this.Load += new System.EventHandler(this.Klient_glav_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCredit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntransfer;
        private System.Windows.Forms.Button btnhistoryPA;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button3;
        private Button btnfreeze;
        private Label label4;
        private Button button5;
        private Button btnhistoryDeposit;
        private Button btnhistoryCredit;
        private TextBox tbFIOKlient;
        private DataGridView dataGridPA;
        private DataGridView dataGridDep;
        private DataGridView dataGridCredit;
        private Button btnRefresh;
    }
}