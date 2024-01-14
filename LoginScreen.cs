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

namespace WeatherApp
{
    public partial class LoginScreen : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UFNMONH\SQLEXPRESS;Initial Catalog=WeatherUsers;Integrated Security=True");
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            try
            {
                string querry = "SELECT * FROM LoginInfo WHERE username = '" + userName.Trim() + "' AND password = '" + password.Trim() + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0 )
                {
                    userName = txtUserName.Text;
                    password = txtPassword.Text;

                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username and/or Password.");
                }
            }
            catch 
            {
                MessageBox.Show("Error");
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
