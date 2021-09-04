namespace Bank_System
{
    partial class Withdrawal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Withdrawal));
            this.button_withdrawal = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_widtharwal_amount = new System.Windows.Forms.TextBox();
            this.textBox_accountnumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_withdrawal
            // 
            this.button_withdrawal.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_withdrawal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_withdrawal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_withdrawal.ForeColor = System.Drawing.Color.Cyan;
            this.button_withdrawal.Location = new System.Drawing.Point(672, 426);
            this.button_withdrawal.Name = "button_withdrawal";
            this.button_withdrawal.Size = new System.Drawing.Size(169, 48);
            this.button_withdrawal.TabIndex = 0;
            this.button_withdrawal.Text = "Withdrawal";
            this.button_withdrawal.UseVisualStyleBackColor = false;
            this.button_withdrawal.Click += new System.EventHandler(this.button_withdrawal_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.ForeColor = System.Drawing.Color.Cyan;
            this.button_back.Location = new System.Drawing.Point(12, 490);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(152, 41);
            this.button_back.TabIndex = 1;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(103, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 29);
            this.label4.TabIndex = 36;
            this.label4.Text = "Withdrawal Amount";
            // 
            // text_widtharwal_amount
            // 
            this.text_widtharwal_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_widtharwal_amount.Location = new System.Drawing.Point(392, 262);
            this.text_widtharwal_amount.Name = "text_widtharwal_amount";
            this.text_widtharwal_amount.Size = new System.Drawing.Size(246, 22);
            this.text_widtharwal_amount.TabIndex = 37;
            this.text_widtharwal_amount.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox_accountnumber
            // 
            this.textBox_accountnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_accountnumber.Location = new System.Drawing.Point(392, 124);
            this.textBox_accountnumber.Name = "textBox_accountnumber";
            this.textBox_accountnumber.Size = new System.Drawing.Size(246, 22);
            this.textBox_accountnumber.TabIndex = 31;
            this.textBox_accountnumber.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(103, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Account Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Withdrawal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(888, 543);
            this.Controls.Add(this.text_widtharwal_amount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_accountnumber);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_withdrawal);
            this.Name = "Withdrawal";
            this.Text = "Withdrawal";
            this.Load += new System.EventHandler(this.Withdrawal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_withdrawal;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_widtharwal_amount;
        private System.Windows.Forms.TextBox textBox_accountnumber;
        private System.Windows.Forms.Label label1;
    }
}