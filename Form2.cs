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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\eric\Documents\pos.mdf;Integrated Security=True;Connect Timeout=30");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into [dbo].[products] values (" + textBox1.Text + ",'" + textBox2.Text + "'," + numericUpDown1.Text + "," + numericUpDown2.Text + ",'" + richTextBox1.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully");
                Con.Close();
                //populate();
                //richTextBox2.Text = ""; 
                //ProdNameTb.Text = ""; ProdPriceTb.Text = ""; ProdQtyTb.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'posDataSet.products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Fill(this.posDataSet.products);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update [dbo].[products] set productName='" + textBox2.Text + "', quantity=" + numericUpDown1.Text + ", price =" + numericUpDown2.Text + ", description= '" + richTextBox1.Text + "' where ID=" + textBox1.Text +"";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Product Updated Successfully");
            Con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bill billing = new bill();
            billing.Show();
            this.Close();
        }
    }
}
