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
    public partial class bill : Form
    {
        public bill()
        {
            InitializeComponent();
            populate();
            dateLabel.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\eric\Documents\pos.mdf;Integrated Security=True;Connect Timeout=30");



        // Variable
        int GrdTotal = 0, n = 0;

        //ADD BUTTON
        private void button9_Click(object sender, EventArgs e)
        {
            if (productName.Text == "" || productQuantity.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                int total = Convert.ToInt32(productPrice.Text) * Convert.ToInt32(productQuantity.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridView2);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = productName.Text;
                newRow.Cells[2].Value = productPrice.Text;
                newRow.Cells[3].Value = productQuantity.Text;
                newRow.Cells[4].Value = total;
                dataGridView2.Rows.Add(newRow);
                GrdTotal = GrdTotal + total;
                totalHarga.Text = "" + GrdTotal;
                n++;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            populate();
        }


        private void populatebills()
        {
            Con.Open();
            string query = "select * from transactionList";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BillsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (billID.Text == "")
            {
                MessageBox.Show("Missing Bill ID");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into transactionList values (" + billID.Text + ",'" + dateLabel.Text + "'," + totalHarga.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Added Successful");
                    Con.Close();
                    populatebills();
                    productName.Text = ""; 
                    productPrice.Text = ""; 
                    productQuantity.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("AMEL&EVESUPERMARKET", new Font("Times New Roman", 25, FontStyle.Bold), Brushes.Red, new Point(230));
           
        }
        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void populate()
        {
            Con.Open();
            string query = "select productName, price from products";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            productName.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            productPrice.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

        }

        private void Datelbl_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void productName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
