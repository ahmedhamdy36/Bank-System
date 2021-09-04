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
    public partial class CustomerData : Form
    {

        public CustomerData()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 F = new Form2();
            F.Show();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string constr = "User Id=scott;Password=scott;Data Source=orcl";
            string cmdstr = @"select name, e_mail, address, gender from CUSTOMER where pan =:pan";

            OracleDataAdapter adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("pan", textBox_customerpan.Text);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            
        }

        private void CustomerData_Load(object sender, EventArgs e)
        {

        }
    }
}
