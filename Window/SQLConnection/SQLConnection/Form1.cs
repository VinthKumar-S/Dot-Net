using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLConnection
{
    public partial class Form1 : Form
    {
        string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Documents\PDF(for all)\4 Year\Sem 2\Dot Net Lab\SQLConnection\SQLConnection\Database1.mdf"";Integrated Security=True";
        SqlConnection con = new SqlConnection();
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                con.ConnectionString = str;

                con.Open();

                MessageBox.Show("Connected Succesfully");

            }

            catch (SqlException X)
            {

                MessageBox.Show("Failed" + X.Message);

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.ConnectionString = str;

            con.Open();
            
            SqlCommand cmd = new SqlCommand("Insert into details (id,name) values('"+textBox4.Text+"','" + textBox1.Text + "')", con);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Insert Data Succesfully");


            con.Close();
        }
    }
}
