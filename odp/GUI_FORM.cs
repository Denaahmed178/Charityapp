using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Charity;


namespace formproject
{
    public partial class GUI_FORM : Form
    {
        public GUI_FORM()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        

        }

        private void GUI_FORM_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel4.BorderStyle = BorderStyle.None;
            panel5.BorderStyle = BorderStyle.None;
            panel7.BorderStyle = BorderStyle.None;
            mainform h = new mainform();
            h.TopLevel = false;
            if (panel6.Controls.Count > 0)
                panel6.Controls.Clear();
            panel6.Controls.Add(h);
            h.BringToFront();
            h.Show();

        }

        private void panel4_Click(object sender, EventArgs e)
        {
            panel3.BorderStyle = BorderStyle.None;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel5.BorderStyle = BorderStyle.None;
            panel7.BorderStyle = BorderStyle.None;
            Form2 h = new Form2();
            h.TopLevel = false;
            if (panel6.Controls.Count > 0)
                panel6.Controls.Clear();
            panel6.Controls.Add(h);
            h.BringToFront();
            h.Show();

        }

        private void panel5_Click(object sender, EventArgs e)
        {
            panel3.BorderStyle = BorderStyle.None;
            panel4.BorderStyle = BorderStyle.None;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel7.BorderStyle = BorderStyle.None;
            Form3 h = new Form3();
            h.TopLevel = false;
            if (panel6.Controls.Count > 0)
                panel6.Controls.Clear();
            panel6.Controls.Add(h);
            h.BringToFront();
            h.Show();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            panel3.BorderStyle = BorderStyle.None;
            panel4.BorderStyle = BorderStyle.None;
            panel5.BorderStyle = BorderStyle.None;
            panel7.BorderStyle = BorderStyle.Fixed3D;
            Form1 h = new Form1();
            h.TopLevel = false;
            if (panel6.Controls.Count > 0)
                panel6.Controls.Clear();
            panel6.Controls.Add(h);
            h.BringToFront();
            h.Show();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
