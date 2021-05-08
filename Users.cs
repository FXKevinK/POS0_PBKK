﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POS0
{
    public partial class Users : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\repos\POS0_PBKK\TESTDb.mdf;Integrated Security=True;");
        public Users()
        {
            InitializeComponent();
            load();
            try
            {
                Con.Open();
                Con.Close();
            }
            catch (Exception e)
            {
                Con = new SqlConnection();
                // MessageBox.Show(e.Message);

            }
        }

        private void load()
        {
            Con.Open();
            string query = "select * from [dbo].[user]";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            Con.Close();

        }


        private void Users_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'posDataSetDataSet.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.posDataSetDataSet.user);

        }

        private void label3_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("HELLO THERE");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userID.Text = dataGridView1.SelectedRows[0].ToString();
                userName.Text = dataGridView1.SelectedRows[1].ToString();
                userPassword.Text = dataGridView1.SelectedRows[2].ToString();
                userEmail.Text = dataGridView1.SelectedRows[3].ToString();
                userTelp.Text = dataGridView1.SelectedRows[4].ToString();
                if (dataGridView1.SelectedRows[5].ToString() == "1")
                {
                    userType.Text = "admin";
                }
                else
                {
                    userType.Text = "kasir";
                }
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }

        }

        private void Add_Click(object sender, System.EventArgs e)
        {
            try
            {
                Con.Open();
                string query1 = "select Id from [dbo].[user] where username = '" + userName.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(query1, Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Con.Close();
                if (dt.Rows.Count == 0)
                {
                    Con.Open();
                    string query = "insert into [dbo].[user] ('username','password','email','notelp','usertype') value('" + userName.Text + "','" + userPassword.Text + "','" + userEmail.Text + "'" + userTelp.Text + "','" + userType.Text + "') ";
                    SqlCommand cmd = new SqlCommand(query, Con);

                    Con.Close();
                    MessageBox.Show("Produk berhasil dimasukan");
                }
                else
                {
                    MessageBox.Show("Data already in database, Please try again\n");
                }
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
            load();

        }

        private void Update_Click(object sender, System.EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "update [dbo].[user] set username='" + userName.Text +
                    "', password='" + userPassword.Text +
                    "', email='" + userEmail.Text +
                    "', notelp='" + userTelp.Text +
                    "', usertype='" + userType.Text +
                    " where Id='" + userID.Text +
                    "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                Con.Close();
                MessageBox.Show("Updating product complete");
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
            load();
        }

        private void Delete_Click(object sender, System.EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "delete from [dbo].[user] where Id = '" + userID.Text +
                    "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                Con.Close();
                MessageBox.Show("Delete data complete");

            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
            load();
        }

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "select * from [dbo].[user] where username = '" + userName.Text +
                    "'";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(query, Con);
                da.Fill(dt);

                userID.Text = dt.Rows[0][0].ToString();
                userPassword.Text = dt.Rows[0][2].ToString();
                userEmail.Text = dt.Rows[0][3].ToString();
                userTelp.Text = dt.Rows[0][4].ToString();
                if (dt.Rows[0][5].ToString() == "1")
                {
                    userType.Text = "admin";
                }
                else
                {
                    userType.Text = "kasir";
                }
                Con.Close();

            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }
    }
}
