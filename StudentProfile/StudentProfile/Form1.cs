using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentProfile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Hanna")
            {
                label1.Visible = true;
                label2.Visible = true;
            }
            else
            {
                label1.Visible=false;
                label2.Visible=false;

                MessageBox.Show("Student not found");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                label1.Visible = false;
                label2.Visible = false;
            }     
        }
    }
}
