
namespace WindowsFormsApp11
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.izdatelstvaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librDataSet = new WindowsFormsApp11.librDataSet();
            this.izdatelstvaTableAdapter = new WindowsFormsApp11.librDataSetTableAdapters.IzdatelstvaTableAdapter();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librDataSet1 = new WindowsFormsApp11.librDataSet1();
            this.bookTableAdapter = new WindowsFormsApp11.librDataSet1TableAdapters.BookTableAdapter();
            this.vydachiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librDataSet2 = new WindowsFormsApp11.librDataSet2();
            this.vydachiTableAdapter = new WindowsFormsApp11.librDataSet2TableAdapters.VydachiTableAdapter();
            this.chitateliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librDataSet3 = new WindowsFormsApp11.librDataSet3();
            this.chitateliTableAdapter = new WindowsFormsApp11.librDataSet3TableAdapters.ChitateliTableAdapter();
            this.exit = new System.Windows.Forms.Button();
            this.delete3 = new System.Windows.Forms.Button();
            this.add3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.delete4 = new System.Windows.Forms.Button();
            this.add4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idchitatelyaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rospisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datevydachiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBookDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idchitatelyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.add1 = new System.Windows.Forms.Button();
            this.delete1 = new System.Windows.Forms.Button();
            this.delete2 = new System.Windows.Forms.Button();
            this.add2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.countOfBooksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idizdatelstvaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.izdatelstvaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vydachiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitateliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // izdatelstvaBindingSource
            // 
            this.izdatelstvaBindingSource.DataMember = "Izdatelstva";
            this.izdatelstvaBindingSource.DataSource = this.librDataSet;
            // 
            // librDataSet
            // 
            this.librDataSet.DataSetName = "librDataSet";
            this.librDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // izdatelstvaTableAdapter
            // 
            this.izdatelstvaTableAdapter.ClearBeforeFill = true;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.librDataSet1;
            // 
            // librDataSet1
            // 
            this.librDataSet1.DataSetName = "librDataSet1";
            this.librDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // vydachiBindingSource
            // 
            this.vydachiBindingSource.DataMember = "Vydachi";
            this.vydachiBindingSource.DataSource = this.librDataSet2;
            // 
            // librDataSet2
            // 
            this.librDataSet2.DataSetName = "librDataSet2";
            this.librDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vydachiTableAdapter
            // 
            this.vydachiTableAdapter.ClearBeforeFill = true;
            // 
            // chitateliBindingSource
            // 
            this.chitateliBindingSource.DataMember = "Chitateli";
            this.chitateliBindingSource.DataSource = this.librDataSet3;
            // 
            // librDataSet3
            // 
            this.librDataSet3.DataSetName = "librDataSet3";
            this.librDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chitateliTableAdapter
            // 
            this.chitateliTableAdapter.ClearBeforeFill = true;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(1219, 577);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 24;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // delete3
            // 
            this.delete3.Location = new System.Drawing.Point(127, 577);
            this.delete3.Name = "delete3";
            this.delete3.Size = new System.Drawing.Size(91, 23);
            this.delete3.TabIndex = 17;
            this.delete3.Text = "DELETE";
            this.delete3.UseVisualStyleBackColor = true;
            this.delete3.Click += new System.EventHandler(this.delete3_Click);
            // 
            // add3
            // 
            this.add3.Location = new System.Drawing.Point(15, 577);
            this.add3.Name = "add3";
            this.add3.Size = new System.Drawing.Size(89, 23);
            this.add3.TabIndex = 16;
            this.add3.Text = "ADD";
            this.add3.UseVisualStyleBackColor = true;
            this.add3.Click += new System.EventHandler(this.add3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 544);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Поиск:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(75, 544);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(143, 22);
            this.textBox3.TabIndex = 15;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // delete4
            // 
            this.delete4.Location = new System.Drawing.Point(805, 577);
            this.delete4.Name = "delete4";
            this.delete4.Size = new System.Drawing.Size(93, 23);
            this.delete4.TabIndex = 23;
            this.delete4.Text = "DELETE";
            this.delete4.UseVisualStyleBackColor = true;
            this.delete4.Click += new System.EventHandler(this.delete4_Click);
            // 
            // add4
            // 
            this.add4.Location = new System.Drawing.Point(671, 577);
            this.add4.Name = "add4";
            this.add4.Size = new System.Drawing.Size(90, 23);
            this.add4.TabIndex = 22;
            this.add4.Text = "ADD";
            this.add4.UseVisualStyleBackColor = true;
            this.add4.Click += new System.EventHandler(this.add4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(668, 544);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Поиск:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(726, 539);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(154, 22);
            this.textBox4.TabIndex = 21;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "FIO";
            this.fIODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.Width = 125;
            // 
            // idchitatelyaDataGridViewTextBoxColumn1
            // 
            this.idchitatelyaDataGridViewTextBoxColumn1.DataPropertyName = "Id_chitatelya";
            this.idchitatelyaDataGridViewTextBoxColumn1.HeaderText = "Id_chitatelya";
            this.idchitatelyaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idchitatelyaDataGridViewTextBoxColumn1.Name = "idchitatelyaDataGridViewTextBoxColumn1";
            this.idchitatelyaDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idchitatelyaDataGridViewTextBoxColumn1,
            this.fIODataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.chitateliBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(658, 372);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(636, 165);
            this.dataGridView4.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(655, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Читатели:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Выдача:";
            // 
            // rospisDataGridViewTextBoxColumn
            // 
            this.rospisDataGridViewTextBoxColumn.DataPropertyName = "rospis";
            this.rospisDataGridViewTextBoxColumn.HeaderText = "rospis";
            this.rospisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rospisDataGridViewTextBoxColumn.Name = "rospisDataGridViewTextBoxColumn";
            this.rospisDataGridViewTextBoxColumn.Width = 125;
            // 
            // datevydachiDataGridViewTextBoxColumn
            // 
            this.datevydachiDataGridViewTextBoxColumn.DataPropertyName = "date_vydachi";
            this.datevydachiDataGridViewTextBoxColumn.HeaderText = "date_vydachi";
            this.datevydachiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datevydachiDataGridViewTextBoxColumn.Name = "datevydachiDataGridViewTextBoxColumn";
            this.datevydachiDataGridViewTextBoxColumn.Width = 125;
            // 
            // idBookDataGridViewTextBoxColumn1
            // 
            this.idBookDataGridViewTextBoxColumn1.DataPropertyName = "Id_Book";
            this.idBookDataGridViewTextBoxColumn1.HeaderText = "Id_Book";
            this.idBookDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idBookDataGridViewTextBoxColumn1.Name = "idBookDataGridViewTextBoxColumn1";
            this.idBookDataGridViewTextBoxColumn1.Width = 125;
            // 
            // idchitatelyaDataGridViewTextBoxColumn
            // 
            this.idchitatelyaDataGridViewTextBoxColumn.DataPropertyName = "Id_chitatelya";
            this.idchitatelyaDataGridViewTextBoxColumn.HeaderText = "Id_chitatelya";
            this.idchitatelyaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idchitatelyaDataGridViewTextBoxColumn.Name = "idchitatelyaDataGridViewTextBoxColumn";
            this.idchitatelyaDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idchitatelyaDataGridViewTextBoxColumn,
            this.idBookDataGridViewTextBoxColumn1,
            this.datevydachiDataGridViewTextBoxColumn,
            this.rospisDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.vydachiBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(13, 372);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(589, 165);
            this.dataGridView3.TabIndex = 13;
            // 
            // add1
            // 
            this.add1.Location = new System.Drawing.Point(16, 282);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(89, 23);
            this.add1.TabIndex = 4;
            this.add1.Text = "ADD";
            this.add1.UseVisualStyleBackColor = true;
            this.add1.Click += new System.EventHandler(this.add1_Click);
            // 
            // delete1
            // 
            this.delete1.Location = new System.Drawing.Point(138, 282);
            this.delete1.Name = "delete1";
            this.delete1.Size = new System.Drawing.Size(91, 23);
            this.delete1.TabIndex = 5;
            this.delete1.Text = "DELETE";
            this.delete1.UseVisualStyleBackColor = true;
            this.delete1.Click += new System.EventHandler(this.delete1_Click);
            // 
            // delete2
            // 
            this.delete2.Location = new System.Drawing.Point(754, 282);
            this.delete2.Name = "delete2";
            this.delete2.Size = new System.Drawing.Size(95, 23);
            this.delete2.TabIndex = 11;
            this.delete2.Text = "DELETE";
            this.delete2.UseVisualStyleBackColor = true;
            this.delete2.Click += new System.EventHandler(this.delete2_Click);
            // 
            // add2
            // 
            this.add2.Location = new System.Drawing.Point(635, 282);
            this.add2.Name = "add2";
            this.add2.Size = new System.Drawing.Size(85, 23);
            this.add2.TabIndex = 10;
            this.add2.Text = "ADD";
            this.add2.UseVisualStyleBackColor = true;
            this.add2.Click += new System.EventHandler(this.add2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(604, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Поиск:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(671, 254);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 22);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Поиск:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 249);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(604, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Книги:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Издательства:";
            // 
            // countOfBooksDataGridViewTextBoxColumn
            // 
            this.countOfBooksDataGridViewTextBoxColumn.DataPropertyName = "CountOfBooks";
            this.countOfBooksDataGridViewTextBoxColumn.HeaderText = "CountOfBooks";
            this.countOfBooksDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countOfBooksDataGridViewTextBoxColumn.Name = "countOfBooksDataGridViewTextBoxColumn";
            this.countOfBooksDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.Width = 125;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // idBookDataGridViewTextBoxColumn
            // 
            this.idBookDataGridViewTextBoxColumn.DataPropertyName = "Id_Book";
            this.idBookDataGridViewTextBoxColumn.HeaderText = "Id_Book";
            this.idBookDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idBookDataGridViewTextBoxColumn.Name = "idBookDataGridViewTextBoxColumn";
            this.idBookDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBookDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.authorDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.countOfBooksDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bookBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(607, 46);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(729, 203);
            this.dataGridView2.TabIndex = 7;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // idizdatelstvaDataGridViewTextBoxColumn
            // 
            this.idizdatelstvaDataGridViewTextBoxColumn.DataPropertyName = "Id_izdatelstva";
            this.idizdatelstvaDataGridViewTextBoxColumn.HeaderText = "Id_izdatelstva";
            this.idizdatelstvaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idizdatelstvaDataGridViewTextBoxColumn.Name = "idizdatelstvaDataGridViewTextBoxColumn";
            this.idizdatelstvaDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idizdatelstvaDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.izdatelstvaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(569, 196);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1341, 640);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.delete4);
            this.Controls.Add(this.add4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.delete3);
            this.Controls.Add(this.add3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.delete2);
            this.Controls.Add(this.add2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.delete1);
            this.Controls.Add(this.add1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ИС Библиотека";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.izdatelstvaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vydachiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitateliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private librDataSet librDataSet;
        private System.Windows.Forms.BindingSource izdatelstvaBindingSource;
        private librDataSetTableAdapters.IzdatelstvaTableAdapter izdatelstvaTableAdapter;
        private librDataSet1 librDataSet1;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private librDataSet1TableAdapters.BookTableAdapter bookTableAdapter;
        private librDataSet2 librDataSet2;
        private System.Windows.Forms.BindingSource vydachiBindingSource;
        private librDataSet2TableAdapters.VydachiTableAdapter vydachiTableAdapter;
        private librDataSet3 librDataSet3;
        private System.Windows.Forms.BindingSource chitateliBindingSource;
        private librDataSet3TableAdapters.ChitateliTableAdapter chitateliTableAdapter;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button delete3;
        private System.Windows.Forms.Button add3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button delete4;
        private System.Windows.Forms.Button add4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idchitatelyaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn rospisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datevydachiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBookDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idchitatelyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button add1;
        private System.Windows.Forms.Button delete1;
        private System.Windows.Forms.Button delete2;
        private System.Windows.Forms.Button add2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn countOfBooksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idizdatelstvaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

