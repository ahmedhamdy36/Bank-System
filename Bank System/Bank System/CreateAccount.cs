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
    public partial class CreateAccount : Form
    {
        string ordb = "Data Source=ORCL;User Id=scott;Password=scott;";
        OracleConnection conn;

        public CreateAccount()
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            InitializeComponent();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 F = new Form2();
            F.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;

            //cmd.CommandText = "GET_LAST_CUSTOMER";
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("id", OracleDbType.Int32,
            //   ParameterDirection.Output);
            cmd1.CommandText = @"insert into CUSTOMER  (CUST_ID, NAME, GENDER, ADDRESS, E_MAIL, PAN)
                         Values (ACTID.nextval,:name,:gender,:address,:e_mail,:PAN)";
            cmd1.CommandType = CommandType.Text;
            cmd1.Parameters.Add("name", textBox_name.Text);
            cmd1.Parameters.Add("gender", textBox_gender.Text);
            cmd1.Parameters.Add("address", textBox_address.Text);
            cmd1.Parameters.Add("e_mail", textBox_e_mail.Text);
            cmd1.Parameters.Add("PAN", textBox_pan.Text);
            cmd1.ExecuteNonQuery();




            cmd.CommandText = "select max(CUST_ID) from customer";
            cmd.CommandType = CommandType.Text;
  

            string VAR = null;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                VAR = dr[0].ToString();
            }
            dr.Close();
            cmd.ExecuteNonQuery();
           
            

           


            cmd2.CommandText = @"insert into ACCOUNT  (ac_no,balance, ACC_TYPE,CUST_ID)
                         Values (ACTID.nextval,:BALANCE,:TYPE,:CUST)";
            cmd2.CommandType = CommandType.Text;
            cmd2.Parameters.Add("BALANCE", textBox_balance.Text);
            cmd2.Parameters.Add("TYPE", textBox_accounttype.Text);
            cmd.Parameters.Add("DATE", DateTime.Now.ToString());
            cmd2.Parameters.Add("CUST", VAR);

            int r = cmd2.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("new  is account succesfully");
            }

        }
    }
}
