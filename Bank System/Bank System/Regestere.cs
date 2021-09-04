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
    public partial class Regestere : Form
    {

        string ordb = "Data Source=ORCL;User Id=scott;Password=scott;";
        OracleConnection conn;
        

        public Regestere()
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            if (r_man.Checked)
            {
                cmd.CommandText = @"insert into MANAGER  (emp_id, F_NAME, L_NAME, GENDER, ADDRESS, E_MAIL, USERNAME, PASSWORD, salary)
                         Values (ACTID.nextval, :f_name, :l_name, :gender, :address, :e_mail, :username, :password, 20000)";
                label9.Visible = false;
                textBox2_MangerID.Visible = false;
            }
            else if (r_emp.Checked)
            {
                cmd.CommandText = @"insert into BANKER (man_id, emp_id, F_NAME,L_NAME, GENDER, ADDRESS, E_MAIL, USERNAME, PASSWORD, salary)
                         Values (:MANID, ACTID.nextval, :f_name, :l_name, :gender, :address, :e_mail, :username, :password, 10000)";
                label9.Visible = true;
                textBox2_MangerID.Visible = true;
            }

            if (r_emp.Checked)
                cmd.Parameters.Add("MANID", textBox2_MangerID.Text.ToString());
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("f_name", textBox_fristname.Text);
            cmd.Parameters.Add("l_name",  textBox_lastname.Text);
            cmd.Parameters.Add("gender", textBox_gender.Text);
            cmd.Parameters.Add("address", textBox_address.Text);
            cmd.Parameters.Add("e_mail", textBox_e_mail.Text);
            cmd.Parameters.Add("username", textBox_username.Text);


            if (textBox_password.Text.ToString().Equals(textBox_comfirmpassword.Text.ToString()))
            {
                cmd.Parameters.Add("password", textBox_password.Text.ToString());
                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("new  is added succesfully");
                }

            }
            else
            {
                textBox_password.Text = "";
                textBox_comfirmpassword.Text = "";
                MessageBox.Show("write comfirmpassword ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 F = new Form1();
            F.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void r_man_CheckedChanged(object sender, EventArgs e)
        {
            textBox2_MangerID.Visible = false;
            label9.Visible = false;
        }

        private void r_emp_CheckedChanged(object sender, EventArgs e)
        {
            textBox2_MangerID.Visible = true;
            label9.Visible = true;
        }

        private void Regestere_Load(object sender, EventArgs e)
        {

        }
    }
}
