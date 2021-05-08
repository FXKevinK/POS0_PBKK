using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POS0
{
    public partial class Login : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\eric\Documents\pos.mdf;Integrated Security=True;Connect Timeout=30");
        public Login()
        {
            InitializeComponent();
            try
            {
                Con.Open();
            }
            catch (Exception c)
            {
                Console.WriteLine(c.Message);
                Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\repos\POS0_PBKK\TESTDb.mdf;Integrated Security=True;Connect Timeout=30");
                Con.Open();
            }
            Con.Close();
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userType(DataTable data)
        {
            if (data.Rows[0][1].ToString() == "1")
            {
                Transactions transaction = new Transactions();
                transaction.Show();
                this.Hide();
            }
            else if (data.Rows[0][1].ToString() == "2")
            {
                //admin
                products product = new products();
                product.Show();
                this.Hide();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("select idUser , userType from [dbo].[user] where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (Convert.ToInt32(dt.Rows[0][0].ToString()) >= 1)
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
            catch (Exception f)
            {
                Console.WriteLine(f.Message);
                MessageBox.Show(f.Message);
            }
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
