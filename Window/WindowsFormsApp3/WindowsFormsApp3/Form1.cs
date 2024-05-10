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
namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();
        public string str;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load_1(object sender, EventArgs e)

        {

            try

            {



                str = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =D:\Documents\PDF(for all)\4 Year\Sem 2\Dot Net Lab\WindowsFormsApp3\WindowsFormsApp3\Database1.mdf;Integrated Security = True";

                con.ConnectionString = str;

                con.Open();

                MessageBox.Show("connection succesfull");

            }

            catch (SqlException x)

            {

                MessageBox.Show("connection failed" + x.Message);



            }

        }





