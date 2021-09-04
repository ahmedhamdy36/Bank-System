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
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 F = new Form2();
            F.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Withdrawal F = new Withdrawal();
            F.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Deposit F = new Deposit();
            F.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            //Transfer F = new Transfer();
            //F.Show();
        }

        private void Transaction_Load(object sender, EventArgs e)
        {

        }
    }
}
