using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();

        public string str;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert into Tb1 (name,age) values('" + textBox1.Text + "','" + textBox2.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("values inserted");
            con.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\PDF(for all)\4 Year\Sem 2\Dot Net Lab\WindowsFormsApp4\WindowsFormsApp4\Database1.mdf;Integrated Security=True";
                con.ConnectionString = str;
                con.Open();
                MessageBox.Show("connection succesfull");
            }
            catch (SqlException x)
            {

                MessageBox.Show("connection failed" + x.Message);



            }
        }
    }
}
