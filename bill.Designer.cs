namespace POS0
{
    partial class bill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bill));
            this.totalHarga = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.SellerNamelbl = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.DataGRID2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.productID = new System.Windows.Forms.TextBox();
            this.BillsDGV = new System.Windows.Forms.DataGridView();
            this.billIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posDataSetDataSet = new POS0.posDataSetDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.urutan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idproduk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceProduk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billID = new System.Windows.Forms.TextBox();
            this.productPrice = new System.Windows.Forms.TextBox();
            this.productQuantity = new System.Windows.Forms.TextBox();
            this.productName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.transactionListTableAdapter = new POS0.posDataSetDataSetTableAdapters.transactionListTableAdapter();
            this.DataGRID2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posDataSetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // totalHarga
            // 
            this.totalHarga.AutoSize = true;
            this.totalHarga.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalHarga.ForeColor = System.Drawing.Color.White;
            this.totalHarga.Location = new System.Drawing.Point(782, 383);
            this.totalHarga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalHarga.Name = "totalHarga";
            this.totalHarga.Size = new System.Drawing.Size(42, 20);
            this.totalHarga.TabIndex = 25;
            this.totalHarga.Text = "Rp.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(598, 356);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 24);
            this.label7.TabIndex = 24;
            this.label7.Text = "Total Harga";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button9.Location = new System.Drawing.Point(26, 356);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(425, 32);
            this.button9.TabIndex = 23;
            this.button9.Text = "Tambah Produk";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // SellerNamelbl
            // 
            this.SellerNamelbl.AutoSize = true;
            this.SellerNamelbl.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerNamelbl.ForeColor = System.Drawing.Color.White;
            this.SellerNamelbl.Location = new System.Drawing.Point(932, 15);
            this.SellerNamelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SellerNamelbl.Name = "SellerNamelbl";
            this.SellerNamelbl.Size = new System.Drawing.Size(58, 24);
            this.SellerNamelbl.TabIndex = 22;
            this.SellerNamelbl.Text = "Seller";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(21, 15);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(41, 24);
            this.dateLabel.TabIndex = 21;
            this.dateLabel.Text = "Tgl.";
            this.dateLabel.Click += new System.EventHandler(this.Datelbl_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Jumlah";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("MS PGothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button2.Location = new System.Drawing.Point(1021, 522);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 44);
            this.button2.TabIndex = 17;
            this.button2.Text = "Cetak";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(40, 642);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 25);
            this.label8.TabIndex = 35;
            this.label8.Text = "<<< Logout";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // DataGRID2
            // 
            this.DataGRID2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.DataGRID2.Controls.Add(this.label10);
            this.DataGRID2.Controls.Add(this.label9);
            this.DataGRID2.Controls.Add(this.productID);
            this.DataGRID2.Controls.Add(this.label8);
            this.DataGRID2.Controls.Add(this.BillsDGV);
            this.DataGRID2.Controls.Add(this.dataGridView2);
            this.DataGRID2.Controls.Add(this.billID);
            this.DataGRID2.Controls.Add(this.productPrice);
            this.DataGRID2.Controls.Add(this.productQuantity);
            this.DataGRID2.Controls.Add(this.productName);
            this.DataGRID2.Controls.Add(this.dataGridView1);
            this.DataGRID2.Controls.Add(this.label6);
            this.DataGRID2.Controls.Add(this.button2);
            this.DataGRID2.Controls.Add(this.button1);
            this.DataGRID2.Controls.Add(this.totalHarga);
            this.DataGRID2.Controls.Add(this.label7);
            this.DataGRID2.Controls.Add(this.button9);
            this.DataGRID2.Controls.Add(this.SellerNamelbl);
            this.DataGRID2.Controls.Add(this.dateLabel);
            this.DataGRID2.Controls.Add(this.label5);
            this.DataGRID2.Controls.Add(this.button7);
            this.DataGRID2.Controls.Add(this.label4);
            this.DataGRID2.Controls.Add(this.label3);
            this.DataGRID2.Controls.Add(this.label2);
            this.DataGRID2.Controls.Add(this.label1);
            this.DataGRID2.Location = new System.Drawing.Point(1, 1);
            this.DataGRID2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGRID2.Name = "DataGRID2";
            this.DataGRID2.Size = new System.Drawing.Size(1213, 690);
            this.DataGRID2.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(1025, 650);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 17);
            this.label10.TabIndex = 38;
            this.label10.Text = "POS: Eric, Feinard, Kevin";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(21, 275);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 24);
            this.label9.TabIndex = 37;
            this.label9.Text = "Jumlah";
            this.label9.Visible = false;
            // 
            // productID
            // 
            this.productID.Location = new System.Drawing.Point(26, 306);
            this.productID.Multiline = true;
            this.productID.Name = "productID";
            this.productID.ReadOnly = true;
            this.productID.Size = new System.Drawing.Size(425, 25);
            this.productID.TabIndex = 36;
            this.productID.Visible = false;
            // 
            // BillsDGV
            // 
            this.BillsDGV.AllowUserToAddRows = false;
            this.BillsDGV.AllowUserToDeleteRows = false;
            this.BillsDGV.AutoGenerateColumns = false;
            this.BillsDGV.BackgroundColor = System.Drawing.Color.Bisque;
            this.BillsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.totalAmmountDataGridViewTextBoxColumn});
            this.BillsDGV.DataSource = this.transactionListBindingSource;
            this.BillsDGV.Location = new System.Drawing.Point(574, 434);
            this.BillsDGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BillsDGV.Name = "BillsDGV";
            this.BillsDGV.ReadOnly = true;
            this.BillsDGV.RowHeadersWidth = 51;
            this.BillsDGV.Size = new System.Drawing.Size(403, 144);
            this.BillsDGV.TabIndex = 35;
            this.BillsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillsDGV_CellContentClick);
            // 
            // billIDDataGridViewTextBoxColumn
            // 
            this.billIDDataGridViewTextBoxColumn.DataPropertyName = "BillID";
            this.billIDDataGridViewTextBoxColumn.HeaderText = "BillID";
            this.billIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.billIDDataGridViewTextBoxColumn.Name = "billIDDataGridViewTextBoxColumn";
            this.billIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.billIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalAmmountDataGridViewTextBoxColumn
            // 
            this.totalAmmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmmount";
            this.totalAmmountDataGridViewTextBoxColumn.HeaderText = "TotalAmmount";
            this.totalAmmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalAmmountDataGridViewTextBoxColumn.Name = "totalAmmountDataGridViewTextBoxColumn";
            this.totalAmmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalAmmountDataGridViewTextBoxColumn.Width = 125;
            // 
            // transactionListBindingSource
            // 
            this.transactionListBindingSource.DataMember = "transactionList";
            this.transactionListBindingSource.DataSource = this.posDataSetDataSet;
            // 
            // posDataSetDataSet
            // 
            this.posDataSetDataSet.DataSetName = "posDataSetDataSet";
            this.posDataSetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urutan,
            this.idproduk,
            this.Product,
            this.PriceProduk,
            this.quantityproduct,
            this.totalprice});
            this.dataGridView2.Location = new System.Drawing.Point(574, 55);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(604, 254);
            this.dataGridView2.TabIndex = 34;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // urutan
            // 
            this.urutan.HeaderText = "No";
            this.urutan.MinimumWidth = 6;
            this.urutan.Name = "urutan";
            this.urutan.ReadOnly = true;
            this.urutan.Width = 125;
            // 
            // idproduk
            // 
            this.idproduk.HeaderText = "ID Produk";
            this.idproduk.MinimumWidth = 6;
            this.idproduk.Name = "idproduk";
            this.idproduk.ReadOnly = true;
            this.idproduk.Visible = false;
            this.idproduk.Width = 125;
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.MinimumWidth = 6;
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Width = 125;
            // 
            // PriceProduk
            // 
            this.PriceProduk.HeaderText = "Price";
            this.PriceProduk.MinimumWidth = 6;
            this.PriceProduk.Name = "PriceProduk";
            this.PriceProduk.ReadOnly = true;
            this.PriceProduk.Width = 125;
            // 
            // quantityproduct
            // 
            this.quantityproduct.HeaderText = "Quantity";
            this.quantityproduct.MinimumWidth = 6;
            this.quantityproduct.Name = "quantityproduct";
            this.quantityproduct.ReadOnly = true;
            this.quantityproduct.Width = 125;
            // 
            // totalprice
            // 
            this.totalprice.HeaderText = "Total Price";
            this.totalprice.MinimumWidth = 6;
            this.totalprice.Name = "totalprice";
            this.totalprice.ReadOnly = true;
            this.totalprice.Width = 125;
            // 
            // billID
            // 
            this.billID.Enabled = false;
            this.billID.Location = new System.Drawing.Point(27, 79);
            this.billID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.billID.Multiline = true;
            this.billID.Name = "billID";
            this.billID.ReadOnly = true;
            this.billID.Size = new System.Drawing.Size(425, 25);
            this.billID.TabIndex = 33;
            this.billID.TextChanged += new System.EventHandler(this.billID_TextChanged);
            // 
            // productPrice
            // 
            this.productPrice.Location = new System.Drawing.Point(26, 191);
            this.productPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productPrice.Multiline = true;
            this.productPrice.Name = "productPrice";
            this.productPrice.ReadOnly = true;
            this.productPrice.Size = new System.Drawing.Size(425, 25);
            this.productPrice.TabIndex = 32;
            // 
            // productQuantity
            // 
            this.productQuantity.Location = new System.Drawing.Point(26, 247);
            this.productQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productQuantity.Multiline = true;
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.Size = new System.Drawing.Size(425, 25);
            this.productQuantity.TabIndex = 31;
            this.productQuantity.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(26, 137);
            this.productName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productName.Multiline = true;
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            this.productName.Size = new System.Drawing.Size(425, 25);
            this.productName.TabIndex = 30;
            this.productName.TextChanged += new System.EventHandler(this.productName_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Gold;
            this.dataGridView1.Location = new System.Drawing.Point(27, 416);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(424, 180);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(782, 330);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Rp.";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("MS PGothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(1021, 444);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 44);
            this.button1.TabIndex = 16;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button7.Location = new System.Drawing.Point(495, 155);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(49, 44);
            this.button7.TabIndex = 12;
            this.button7.Text = "⟳";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Harga";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nama Produk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Bill";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(491, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Penjualan";
            // 
            // Id
            // 
            this.Id.HeaderText = "ProdId";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // PName
            // 
            this.PName.HeaderText = "ProdName";
            this.PName.MinimumWidth = 6;
            this.PName.Name = "PName";
            this.PName.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 125;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load_1);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // transactionListTableAdapter
            // 
            this.transactionListTableAdapter.ClearBeforeFill = true;
            // 
            // bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 691);
            this.Controls.Add(this.DataGRID2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "bill";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.bill_Load);
            this.DataGRID2.ResumeLayout(false);
            this.DataGRID2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posDataSetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label totalHarga;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label SellerNamelbl;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel DataGRID2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox productQuantity;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.TextBox billID;
        private System.Windows.Forms.TextBox productPrice;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView BillsDGV;
        private posDataSetDataSet posDataSetDataSet;
        private System.Windows.Forms.BindingSource transactionListBindingSource;
        private posDataSetDataSetTableAdapters.transactionListTableAdapter transactionListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn billIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn urutan;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproduk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceProduk;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalprice;
        private System.Windows.Forms.Label label10;
    }
}