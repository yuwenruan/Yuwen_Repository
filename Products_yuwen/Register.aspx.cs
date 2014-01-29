using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        if (!UserDB.ExistUserByUserName(txtUserName.Text.Trim()))
        {
            Customer NewReg = new Customer();

            NewReg.CustFirstName = txtFirstname.Text;
            NewReg.CustLastName = txtLastName.Text;
            NewReg.CustAddress = txtAddress.Text;
            NewReg.CustCity = txtCity.Text;
            NewReg.CustProv = txtProvince.Text;
            NewReg.CustCountry = txtCountry.Text;
            NewReg.CustPostal = txtPostal.Text;
            NewReg.CustEmail = txtEmail.Text;
            NewReg.CustHomePhone = txtHomePhone.Text;
            NewReg.CustBusPhone = TxtBusPhone.Text;

            int newId = CustomerDB.InsertNewCustomer(NewReg);
            if (newId > 0)
            {
                User newUser = new User();

                newUser.CustomerId = newId;
                newUser.UserName = txtUserName.Text;
                newUser.Password = txtPassword.Text;

                bool insert = UserDB.InsertNewUser(newUser);

                if (insert)
                {
                    Response.Redirect("Welcome.aspx");
                }
                else
                {
                    lblMessage.Text = "User id and password is stored!";
                }
            }
            else
            {
                lblMessage.Text = "Customer cannot be registered!";
            }

        }
        else
        {
            lblMessage.Text = "User Name already exist, please use another one!";
        }

    }
}