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

namespace POS0
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\eric\Documents\pos.mdf;Integrated Security=True;Connect Timeout=30");


        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void userType(DataTable data)
        {
            if(data.Rows[0][1].ToString() == "1")
            {
                Transactions transaction = new Transactions();
                transaction.Show();
                this.Hide();
            }
            else if(data.Rows[0][1].ToString() == "2")
            {
                //admin
                admin admins = new admin();
                admins.Show();
                this.Hide();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
            }
            catch (Exception c)
            {
                Console.WriteLine(c.Message);
                Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\TESTDb.mdf;Integrated Security=True;Connect Timeout=30");
                Con.Open();
            }

            SqlDataAdapter sda = new SqlDataAdapter("select count(8),userType from [dbo].[user] where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Correct");
                userType(dt);
                Con.Close();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
            Con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
