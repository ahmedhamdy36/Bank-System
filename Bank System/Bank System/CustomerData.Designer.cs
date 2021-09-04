namespace Bank_System
{
    partial class CustomerData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerData));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_customerpan = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft MHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(21, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer PAN";
            // 
            // textBox_customerpan
            // 
            this.textBox_customerpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_customerpan.Location = new System.Drawing.Point(300, 58);
            this.textBox_customerpan.Multiline = true;
            this.textBox_customerpan.Name = "textBox_customerpan";
            this.textBox_customerpan.Size = new System.Drawing.Size(272, 20);
            this.textBox_customerpan.TabIndex = 1;
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_search.Cursor = System.Windows.Forms.Cursors.No;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_search.Font = new System.Drawing.Font("Microsoft MHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.ForeColor = System.Drawing.Color.Cyan;
            this.button_search.Location = new System.Drawing.Point(673, 58);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(128, 41);
            this.button_search.TabIndex = 2;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(819, 303);
            this.dataGridView1.TabIndex = 3;
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_back.Font = new System.Drawing.Font("Microsoft MHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.ForeColor = System.Drawing.Color.Cyan;
            this.button_back.Location = new System.Drawing.Point(12, 475);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(140, 42);
            this.button_back.TabIndex = 4;
            this.button_back.Text = "back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button2_Click);
            // 
            // CustomerData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(858, 529);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox_customerpan);
            this.Controls.Add(this.label1);
            this.Name = "CustomerData";
            this.Text = "CustomerData";
            this.Load += new System.EventHandler(this.CustomerData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_customerpan;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_back;
    }
}