namespace Bank
{
    partial class DebFromAccountForm
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
            this.btnDebFromAccount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmountDeb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDebFromAccount
            // 
            this.btnDebFromAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(2)))));
            this.btnDebFromAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebFromAccount.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDebFromAccount.Location = new System.Drawing.Point(72, 120);
            this.btnDebFromAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDebFromAccount.Name = "btnDebFromAccount";
            this.btnDebFromAccount.Size = new System.Drawing.Size(122, 26);
            this.btnDebFromAccount.TabIndex = 0;
            this.btnDebFromAccount.Text = "подтвердить";
            this.btnDebFromAccount.UseVisualStyleBackColor = false;
            this.btnDebFromAccount.Click += new System.EventHandler(this.btnDebFromAccount_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(48, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите сумму для списания";
            // 
            // txtAmountDeb
            // 
            this.txtAmountDeb.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAmountDeb.Location = new System.Drawing.Point(50, 76);
            this.txtAmountDeb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAmountDeb.Name = "txtAmountDeb";
            this.txtAmountDeb.Size = new System.Drawing.Size(170, 26);
            this.txtAmountDeb.TabIndex = 2;
            // 
            // DebFromAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(333, 206);
            this.Controls.Add(this.txtAmountDeb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDebFromAccount);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DebFromAccountForm";
            this.Text = "DebFromAccountForm";
            this.Load += new System.EventHandler(this.DebFromAccountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDebFromAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmountDeb;
    }
}