/************************************************************
 * Author: Yu Wen
 * Date: Jan 29, 2014
 * 
 * customer information page
 * show detail customer information
 * allow update customer information 
 * **********************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //page load
    protected void Page_Load(object sender, EventArgs e)
    {
        //not from log in
        if (Session["CustomerId"] == null)
        {
            Response.Redirect("Welcome.aspx");
        }
        else
        {
            //set all control to read only
            if (!IsPostBack)
            {
                txtId.Enabled = false;
                //ResetTextEnable(false);
                //get customer id from session
                int custId = (int)Session["CustomerId"];
                //show customer information in each field
                Customer cust = CustomerDB.GetCustomerById(custId);
                UploadCustomerData(cust);
            }
            

        }
    }

    //set customer data into each text box
    private void UploadCustomerData(Customer customer)
    {
        txtId.Text = customer.CustomerId.ToString();
        txtFirstName.Text = customer.CustFirstName;
        txtLastName.Text = customer.CustLastName;
        txtCity.Text = customer.CustCity;
        txtPostal.Text = customer.CustPostal;
        txtProvince.Text =customer.CustProv;
        txtCountry.Text = customer.CustCountry;
        txtHomePhone.Text = customer.CustHomePhone;
        txtBusPhone.Text = customer.CustBusPhone;
        txtEmail.Text = customer.CustEmail;
        txtAgentId.Text = customer.AgentId.ToString();

    }

    private void ResetTextEnable(bool enabled)
    {
        //txtId.Enabled = enabled;
        txtFirstName.Enabled = enabled;
        txtLastName.Enabled = enabled;
        txtCity.Enabled = enabled;
        txtPostal.Enabled = enabled;
        txtProvince.Enabled = enabled;
        txtCountry.Enabled = enabled;
        txtHomePhone.Enabled = enabled;
        txtBusPhone.Enabled = enabled;
        txtEmail.Enabled = enabled;
        txtAgentId.Enabled = enabled;
    }


    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //ResetTextEnable(true);

    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        Customer customer = new Customer();

        customer.CustomerId = Convert.ToInt32(txtId.Text);
        customer.CustFirstName=txtFirstName.Text;
        customer.CustLastName=txtLastName.Text;
        customer.CustAddress = txtAddress.Text;
        customer.CustCity=txtCity.Text ;
        customer.CustPostal=txtPostal.Text ;
        customer.CustProv=txtProvince.Text;
        customer.CustCountry=txtCountry.Text;
        customer.CustHomePhone=txtHomePhone.Text ;
        customer.CustBusPhone=txtBusPhone.Text ;
        customer.CustEmail=txtEmail.Text;
        customer.AgentId = Convert.ToInt32(txtAgentId.Text) as int? ?? default(int);

        if (CustomerDB.UpdateCustomer(customer))
        {
            Customer cust = CustomerDB.GetCustomerById(customer.CustomerId);
            UploadCustomerData(cust);
        }
        else
            lblMessage.Text = "Customer information is not update successfully";

        //after update put read only back to controls
        //ResetTextEnable(false);
    }
    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("Welcome.aspx");
    }
}