using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Bank_System
{
    public partial class UpdateAccount : Form
    {
        string ordb = "Data Source=ORCL;User Id=scott;Password=scott;";
        OracleConnection conn;

        public UpdateAccount()
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 F = new Form2();
            F.Show();
        }

        private void UpdateAccount_Load(object sender, EventArgs e)
        {

        }

        private void button_updata_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "update account set balance=:balance, acc_type=:acc_type where ac_no=:ac_no";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("balance", textBox_balance.Text.ToString());
            cmd.Parameters.Add("acc_type", textBox6_accounttype.Text);
            cmd.Parameters.Add("ac_no", textBox_accountno.Text.ToString());
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("accout updating");
            }
        }
    }
}
