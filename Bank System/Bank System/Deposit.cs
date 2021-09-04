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
    public partial class Deposit : Form
    {
        string ordb = "Data Source=ORCL;User Id=scott;Password=scott;";
        OracleConnection conn;

        public Deposit()
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Transaction F = new Transaction();
            F.Show();
        }

        private void Deposit_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_deposit_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;

            cmd.CommandText = "select balance from account where ac_no =:ac_no";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("ac_no", textBox_accountnumber.Text.ToString());
            string newBalance = null;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                newBalance = dr[0].ToString();
            }
            dr.Close();
            cmd.ExecuteNonQuery();

            int Bal = Int32.Parse(newBalance) + Int32.Parse(textBox_depositamount.Text.ToString());
            newBalance = Bal.ToString();

            cmd1.CommandText = "update account set balance=:balance where ac_no=:ac_no";
            cmd1.CommandType = CommandType.Text;
            cmd1.Parameters.Add("balance", newBalance);
            cmd1.Parameters.Add("ac_no", textBox_accountnumber.Text.ToString());
            int r = cmd1.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("accout updating");
            }
        }
    }
}
