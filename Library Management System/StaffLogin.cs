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
    public partial class StaffLogin : Form
    {
        Database db;
        SqlCommand cmd;
        public static int staff_LoggedID;

        public StaffLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = db.GetConnection();
            cmd = new SqlCommand("SELECT * from Librarian WHERE librarian_id=@librarian_id AND password=@password", con);
            cmd.Parameters.AddWithValue("@librarian_id", staff_LoginId.Text);
            cmd.Parameters.AddWithValue("@password", staff_Password.Text);

            using (SqlDataReader oReader = cmd.ExecuteReader())
            {
                if (!oReader.HasRows)
                {
                    MessageBox.Show("Login Failed, invalid id or password");
                    return;
                }

                if (oReader.Read())
                {
                    staff_LoggedID = int.Parse(oReader["librarian_id"].ToString());
                    MessageBox.Show("Successfully Logged In");
                }
            };

            con.Close();
            StaffMain staffMain = new StaffMain();
            staffMain.Show();
            this.Close();
        }

        private void StaffLogin_Load(object sender, EventArgs e)
        {
            db = new Database();
        }
    }
}
