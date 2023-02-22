using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Library_Management_System
{
    internal class Database
    {
        private static string conString = "Data Source=DESKTOP-PTS74TH;Initial Catalog=project;Integrated Security=True";

        public SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            return connection;
        }

        public SqlDataAdapter getBooks(string keyword = null)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd;

            if (keyword == null)
            {
                cmd = new SqlCommand("SELECT book_id, name, category_name, publisher_name, publish_date from Books INNER JOIN Category ON Books.category_id=Category.category_id WHERE isIssued = 0", con);
            }
            else
            {
                cmd = new SqlCommand("SELECT book_id, name, category_name, publisher_name, publish_date from Books INNER JOIN Category ON Books.category_id=Category.category_id WHERE isIssued = 0 AND Books.name LIKE @search_term", con);
                cmd.Parameters.AddWithValue("@search_term", keyword + "%");

            }
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            con.Close();
            return data;
        }

        public SqlDataAdapter getAllBooks(string keyword = null)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd;

            if (keyword == null)
            {
                cmd = new SqlCommand("SELECT book_id, name, category_name, publisher_name, publish_date, isIssued from Books INNER JOIN Category ON Books.category_id=Category.category_id", con);
            }
            else
            {
                cmd = new SqlCommand("SELECT book_id, name, category_name, publisher_name, publish_date, isIssued from Books INNER JOIN Category ON Books.category_id=Category.category_id AND Books.name LIKE @search_term", con);
                cmd.Parameters.AddWithValue("@search_term", keyword + "%");

            }
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            con.Close();
            return data;
        }

        public SqlDataAdapter getStudentIssuedBooks(int studentID)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd;

            cmd = new SqlCommand("SELECT book_id, name, category_name, publisher_name, publish_date from Books, Category WHERE Books.category_id = Category.category_id AND book_id IN (SELECT book_id FROM Book_Issue LEFT JOIN Book_Return ON Book_Issue.issue_id=Book_Return.issue_id WHERE return_id IS NULL AND student_id=@student_id)", con);
            cmd.Parameters.AddWithValue("@student_id", studentID);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            con.Close();
            return data;
        }

        public SqlDataReader getStudent(int id, SqlConnection c)
        {
            SqlCommand cmd = new SqlCommand("SELECT * from Students WHERE student_id=@user_id", c);
            cmd.Parameters.AddWithValue("@user_id", id);
            SqlDataReader dataReader = cmd.ExecuteReader();
            return dataReader;
        }

        public SqlDataReader getStaff(int id, SqlConnection c)
        {
            SqlCommand cmd = new SqlCommand("SELECT * from Librarian WHERE librarian_id=@librarian_id", c);
            cmd.Parameters.AddWithValue("@librarian_id", id);
            SqlDataReader dataReader = cmd.ExecuteReader();
            return dataReader;
        }
    }
}
