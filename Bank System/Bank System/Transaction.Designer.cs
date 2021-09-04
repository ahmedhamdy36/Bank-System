namespace Bank_System
{
    partial class Transaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaction));
            this.button_withdrawal = new System.Windows.Forms.Button();
            this.button_deposit = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_withdrawal
            // 
            this.button_withdrawal.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_withdrawal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_withdrawal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_withdrawal.ForeColor = System.Drawing.Color.Cyan;
            this.button_withdrawal.Location = new System.Drawing.Point(464, 133);
            this.button_withdrawal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_withdrawal.Name = "button_withdrawal";
            this.button_withdrawal.Size = new System.Drawing.Size(295, 69);
            this.button_withdrawal.TabIndex = 0;
            this.button_withdrawal.Text = "Withdrawal";
            this.button_withdrawal.UseVisualStyleBackColor = false;
            this.button_withdrawal.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_deposit
            // 
            this.button_deposit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_deposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deposit.ForeColor = System.Drawing.Color.Cyan;
            this.button_deposit.Location = new System.Drawing.Point(464, 347);
            this.button_deposit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_deposit.Name = "button_deposit";
            this.button_deposit.Size = new System.Drawing.Size(295, 73);
            this.button_deposit.TabIndex = 1;
            this.button_deposit.Text = "Deposit";
            this.button_deposit.UseVisualStyleBackColor = false;
            this.button_deposit.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.ForeColor = System.Drawing.Color.Cyan;
            this.button_back.Location = new System.Drawing.Point(16, 613);
            this.button_back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(188, 49);
            this.button_back.TabIndex = 3;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button4_Click);
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1217, 677);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_deposit);
            this.Controls.Add(this.button_withdrawal);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Transaction";
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.Transaction_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_withdrawal;
        private System.Windows.Forms.Button button_deposit;
        private System.Windows.Forms.Button button_back;
    }
}