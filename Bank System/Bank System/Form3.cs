using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace Bank_System
{
    public partial class Form3 : Form
    {
        CrystalReport2 cr;
        CrystalReport3 cr1;
        public Form3()
        {
            InitializeComponent();
        }
   private void Form3_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport2();
            foreach (ParameterDiscreteValue v in cr.ParameterFields[0].DefaultValues)
            {
                comboBox1.Items.Add(v.Value);
            }
            cr1 = new CrystalReport3();
            foreach (ParameterDiscreteValue s in cr1.ParameterFields[0].DefaultValues)
            {
                comboBox2.Items.Add(s.Value);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cr.SetParameterValue(0, comboBox1.Text);
             crystalReportViewer1.ReportSource = cr; 
        
        }

     

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 F = new Form2();
            F.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cr1.SetParameterValue(0, comboBox2.Text);
            crystalReportViewer2.ReportSource = cr1;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {

        }
    }
}
