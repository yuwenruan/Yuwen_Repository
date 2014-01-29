/****************************************************************
 * Author:Yu Wen
 * Date: Jan 29, 2014
 * Task: ASP.NET Thread Project 
 * 
 * Load package page to show all packages that the customer has
 * *****************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
   
    //page load
    //get customer id from session and show total spend of packages
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["CustomerId"] == null)
        {
            Session["CustomerId"] = "104";
        }

        int i = 104;

        lblName.Text = CustomerDB.GetCustomerName(i);
        //lblTotal.Text = PackageDB.GetTotalMoneyById(i).ToString("c");
        lblTotal.Text = BookingProductDB.GetBookingProductTotal(i).ToString("c");
        lblPackage.Text = PackageDB.GetTotalMoneyById(i).ToString("c");

    }


    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}