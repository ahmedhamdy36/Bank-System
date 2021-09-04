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
    public partial class Form1 : Form
    {

        string ordb = "Data Source=ORCL;User Id=scott;Password=scott;";
        OracleConnection conn;

        public Form1()
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            Regestere reg = new Regestere();
            reg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Username and Password can't be null");
            }
            else
            {
                if (r_man.Checked)
                    cmd.CommandText = "select username,password from manager where username =:username and password=:password";
                else if (r_emp.Checked)
                    cmd.CommandText = "select username,password from banker where username =:username and password=:password";

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("username", textBox1.Text);
                cmd.Parameters.Add("password", textBox2.Text);
                OracleDataReader dr = cmd.ExecuteReader();

                if (!dr.Read())
                {
                    MessageBox.Show("Invalid Username or Password ");
                }
                else
                {
                    this.Visible = false;
                    Form2 reg = new Form2();
                    reg.Show();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_password_Click(object sender, EventArgs e)
        {

        }
    }
}
