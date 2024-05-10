using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            int n = View.Rows.Add();
            View.Rows[n].Cells[0].Value = name.Text;
            View.Rows[n].Cells[1].Value = email.Text;
            View.Rows[n].Cells[2].Value = phone.Text;
            View.Rows[n].Cells[3].Value = dob.Text;
        }

        private void dob_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
