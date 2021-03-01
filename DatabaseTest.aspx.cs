using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Translation
{
    public partial class DatabaseTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            {
                lblConnectionStatus.Visible = false;

                string connectionString = "Data Source=139.78.8.180,22; Initial Catalog=zz_shoumen; User ID=shoumen;Password=ABCD123!";
                SqlConnection cnn = new SqlConnection(connectionString);

                cnn.Open();

                Response.Write("[Database connection successful]");

                cnn.Close();

            }
        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=139.78.8.180,22; Initial Catalog=zz_shoumen; User ID=shoumen;Password=ABCD123!";

            SqlConnection sqlCon = new SqlConnection(connectionString);

            sqlCon.Open();

            string query = "Select count(1) from tbluser where username= @username and password = @password";

            SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
            sqlCmd.Parameters.AddWithValue("@username", TextUserName.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@password", TextPassword.Text.Trim());

            int count = Convert.ToInt32(sqlCmd.ExecuteScalar());

            if ( count == 1)
            {
                Response.Redirect("WebForm1.aspx");
                lblConnectionStatus.Text = "You logged in successfully!";
                lblConnectionStatus.Visible = true;
                TextUserName.Text = "";
            }

            else
            {
                lblConnectionStatus.Text = "No username + password combination exists.";
                lblConnectionStatus.Visible = true;
            }

            sqlCon.Close();

        }

        protected void btnback_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnforgot_Click(object sender, EventArgs e)
        {

        }
    }
}