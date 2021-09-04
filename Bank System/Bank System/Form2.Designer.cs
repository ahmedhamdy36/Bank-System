namespace Bank_System
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button_customerdata = new System.Windows.Forms.Button();
            this.button_creataccount = new System.Windows.Forms.Button();
            this.button_updateaccount = new System.Windows.Forms.Button();
            this.button_transaction = new System.Windows.Forms.Button();
            this.button_deleteacount = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_customerdata
            // 
            this.button_customerdata.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_customerdata.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_customerdata.Font = new System.Drawing.Font("Microsoft MHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_customerdata.ForeColor = System.Drawing.Color.Cyan;
            this.button_customerdata.Location = new System.Drawing.Point(332, 42);
            this.button_customerdata.Name = "button_customerdata";
            this.button_customerdata.Size = new System.Drawing.Size(317, 55);
            this.button_customerdata.TabIndex = 0;
            this.button_customerdata.Text = "CustomerData";
            this.button_customerdata.UseVisualStyleBackColor = false;
            this.button_customerdata.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_creataccount
            // 
            this.button_creataccount.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_creataccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_creataccount.Font = new System.Drawing.Font("Microsoft MHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_creataccount.ForeColor = System.Drawing.Color.Aqua;
            this.button_creataccount.Location = new System.Drawing.Point(332, 137);
            this.button_creataccount.Name = "button_creataccount";
            this.button_creataccount.Size = new System.Drawing.Size(317, 60);
            this.button_creataccount.TabIndex = 1;
            this.button_creataccount.Text = "CreateAccount";
            this.button_creataccount.UseVisualStyleBackColor = false;
            this.button_creataccount.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_updateaccount
            // 
            this.button_updateaccount.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_updateaccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_updateaccount.Font = new System.Drawing.Font("Microsoft MHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_updateaccount.ForeColor = System.Drawing.Color.Cyan;
            this.button_updateaccount.Location = new System.Drawing.Point(332, 228);
            this.button_updateaccount.Name = "button_updateaccount";
            this.button_updateaccount.Size = new System.Drawing.Size(317, 55);
            this.button_updateaccount.TabIndex = 2;
            this.button_updateaccount.Text = "UpdateAccount";
            this.button_updateaccount.UseVisualStyleBackColor = false;
            this.button_updateaccount.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_transaction
            // 
            this.button_transaction.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_transaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_transaction.Font = new System.Drawing.Font("Microsoft MHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_transaction.ForeColor = System.Drawing.Color.Cyan;
            this.button_transaction.Location = new System.Drawing.Point(332, 406);
            this.button_transaction.Name = "button_transaction";
            this.button_transaction.Size = new System.Drawing.Size(317, 61);
            this.button_transaction.TabIndex = 3;
            this.button_transaction.Text = "Transaction";
            this.button_transaction.UseVisualStyleBackColor = false;
            this.button_transaction.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_deleteacount
            // 
            this.button_deleteacount.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_deleteacount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_deleteacount.Font = new System.Drawing.Font("Microsoft MHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deleteacount.ForeColor = System.Drawing.Color.Cyan;
            this.button_deleteacount.Location = new System.Drawing.Point(332, 310);
            this.button_deleteacount.Name = "button_deleteacount";
            this.button_deleteacount.Size = new System.Drawing.Size(317, 57);
            this.button_deleteacount.TabIndex = 4;
            this.button_deleteacount.Text = "Delete Account";
            this.button_deleteacount.UseVisualStyleBackColor = false;
            this.button_deleteacount.Click += new System.EventHandler(this.button5_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_back.Font = new System.Drawing.Font("Microsoft MHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.ForeColor = System.Drawing.Color.Cyan;
            this.button_back.Location = new System.Drawing.Point(12, 521);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(150, 42);
            this.button_back.TabIndex = 5;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Cyan;
            this.button1.Location = new System.Drawing.Point(12, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 310);
            this.button1.TabIndex = 6;
            this.button1.Text = "Show Report ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(922, 575);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_deleteacount);
            this.Controls.Add(this.button_transaction);
            this.Controls.Add(this.button_updateaccount);
            this.Controls.Add(this.button_creataccount);
            this.Controls.Add(this.button_customerdata);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_customerdata;
        private System.Windows.Forms.Button button_creataccount;
        private System.Windows.Forms.Button button_updateaccount;
        private System.Windows.Forms.Button button_transaction;
        private System.Windows.Forms.Button button_deleteacount;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button1;
    }
}