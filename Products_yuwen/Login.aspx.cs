using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient; 
using System.Web.Security; 



public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        int id = UserDB.SuccessLog(txtUserName.Text, txtPassword.Text);
        // Authenticate againts the list stored in web.config
        if (id!=-1)
        {
            Session["CustomerId"] = id;
            Response.Redirect("~/Welcome.aspx");
            //FormsAuthentication.RedirectFromLoginPage(txtUserName.Text, chkBoxRememberMe.Checked);
        }
        else
        {           
            lblMessage.Text = "Invalid User Name and/or Password";
        }

    }

    //private bool AuthenticateUser(string username, string password)
    //{
    //    // ConfigurationManager class is in System.Configuration namespace
    //    string CS = ConfigurationManager.ConnectionStrings["TravelExpertsConnectionString"].ConnectionString;
    //    // SqlConnection is in System.Data.SqlClient namespace
    //    using (SqlConnection con = new SqlConnection(CS))
    //    {
    //        SqlCommand cmd = new SqlCommand("uspAuthenticateUser", con);
    //        cmd.CommandType = CommandType.StoredProcedure;

    //        // FormsAuthentication is in System.Web.Security
    //        string EncryptedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(password, "SHA1");
    //        // SqlParameter is in System.Data namespace
    //        SqlParameter paramUsername = new SqlParameter("@UserName", username);
    //        SqlParameter paramPassword = new SqlParameter("@Password", EncryptedPassword);

    //        cmd.Parameters.Add(paramUsername);
    //        cmd.Parameters.Add(paramPassword);

    //        con.Open();
    //        int ReturnCode = (int)cmd.ExecuteScalar();
    //        return ReturnCode == 1;
    //    }
    
  
    
}