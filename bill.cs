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
            TestConnection();
            populate();
            automateID();
            dateLabel.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\eric\Documents\pos.mdf;Integrated Security=True;Connect Timeout=30");

        private void automateID()
        {
            Con.Open();
            string query = "select max(BillID) from [dbo].[transactionList]";
            SqlCommand cmd = new SqlCommand(query, Con);
            int result = (int)(cmd.ExecuteScalar());
            result += 1;

            billID.Text = Convert.ToString(result);
            
            Con.Close();
        }

        private void TestConnection()
        {
            try
            {
                Con.Open();
                Con.Close();
            }
            catch
            {
                Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\repos\POS0_PBKK\posDataSet.mdf;Integrated Security=True;Connect Timeout=30");
                Con.Open();
                Con.Close();
            }
        }

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
            string query = "select * from [dbo].[transactionList]";
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
                    string query = "insert into transactionList(Date,TotalAmmount) values ('" + dateLabel.Text + "'," + totalHarga.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Added Successful");
                    Con.Close();
                    populatebills();
                    productName.Text = ""; 
                    productPrice.Text = ""; 
                    productQuantity.Text = "";
                    automateID();
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
            float height = 0;
            e.Graphics.DrawString("PBKK POS", new Font("Times New Roman", 25, FontStyle.Bold), Brushes.Black ,e.PageBounds.Width/2, height);
           
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
            string query = "select productName, price from [dbo].[products]";
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

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //draw here
            float height = 0;
            e.Graphics.DrawString("PBKK POS", new Font("Times New Roman", 25, FontStyle.Bold), Brushes.Black, e.PageBounds.Width / 2, e.PageBounds.Height / 10);
            e.Graphics.DrawString("PBKK POS", new Font("Times New Roman", 25, FontStyle.Bold), Brushes.Black, e.PageBounds.Width / 2, e.PageBounds.Height / 10 * 2);
            e.Graphics.DrawString("PBKK POS", new Font("Times New Roman", 25, FontStyle.Bold), Brushes.Black, e.PageBounds.Width / 2, e.PageBounds.Height / 10 * 3);

        }

        private void label8_Click(object sender, EventArgs e)
        {
            login Login = new login();
            Login.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void BillsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'posDataSetDataSet.transactionList' table. You can move, or remove it, as needed.
            this.transactionListTableAdapter.Fill(this.posDataSetDataSet.transactionList);

        }

        private void printPreviewDialog1_Load_1(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            productName.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            productPrice.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            productQuantity.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
