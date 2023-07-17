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

namespace formproject
{
    public partial class Form3 : Form
    {
        static string ordb = "data source=orcl; user id=scott; password=tiger;";
        static OracleDataAdapter da;
        static OracleCommandBuilder build;
        static DataSet ds;

        public Form3()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cmdstr = "";
            if (textBox1.Text == "1")

            { cmdstr = "select * from staff "; }
            else if (textBox1.Text == "2")

            { cmdstr = "select * from charity_branches"; }

            da = new OracleDataAdapter(cmdstr, ordb);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

       

        private void button2_Click_1(object sender, EventArgs e)
        {
            build = new OracleCommandBuilder(da);
            da.Update(ds.Tables[0]);
            MessageBox.Show("the table is saved");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
