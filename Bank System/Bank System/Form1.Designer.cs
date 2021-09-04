namespace Bank_System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.linkLabel_regester = new System.Windows.Forms.LinkLabel();
            this.groupBox_job = new System.Windows.Forms.GroupBox();
            this.r_emp = new System.Windows.Forms.RadioButton();
            this.r_man = new System.Windows.Forms.RadioButton();
            this.groupBox_job.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_username.Font = new System.Drawing.Font("Microsoft MHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.Color.Cyan;
            this.label_username.Location = new System.Drawing.Point(53, 92);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(150, 36);
            this.label_username.TabIndex = 0;
            this.label_username.Text = "User Name";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_password.Font = new System.Drawing.Font("Microsoft MHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.ForeColor = System.Drawing.Color.Cyan;
            this.label_password.Location = new System.Drawing.Point(59, 207);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(133, 38);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "Password";
            this.label_password.Click += new System.EventHandler(this.label_password_Click);
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_login.Font = new System.Drawing.Font("Microsoft MHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.Color.Cyan;
            this.button_login.Location = new System.Drawing.Point(200, 339);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(155, 45);
            this.button_login.TabIndex = 2;
            this.button_login.Text = "Log in";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_exit
            // 
            this.button_exit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_exit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_exit.Font = new System.Drawing.Font("Microsoft NeoGothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.ForeColor = System.Drawing.Color.Cyan;
            this.button_exit.Location = new System.Drawing.Point(729, 460);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(132, 42);
            this.button_exit.TabIndex = 3;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(304, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 26);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox2.Location = new System.Drawing.Point(304, 218);
            this.textBox2.MaxLength = 30;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(209, 24);
            this.textBox2.TabIndex = 5;
            // 
            // linkLabel_regester
            // 
            this.linkLabel_regester.ActiveLinkColor = System.Drawing.Color.Cyan;
            this.linkLabel_regester.AutoSize = true;
            this.linkLabel_regester.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.linkLabel_regester.DisabledLinkColor = System.Drawing.Color.Cyan;
            this.linkLabel_regester.Font = new System.Drawing.Font("Microsoft MHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_regester.ForeColor = System.Drawing.Color.Cyan;
            this.linkLabel_regester.LinkColor = System.Drawing.Color.Cyan;
            this.linkLabel_regester.Location = new System.Drawing.Point(749, 38);
            this.linkLabel_regester.Name = "linkLabel_regester";
            this.linkLabel_regester.Size = new System.Drawing.Size(97, 26);
            this.linkLabel_regester.TabIndex = 7;
            this.linkLabel_regester.TabStop = true;
            this.linkLabel_regester.Text = "Regestere";
            this.linkLabel_regester.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox_job
            // 
            this.groupBox_job.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox_job.Controls.Add(this.r_emp);
            this.groupBox_job.Controls.Add(this.r_man);
            this.groupBox_job.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox_job.Location = new System.Drawing.Point(46, 24);
            this.groupBox_job.Name = "groupBox_job";
            this.groupBox_job.Size = new System.Drawing.Size(467, 46);
            this.groupBox_job.TabIndex = 9;
            this.groupBox_job.TabStop = false;
            this.groupBox_job.Text = "Jop";
            // 
            // r_emp
            // 
            this.r_emp.AutoSize = true;
            this.r_emp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.r_emp.Checked = true;
            this.r_emp.Font = new System.Drawing.Font("Microsoft MHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_emp.ForeColor = System.Drawing.Color.Cyan;
            this.r_emp.Location = new System.Drawing.Point(376, 20);
            this.r_emp.Name = "r_emp";
            this.r_emp.Size = new System.Drawing.Size(85, 21);
            this.r_emp.TabIndex = 1;
            this.r_emp.TabStop = true;
            this.r_emp.Text = "Employee";
            this.r_emp.UseVisualStyleBackColor = false;
            // 
            // r_man
            // 
            this.r_man.AutoSize = true;
            this.r_man.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.r_man.Font = new System.Drawing.Font("Microsoft MHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_man.ForeColor = System.Drawing.Color.Cyan;
            this.r_man.Location = new System.Drawing.Point(23, 19);
            this.r_man.Name = "r_man";
            this.r_man.Size = new System.Drawing.Size(80, 21);
            this.r_man.TabIndex = 0;
            this.r_man.Text = "Manager";
            this.r_man.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(873, 507);
            this.Controls.Add(this.groupBox_job);
            this.Controls.Add(this.linkLabel_regester);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_job.ResumeLayout(false);
            this.groupBox_job.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.LinkLabel linkLabel_regester;
        private System.Windows.Forms.GroupBox groupBox_job;
        private System.Windows.Forms.RadioButton r_emp;
        private System.Windows.Forms.RadioButton r_man;
    }
}

