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

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        DataSet ds;
        DataSet ds1;
        DataSet ds2;
        DataSet ds3;
        SqlDataAdapter adapter;
        SqlDataAdapter adapter1;
        SqlDataAdapter adapter2;
        SqlDataAdapter adapter3;
        string connectionString = @"Data Source=DESKTOP-4S1E424\SQLEXPRESS; Initial Catalog=libr; Integrated Security=True";
        string sql = "SELECT * FROM Izdatelstva";
        string sql1 = "SELECT * FROM Book";
        string sql2 = "SELECT * FROM Vydachi";
        string sql3 = "SELECT * FROM Chitateli";
        public Form1()
        {
            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.AllowUserToAddRows = false;
            dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView4.AllowUserToAddRows = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);
                adapter1 = new SqlDataAdapter(sql1, connection);
                adapter2 = new SqlDataAdapter(sql2, connection);
                adapter3 = new SqlDataAdapter(sql3, connection);
                ds = new DataSet();
                ds1 = new DataSet();
                ds2 = new DataSet();
                ds3 = new DataSet();
                adapter.Fill(ds);
                adapter1.Fill(ds1);
                adapter2.Fill(ds2);
                adapter3.Fill(ds3);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView2.DataSource = ds1.Tables[0];
                dataGridView3.DataSource = ds2.Tables[0];
                dataGridView4.DataSource = ds3.Tables[0];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'librDataSet3.Chitateli' table. You can move, or remove it, as needed.
            this.chitateliTableAdapter.Fill(this.librDataSet3.Chitateli);
            // TODO: This line of code loads data into the 'librDataSet2.Vydachi' table. You can move, or remove it, as needed.
            this.vydachiTableAdapter.Fill(this.librDataSet2.Vydachi);
            // TODO: This line of code loads data into the 'librDataSet1.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.librDataSet1.Book);
            // TODO: This line of code loads data into the 'librDataSet.Izdatelstva' table. You can move, or remove it, as needed.
            this.izdatelstvaTableAdapter.Fill(this.librDataSet.Izdatelstva);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)// поиск по названию издательства
        {
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                string str = dataGridView1.Rows[i].Cells[1].Value.ToString();
                if (str.Contains(textBox1.Text) == true) dataGridView1.Rows[i].Selected = true;
                else dataGridView1.Rows[i].Selected = false;
                if (textBox1.Text == "") dataGridView1.Rows[i].Selected = false;
            }
        }

        private void add1_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].NewRow();
            ds.Tables[0].Rows.Add(row);
            
        }

        private void delete1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)//поиск по названию книги
        {
            for (int i = 0; i < dataGridView2.RowCount - 1; i++)
            {
                string str = dataGridView2.Rows[i].Cells[1].Value.ToString();
                if (str.Contains(textBox2.Text) == true) dataGridView2.Rows[i].Selected = true;
                else dataGridView2.Rows[i].Selected = false;
                if (textBox2.Text == "") dataGridView2.Rows[i].Selected = false;
            }
        }

        private void add2_Click(object sender, EventArgs e)
        {
            DataRow row = ds1.Tables[0].NewRow();
            ds1.Tables[0].Rows.Add(row);
        }

        private void delete2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                dataGridView2.Rows.Remove(row);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)// поиск по номеру книги
        {
            for (int i = 0; i < dataGridView3.RowCount - 1; i++)
            {
                string str = dataGridView3.Rows[i].Cells[1].Value.ToString();
                if (str.Contains(textBox3.Text) == true) dataGridView3.Rows[i].Selected = true;
                else dataGridView3.Rows[i].Selected = false;
                if (textBox3.Text == "") dataGridView3.Rows[i].Selected = false;
            }
        }

        private void add3_Click(object sender, EventArgs e)
        {
            DataRow row = ds2.Tables[0].NewRow();
            ds2.Tables[0].Rows.Add(row);
        }

        private void delete3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView3.SelectedRows)
            {
                dataGridView3.Rows.Remove(row);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)// поиск по ФИО
        {
            for (int i = 0; i < dataGridView4.RowCount - 1; i++)
            {
                string str = dataGridView4.Rows[i].Cells[1].Value.ToString();
                if (str.Contains(textBox4.Text) == true) dataGridView4.Rows[i].Selected = true;
                else dataGridView4.Rows[i].Selected = false;
                if (textBox4.Text == "") dataGridView3.Rows[i].Selected = false;
            }
        }

        private void add4_Click(object sender, EventArgs e)
        {
            DataRow row = ds3.Tables[0].NewRow();
            ds3.Tables[0].Rows.Add(row);
        }

        private void delete4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView4.SelectedRows)
            {
                dataGridView4.Rows.Remove(row);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}