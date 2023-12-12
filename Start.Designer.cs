namespace Bank
{
    partial class Start
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKlient = new System.Windows.Forms.Button();
            this.buttonSotr = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(158, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать!";
            // 
            // buttonKlient
            // 
            this.buttonKlient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(2)))));
            this.buttonKlient.FlatAppearance.BorderSize = 0;
            this.buttonKlient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKlient.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonKlient.Location = new System.Drawing.Point(163, 156);
            this.buttonKlient.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKlient.Name = "buttonKlient";
            this.buttonKlient.Size = new System.Drawing.Size(170, 33);
            this.buttonKlient.TabIndex = 1;
            this.buttonKlient.Text = "Клиент";
            this.buttonKlient.UseVisualStyleBackColor = false;
            this.buttonKlient.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSotr
            // 
            this.buttonSotr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(2)))));
            this.buttonSotr.FlatAppearance.BorderSize = 0;
            this.buttonSotr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSotr.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSotr.Location = new System.Drawing.Point(163, 202);
            this.buttonSotr.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSotr.Name = "buttonSotr";
            this.buttonSotr.Size = new System.Drawing.Size(170, 33);
            this.buttonSotr.TabIndex = 2;
            this.buttonSotr.Text = "Сотрудник";
            this.buttonSotr.UseVisualStyleBackColor = false;
            this.buttonSotr.Click += new System.EventHandler(this.buttonSotr_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(159, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Войти как:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(551, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSotr);
            this.Controls.Add(this.buttonKlient);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Start";
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKlient;
        private System.Windows.Forms.Button buttonSotr;
        private System.Windows.Forms.Label label2;
    }
}