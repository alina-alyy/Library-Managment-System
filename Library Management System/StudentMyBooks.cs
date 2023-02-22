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
    public partial class StudentMyBooks : Form
    {
        public StudentMyBooks()
        {
            InitializeComponent();
        }

        private void StudentMyBooks_Load(object sender, EventArgs e)
        {
            Database db = new Database();
            DataTable books_result = new DataTable();
            using (SqlDataAdapter data = db.getStudentIssuedBooks(StudentLogin.std_LoggedID))
            {
                data.Fill(books_result);

                issuedBooks_grid.DataSource = null;
                issuedBooks_grid.AutoGenerateColumns = false;
                issuedBooks_grid.ColumnCount = books_result.Columns.Count;
                issuedBooks_grid.Columns[0].HeaderText = "Book Id";
                issuedBooks_grid.Columns[0].DataPropertyName = "book_id";
                issuedBooks_grid.Columns[1].HeaderText = "Book name";
                issuedBooks_grid.Columns[1].DataPropertyName = "name";
                issuedBooks_grid.Columns[2].HeaderText = "Category";
                issuedBooks_grid.Columns[2].DataPropertyName = "category_name";
                issuedBooks_grid.Columns[3].HeaderText = "Publisher Name";
                issuedBooks_grid.Columns[3].DataPropertyName = "publisher_name";
                issuedBooks_grid.Columns[4].HeaderText = "Publisher Date";
                issuedBooks_grid.Columns[4].DataPropertyName = "publish_date";

                issuedBooks_grid.DataSource = books_result;
                issuedBooks_grid.Columns[books_result.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}
