using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["CustomerId"] == null)
        {
            Response.Redirect("Welcome.aspx");
        }
        
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        int id = (int)Session["CustomerId"];

        User user = new User();
        user = UserDB.GetUser(id);

        if (user != null)
        {
            
            string EncryptedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(txtCurrentPassword.Text, "SHA1");

            if (EncryptedPassword == user.Password)
            {
                user.Password=txtNewPassword.Text;
                bool update = UserDB.UpdatePassword(user);
                if (update)
                {
                    lblMessage.Text = "Password updated successfully.";
                }
                else
                {
                    lblMessage.Text = "Password not updated, try again.";
                }
            }
            else
            {
                lblMessage.Text = "Old password not match.";
            }
        }
    }
}