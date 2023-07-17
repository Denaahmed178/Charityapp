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
namespace Charity
{
    public partial class Form1 : Form
    {
        CrystalReport1 cr;
        CrystalReport2 cr2;
        public Form1()
        {
            InitializeComponent();
        }
        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport1();
            cr2= new CrystalReport2();
            foreach (ParameterDiscreteValue v in cr.ParameterFields[0].DefaultValues)
                comboBox2.Items.Add(v.Value);

        }


        private void button2_Click(object sender, EventArgs e)
        {
            cr.SetParameterValue(0, comboBox2.Text);
            crystalReportViewer2.ReportSource = cr;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            cr2.SetParameterValue(0, comboBox2.Text);
            crystalReportViewer2.ReportSource = cr2;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
