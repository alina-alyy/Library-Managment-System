using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class StudentMain : Form
    {
        Database db;
        public StudentMain()
        {
            InitializeComponent();
        }

        private void StudentMain_Load(object sender, EventArgs e)
        {
            db = new Database();
            SqlConnection con = db.GetConnection();

            stdlabel_ID.Text = "ID: " + StudentLogin.std_LoggedID.ToString();
            using (SqlDataReader dataReader = db.getStudent(StudentLogin.std_LoggedID, con))
            {
                if (dataReader.Read())
                {
                    stdlabel_name.Text = "Student name: " + dataReader["name"].ToString();
                    stdcredit_label.Text = "Credits: " + dataReader["credits"].ToString();
                    stdcredit_label.Text = "Credits: " + dataReader["credits"].ToString();
                }
            };
            con.Close();
            populateBookGrid();
        }

        private void populateBookGrid(string keyword = null)
        {
            
            DataTable books_result = new DataTable();
            using (SqlDataAdapter data = db.getBooks(keyword))
            {
                data.Fill(books_result);

                books_grid.DataSource = null;
                books_grid.AutoGenerateColumns = false;
                books_grid.ColumnCount = books_result.Columns.Count;
                books_grid.Columns[0].HeaderText = "Book Id";
                books_grid.Columns[0].DataPropertyName = "book_id";
                books_grid.Columns[1].HeaderText = "Book name";
                books_grid.Columns[1].DataPropertyName = "name";
                books_grid.Columns[2].HeaderText = "Category";
                books_grid.Columns[2].DataPropertyName = "category_name";
                books_grid.Columns[3].HeaderText = "Publisher Name";
                books_grid.Columns[3].DataPropertyName = "publisher_name";
                books_grid.Columns[4].HeaderText = "Publisher Date";
                books_grid.Columns[4].DataPropertyName = "publish_date";

                books_grid.DataSource = books_result;
                books_grid.Columns[books_result.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            populateBookGrid(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentMyBooks studentMyBooks = new StudentMyBooks();
            studentMyBooks.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            populateBookGrid(search_textbox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = db.GetConnection();
            SqlCommand cmd;

            using (SqlDataReader dataReader = db.getStudent(StudentLogin.std_LoggedID, con))
            {
                if (dataReader.Read())
                {
                    if (int.Parse(dataReader["credits"].ToString()) <= 0)
                    {
                        MessageBox.Show("Not enough credits to issue a book");
                        return;
                    }
                }
            };

            int bookId = int.Parse(books_grid.Rows[books_grid.CurrentCell.RowIndex].Cells[0].Value.ToString());
            cmd = new SqlCommand("INSERT INTO Book_Issue(issue_date, student_id, book_id) VALUES(default, @student_id, @book_id)", con);
            cmd.Parameters.AddWithValue("@student_id", StudentLogin.std_LoggedID);
            cmd.Parameters.AddWithValue("@book_id", bookId);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("UPDATE Books SET isIssued = 1 WHERE book_id=@book_id", con);
            cmd.Parameters.AddWithValue("@book_id", bookId);
            cmd.ExecuteNonQuery();

            con.Close();
            populateBookGrid();
            MessageBox.Show("Book issued successfully");
        }

        private void books_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void search_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
