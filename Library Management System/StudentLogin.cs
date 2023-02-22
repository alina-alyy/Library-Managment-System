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

namespace Library_Management_System
{
   
    public partial class StudentLogin : Form
    {
        public static int std_LoggedID;
        Database db;
        SqlCommand cmd;

        public StudentLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = db.GetConnection();
            cmd = new SqlCommand("SELECT * from Students WHERE student_id=@user_id AND password=@password", con);
            cmd.Parameters.AddWithValue("@user_id", std_LoginId.Text);
            cmd.Parameters.AddWithValue("@password", std_Password.Text);

            using (SqlDataReader oReader = cmd.ExecuteReader())
            {
                if (!oReader.HasRows)
                {
                    MessageBox.Show("Login Failed, invalid id or password");
                    return;
                }

                if (oReader.Read())
                {
                    std_LoggedID = int.Parse(oReader["student_id"].ToString());
                    MessageBox.Show("Successfully Logged In");
                }
            };

            con.Close();
            StudentMain stdMain = new StudentMain();
            stdMain.Show();
            this.Close();

        }

        private void StudentLogin_Load(object sender, EventArgs e)
        {
            db = new Database();

        }
    }
}
