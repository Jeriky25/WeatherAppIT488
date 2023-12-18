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
    public partial class Register : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UFNMONH\SQLEXPRESS;Initial Catalog=WeatherUsers;Integrated Security=True");
        public Register()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string userName = txtRgstUserName.Text;
            string password = txtRgstPassword.Text;

            if (userName == "" ||  password == "")
            {
                MessageBox.Show("Please fill out all blank fields.");
            }
            else
            {
                if (conn.State != ConnectionState.Open) 
                {
                    try
                    {
                        conn.Open();
                        string checkUserName = "SELECT * FROM LoginInfo WHERE username = '" + userName.Trim() + "'";

                        using (SqlCommand checkUser = new SqlCommand(checkUserName, conn))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count >= 1)
                            {
                                MessageBox.Show(userName + " already exist.");
                            }
                            else
                            {
                                string insertData = "INSERT INTO LoginInfo (username, password) " + "VALUES(@username, @password)";

                                using (SqlCommand cmd = new SqlCommand(insertData, conn))
                                {
                                    cmd.Parameters.AddWithValue("@username", userName.Trim());
                                    cmd.Parameters.AddWithValue("@password", password.Trim());

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Signup successfull");

                                    LoginScreen loginScreen = new LoginScreen();
                                    loginScreen.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                }
                  
            }
        }
    }
}
