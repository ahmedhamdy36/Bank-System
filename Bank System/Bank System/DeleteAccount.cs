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
    public partial class DeleteAccount : Form
    {
        string ordb = "Data Source=ORCL;User Id=scott;Password=scott;";
        OracleConnection conn;

        public DeleteAccount()
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

        private void DeleteAccount_Load(object sender, EventArgs e)
        {
         
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;

            cmd1.CommandText = "delete from ACCOUNT where AC_NO=:AC_NO";
            cmd1.CommandType = CommandType.Text;
            cmd1.Parameters.Add("AC_NO", textBox1_AccountNo.Text.ToString());
            int r = cmd1.ExecuteNonQuery();

            cmd.CommandText = "delete from CUSTOMER where PAN=:PAN";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("PAN", textBox_pan.Text.ToString());
            r = cmd.ExecuteNonQuery();

            if (r != -1)
            {
                MessageBox.Show("accout and coustomer were deleted");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
