using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUD_Operation___Nimap_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;

            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                string query = "DELETE FROM P_Info"; 
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    int rowsAffected = cmd.ExecuteNonQuery(); 
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("All data successfully deleted.");
                    }
                    else
                    {
                        MessageBox.Show("No data found to delete.");
                    }
                }
            }

            LoadDataIntoDataGridView(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                string query = "INSERT INTO P_Info (ProductId, ProductName, CategoryId, CategoryName) VALUES (@ProductId, @ProductName, @CategoryId, @CategoryName)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ProductId", int.Parse(textBox1.Text));  
                    cmd.Parameters.AddWithValue("@ProductName", textBox2.Text);           
                    cmd.Parameters.AddWithValue("@CategoryId", int.Parse(textBox3.Text)); 
                    cmd.Parameters.AddWithValue("@CategoryName", textBox4.Text);         

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Data Successfully Inserted");

            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT ProductId, ProductName, CategoryId, CategoryName FROM P_Info";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                string query = "UPDATE P_Info SET ProductName = @ProductName, CategoryId = @CategoryId, CategoryName = @CategoryName WHERE ProductId = @ProductId";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    
                    cmd.Parameters.AddWithValue("@ProductId", int.Parse(textBox1.Text));  
                    cmd.Parameters.AddWithValue("@ProductName", textBox2.Text);          
                    cmd.Parameters.AddWithValue("@CategoryId", int.Parse(textBox3.Text)); 
                    cmd.Parameters.AddWithValue("@CategoryName", textBox4.Text);         

                    int rowsAffected = cmd.ExecuteNonQuery(); 
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data Successfully Updated");
                    }
                    else
                    {
                        MessageBox.Show("No record found to update.");
                    }
                }
            }

            LoadDataIntoDataGridView(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                string query = "DELETE FROM P_Info WHERE ProductId = @ProductId";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ProductId", int.Parse(textBox1.Text)); 

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data Successfully Deleted");
                    }
                    else
                    {
                        MessageBox.Show("No record found to delete.");
                    }
                }
            }
            LoadDataIntoDataGridView(); 
        }
    }
}
