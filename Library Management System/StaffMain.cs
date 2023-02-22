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
    public partial class StaffMain : Form
    {
        Database db;
        SqlCommand cmd;
        

        public StaffMain()
        {
            InitializeComponent();
        }

        private void stdlabel_ID_Click(object sender, EventArgs e)
        {

        }

        private void StaffMain_Load(object sender, EventArgs e)
        {
            db = new Database();
            SqlConnection con = db.GetConnection();

            stafflabel_ID.Text = "ID: " + StaffLogin.staff_LoggedID.ToString();
            using (SqlDataReader dataReader = db.getStaff(StaffLogin.staff_LoggedID, con))
            {
                if (dataReader.Read())
                {
                    stafflabel_name.Text = "Staff name: " + dataReader["name"].ToString();
                    staffshift_label.Text = "Shift Time: " + dataReader["librarian_shift"].ToString();
                }
            };
            con.Close();
            populateBookGrid();
        }

        private void populateBookGrid(string keyword = null)
        {

            DataTable books_result = new DataTable();
            using (SqlDataAdapter data = db.getAllBooks(keyword))
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
                books_grid.Columns[5].HeaderText = "Issued";
                books_grid.Columns[5].DataPropertyName = "isIssued";

                books_grid.DataSource = books_result;
                books_grid.Columns[books_result.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void books_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StaffAddBook addbook = new StaffAddBook();
            addbook.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            populateBookGrid(search_textbox.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            populateBookGrid();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int issuedId = 0;
            int studentId = 0;
            int bookId = int.Parse(books_grid.Rows[books_grid.CurrentCell.RowIndex].Cells[0].Value.ToString());
            SqlConnection con = db.GetConnection();
           
            
            cmd = new SqlCommand("SELECT issue_id, student_id FROM Book_Issue WHERE issue_id NOT IN(SELECT issue_id FROM Book_Return) AND book_id=@book_id", con);
            cmd.Parameters.AddWithValue("@book_id", bookId);
            

            using (SqlDataReader dataReader = cmd.ExecuteReader())
            {
                if (dataReader.Read())
                {
                    issuedId = int.Parse(dataReader["issue_id"].ToString());
                }
            };

            cmd = new SqlCommand("INSERT INTO Book_Return VALUES(default, 10, @issue_id)", con);
            cmd.Parameters.AddWithValue("@issue_id", issuedId);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("UPDATE Books SET isIssued = 0 WHERE book_id=@book_id", con);
            cmd.Parameters.AddWithValue("@book_id", bookId);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("UPDATE Students SET credits = credits - 10 WHERE student_id=@student_id", con);
            cmd.Parameters.AddWithValue("@student_id", studentId);
            cmd.ExecuteNonQuery();

            con.Close();
            populateBookGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(books_grid.Rows[books_grid.CurrentCell.RowIndex].Cells[0].Value.ToString());
            SqlConnection con = db.GetConnection();

            cmd = new SqlCommand("DELETE FROM Books WHERE book_id=@book_id", con);
            cmd.Parameters.AddWithValue("@book_id", bookId);
            cmd.ExecuteNonQuery();

            con.Close();
            populateBookGrid();
        }
    }
}
