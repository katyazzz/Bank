﻿using System.Collections.Generic;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Klient_glav));
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
            this.btntransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(2)))));
            this.btntransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntransfer.FlatAppearance.BorderSize = 0;
            this.btntransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntransfer.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btntransfer.ForeColor = System.Drawing.Color.White;
            this.btntransfer.Location = new System.Drawing.Point(627, 249);
            this.btntransfer.Margin = new System.Windows.Forms.Padding(2);
            this.btntransfer.Name = "btntransfer";
            this.btntransfer.Size = new System.Drawing.Size(225, 42);
            this.btntransfer.TabIndex = 0;
            this.btntransfer.Text = "Выполнить перевод";
            this.btntransfer.UseVisualStyleBackColor = false;
            this.btntransfer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnhistoryPA
            // 
            this.btnhistoryPA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(2)))));
            this.btnhistoryPA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhistoryPA.FlatAppearance.BorderSize = 0;
            this.btnhistoryPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhistoryPA.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnhistoryPA.ForeColor = System.Drawing.Color.White;
            this.btnhistoryPA.Location = new System.Drawing.Point(627, 154);
            this.btnhistoryPA.Margin = new System.Windows.Forms.Padding(2);
            this.btnhistoryPA.Name = "btnhistoryPA";
            this.btnhistoryPA.Size = new System.Drawing.Size(225, 42);
            this.btnhistoryPA.TabIndex = 1;
            this.btnhistoryPA.Text = "История операций";
            this.btnhistoryPA.UseVisualStyleBackColor = false;
            this.btnhistoryPA.Click += new System.EventHandler(this.btnhistoryPA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(37, 111);
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
            this.label2.Location = new System.Drawing.Point(37, 294);
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
            this.label3.Location = new System.Drawing.Point(33, 464);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Кредиты";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(2)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(905, 17);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 30);
            this.button3.TabIndex = 8;
            this.button3.Text = "поменять пароль";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnfreeze
            // 
            this.btnfreeze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(2)))));
            this.btnfreeze.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfreeze.FlatAppearance.BorderSize = 0;
            this.btnfreeze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfreeze.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnfreeze.ForeColor = System.Drawing.Color.White;
            this.btnfreeze.Location = new System.Drawing.Point(627, 201);
            this.btnfreeze.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnfreeze.Name = "btnfreeze";
            this.btnfreeze.Size = new System.Drawing.Size(225, 42);
            this.btnfreeze.TabIndex = 9;
            this.btnfreeze.Text = "Заблокировать счет";
            this.btnfreeze.UseVisualStyleBackColor = false;
            this.btnfreeze.Click += new System.EventHandler(this.btnfreeze_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(38, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Здравствуйте!";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(2)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(905, 53);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(178, 30);
            this.button5.TabIndex = 11;
            this.button5.Text = "выйти";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnhistoryDeposit
            // 
            this.btnhistoryDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(2)))));
            this.btnhistoryDeposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhistoryDeposit.FlatAppearance.BorderSize = 0;
            this.btnhistoryDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhistoryDeposit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnhistoryDeposit.ForeColor = System.Drawing.Color.White;
            this.btnhistoryDeposit.Location = new System.Drawing.Point(627, 321);
            this.btnhistoryDeposit.Margin = new System.Windows.Forms.Padding(2);
            this.btnhistoryDeposit.Name = "btnhistoryDeposit";
            this.btnhistoryDeposit.Size = new System.Drawing.Size(254, 42);
            this.btnhistoryDeposit.TabIndex = 12;
            this.btnhistoryDeposit.Text = "История операций по вкладам";
            this.btnhistoryDeposit.UseVisualStyleBackColor = false;
            this.btnhistoryDeposit.Click += new System.EventHandler(this.btnhistoryDeposit_Click);
            // 
            // btnhistoryCredit
            // 
            this.btnhistoryCredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(2)))));
            this.btnhistoryCredit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhistoryCredit.FlatAppearance.BorderSize = 0;
            this.btnhistoryCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhistoryCredit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnhistoryCredit.ForeColor = System.Drawing.Color.White;
            this.btnhistoryCredit.Location = new System.Drawing.Point(627, 490);
            this.btnhistoryCredit.Margin = new System.Windows.Forms.Padding(2);
            this.btnhistoryCredit.Name = "btnhistoryCredit";
            this.btnhistoryCredit.Size = new System.Drawing.Size(254, 42);
            this.btnhistoryCredit.TabIndex = 13;
            this.btnhistoryCredit.Text = "История операций по кредитам";
            this.btnhistoryCredit.UseVisualStyleBackColor = false;
            this.btnhistoryCredit.Click += new System.EventHandler(this.btnhistoryCredit_Click);
            // 
            // tbFIOKlient
            // 
            this.tbFIOKlient.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFIOKlient.Location = new System.Drawing.Point(42, 62);
            this.tbFIOKlient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbFIOKlient.Name = "tbFIOKlient";
            this.tbFIOKlient.Size = new System.Drawing.Size(353, 23);
            this.tbFIOKlient.TabIndex = 14;
            // 
            // dataGridPA
            // 
            this.dataGridPA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPA.Location = new System.Drawing.Point(37, 154);
            this.dataGridPA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridPA.Name = "dataGridPA";
            this.dataGridPA.Size = new System.Drawing.Size(563, 137);
            this.dataGridPA.TabIndex = 15;
            // 
            // dataGridDep
            // 
            this.dataGridDep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDep.Location = new System.Drawing.Point(37, 321);
            this.dataGridDep.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridDep.Name = "dataGridDep";
            this.dataGridDep.Size = new System.Drawing.Size(563, 126);
            this.dataGridDep.TabIndex = 16;
            // 
            // dataGridCredit
            // 
            this.dataGridCredit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCredit.Location = new System.Drawing.Point(37, 490);
            this.dataGridCredit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridCredit.Name = "dataGridCredit";
            this.dataGridCredit.Size = new System.Drawing.Size(563, 105);
            this.dataGridCredit.TabIndex = 17;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(2)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(627, 102);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(42, 32);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // Klient_glav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1121, 652);
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
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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