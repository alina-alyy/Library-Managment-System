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
    public partial class StaffAddBook : Form
    {
        Database db;
        public StaffAddBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = db.GetConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO Books(name, publisher_name, publish_date, category_id) VALUES(@book_name, @pub_name, @pub_date, @cat_id)", con);
            cmd.Parameters.AddWithValue("@book_name", bookname.Text);
            cmd.Parameters.AddWithValue("@pub_name", pubname.Text);
            cmd.Parameters.AddWithValue("@pub_date", pubdate.Text);
            cmd.Parameters.AddWithValue("@cat_id", int.Parse(categoryid.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Book has been added");
        }

        private void StaffAddBook_Load(object sender, EventArgs e)
        {
            db = new Database();
        }
    }
}
