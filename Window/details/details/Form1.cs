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

namespace details
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
            SqlCommand cmd = new SqlCommand("insert into details values ('" + textBox1.Text + "','" + textBox2.Text + "', '" + textBox3.Text + "','" + textBox4.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("values inserted");
            con.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\PDF(for all)\4 Year\Sem 2\Dot Net Lab\details\details\Database1.mdf;Integrated Security=True";
                con.ConnectionString = str;
                con.Open();
                MessageBox.Show("connection succesfull");
            }
            catch (SqlException x)
            {
                MessageBox.Show("connection failed" + x.Message);



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update details set PHNNO='" + textBox2.Text + "', ADDRESS ='" + textBox3.Text + "',GENDER='" + textBox4.Text +  "' where CUSNAME='" + textBox1.Text + "'", con);

            con.Open();

            cmd.ExecuteNonQuery();

            MessageBox.Show("values updated");

            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(" delete from details where CUSNAME='" + textBox1.Text + "'", con);

            cmd.ExecuteNonQuery();

            MessageBox.Show("values has been deleted");

            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text  = "";
        }
    }
}
