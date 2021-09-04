using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 F = new Form1();
            F.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CustomerData F = new CustomerData();
            F.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CreateAccount F = new CreateAccount();
            F.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UpdateAccount F = new UpdateAccount();
            F.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DeleteAccount F = new DeleteAccount();
            F.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Transaction F = new Transaction();
            F.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 F = new Form3();
            F.Show();
        }
    }
}
