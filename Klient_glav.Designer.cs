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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listPersonalAccounts = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listVklad = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listKredit = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(195, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(420, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выполнить перевод";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(195, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(420, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "История операций";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listPersonalAccounts
            // 
            this.listPersonalAccounts.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listPersonalAccounts.FormattingEnabled = true;
            this.listPersonalAccounts.ItemHeight = 25;
            this.listPersonalAccounts.Location = new System.Drawing.Point(75, 66);
            this.listPersonalAccounts.Name = "listPersonalAccounts";
            this.listPersonalAccounts.Size = new System.Drawing.Size(681, 79);
            this.listPersonalAccounts.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(75, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Платежные счета";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listVklad
            // 
            this.listVklad.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listVklad.FormattingEnabled = true;
            this.listVklad.ItemHeight = 16;
            this.listVklad.Location = new System.Drawing.Point(75, 181);
            this.listVklad.Name = "listVklad";
            this.listVklad.Size = new System.Drawing.Size(681, 84);
            this.listVklad.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(75, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Вклады:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(75, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Кредиты:";
            // 
            // listKredit
            // 
            this.listKredit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listKredit.FormattingEnabled = true;
            this.listKredit.ItemHeight = 25;
            this.listKredit.Location = new System.Drawing.Point(75, 299);
            this.listKredit.Name = "listKredit";
            this.listKredit.Size = new System.Drawing.Size(681, 79);
            this.listKredit.TabIndex = 7;
            // 
            // Klient_glav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 541);
            this.Controls.Add(this.listKredit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listVklad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listPersonalAccounts);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Klient_glav";
            this.Text = "Klient_glav";
            this.Load += new System.EventHandler(this.Klient_glav_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listPersonalAccounts;
        private Label label1;
        private ListBox listVklad;
        private Label label2;
        private Label label3;
        private ListBox listKredit;
    }
}