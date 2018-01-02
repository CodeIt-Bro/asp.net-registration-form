using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Register_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("insert into RegistrationTable values (@FirstName, @LastName, @Email, @MobileNumber, @Password)", con);
        cmd.Parameters.AddWithValue("FirstName", FnameTxt.Text);
        cmd.Parameters.AddWithValue("LastName", LnameTxt.Text);
        cmd.Parameters.AddWithValue("Email", Email.Text);
        cmd.Parameters.AddWithValue("MobileNumber", MobileNumber.Text);
        cmd.Parameters.AddWithValue("Password", Password.Text );
        cmd.ExecuteNonQuery();
        Label7.Visible = true;
        Label7.Text = "User registered successfully";

        FnameTxt.Text = "";
        LnameTxt.Text = "";
        Email.Text = "";
        MobileNumber.Text = "";
        Password.Text = "";
        FnameTxt.Focus();
    }
}