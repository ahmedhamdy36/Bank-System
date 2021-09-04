namespace Bank_System
{
    partial class Deposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposit));
            this.textBox_depositamount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_accountnumber = new System.Windows.Forms.TextBox();
            this.button_deposit = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_depositamount
            // 
            this.textBox_depositamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_depositamount.Location = new System.Drawing.Point(436, 305);
            this.textBox_depositamount.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_depositamount.Name = "textBox_depositamount";
            this.textBox_depositamount.Size = new System.Drawing.Size(308, 29);
            this.textBox_depositamount.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(125, 305);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 36);
            this.label4.TabIndex = 44;
            this.label4.Text = "Deposit Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(125, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 36);
            this.label1.TabIndex = 40;
            this.label1.Text = "Account Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_accountnumber
            // 
            this.textBox_accountnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_accountnumber.Location = new System.Drawing.Point(436, 175);
            this.textBox_accountnumber.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_accountnumber.Name = "textBox_accountnumber";
            this.textBox_accountnumber.Size = new System.Drawing.Size(308, 29);
            this.textBox_accountnumber.TabIndex = 39;
            this.textBox_accountnumber.UseSystemPasswordChar = true;
            // 
            // button_deposit
            // 
            this.button_deposit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_deposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deposit.ForeColor = System.Drawing.Color.Cyan;
            this.button_deposit.Location = new System.Drawing.Point(871, 519);
            this.button_deposit.Margin = new System.Windows.Forms.Padding(4);
            this.button_deposit.Name = "button_deposit";
            this.button_deposit.Size = new System.Drawing.Size(212, 66);
            this.button_deposit.TabIndex = 38;
            this.button_deposit.Text = "Deposit";
            this.button_deposit.UseVisualStyleBackColor = false;
            this.button_deposit.Click += new System.EventHandler(this.button_deposit_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.ForeColor = System.Drawing.Color.Cyan;
            this.button_back.Location = new System.Drawing.Point(16, 588);
            this.button_back.Margin = new System.Windows.Forms.Padding(4);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(185, 59);
            this.button_back.TabIndex = 46;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button2_Click);
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1173, 662);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.textBox_depositamount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_accountnumber);
            this.Controls.Add(this.button_deposit);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Deposit";
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.Deposit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_depositamount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_accountnumber;
        private System.Windows.Forms.Button button_deposit;
        private System.Windows.Forms.Button button_back;
    }
}