using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
/// <summary>
/// Summary description for CustomerDB
/// </summary>
//[DataObject(true)]
public static class CustomerDB
{
 //   [DataObjectMethod(DataObjectMethodType.Select)]
    public static Customer GetCustomerById(int customerId)
    {
        Customer cust = new Customer();
        SqlConnection con = new SqlConnection(TravelExpertDB.GetConnectionString());

        string sel = "SELECT CustomerId, CustFirstName,CustLastName, CustAddress," +
                       "CustCity,CustProv,CustPostal,CustCountry,"+
                       "CustHomePhone,CustBusPhone,CustEmail,AgentId" +
                       " FROM Customers " +
                    "WHERE CustomerId=@CustomerId ";
        SqlCommand cmd = new SqlCommand(sel, con);
        cmd.Parameters.AddWithValue("CustomerId", customerId);
        try
        {
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                cust.CustomerId = (int)dr[0];
                cust.CustFirstName = (string)dr[1];
                cust.CustLastName = (string)dr[2];
                cust.CustAddress = (string)dr[3];
                cust.CustCity = (string)dr[4];
                cust.CustProv = (string)dr[5];
                cust.CustPostal = (string)dr[6];
                cust.CustCountry = (string)dr[7];
                cust.CustHomePhone = (string)dr[8];
                cust.CustBusPhone = (string)dr[9];
                cust.CustEmail = (string)dr[10];
                cust.AgentId = dr[11] as int? ?? default(int);                
            }
            return cust;
        }
        catch (SqlException ex)
        {
            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

 //   [DataObjectMethod(DataObjectMethodType.Select)]
    public static string GetCustomerName(int customerId)
    {
        string name="";
        SqlConnection con = new SqlConnection(TravelExpertDB.GetConnectionString());

        string sel = "SELECT CustFirstName,CustLastName" +
                       " FROM Customers " +
                    "WHERE CustomerId=@CustomerId ";
        SqlCommand cmd = new SqlCommand(sel, con);
        cmd.Parameters.AddWithValue("@CustomerId", customerId);
        try
        {
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                name += dr["CustFirstName"] + "  " + dr["CustLastName"];
            }
            return name;
        }
        catch (SqlException ex)
        {
            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    //Insert  New Customer Function 
    [DataObjectMethod(DataObjectMethodType.Update)]
    public static int InsertNewCustomer(Customer NewCustomer)
    {
        SqlConnection con = new SqlConnection(TravelExpertDB.GetConnectionString());
        string sel =

   "Insert Into Customers(CustFirstName, CustLastName, " +
            "CustAddress, CustCity, CustProv, " +
            "CustPostal, CustCountry, " +
            "CustHomePhone, CustBusPhone, " +
            "CustEmail) " +
            "VALUES (@CustFirstName, @CustLastName, @CustAddress, " +
            "@CustCity, @CustProv, @CustPostal, @CustCountry, @CustHomePhone, " +
            "@CustBusPhone, @CustEmail); SELECT SCOPE_IDENTITY()";

        SqlCommand cmd = new SqlCommand(sel, con);
        {

            cmd.Parameters.AddWithValue("@CustFirstName", NewCustomer.CustFirstName);
            cmd.Parameters.AddWithValue("@CustLastName", NewCustomer.CustLastName);
            cmd.Parameters.AddWithValue("@CustAddress", NewCustomer.CustAddress);
            cmd.Parameters.AddWithValue("@CustCity", NewCustomer.CustCity);
            cmd.Parameters.AddWithValue("@CustProv", NewCustomer.CustProv);
            cmd.Parameters.AddWithValue("@CustPostal", NewCustomer.CustPostal);
            cmd.Parameters.AddWithValue("@CustCountry", NewCustomer.CustCountry);
            cmd.Parameters.AddWithValue("@CustHomePhone", NewCustomer.CustHomePhone);
            cmd.Parameters.AddWithValue("@CustBusPhone", NewCustomer.CustBusPhone);
            cmd.Parameters.AddWithValue("@CustEmail", NewCustomer.CustEmail);

            try
            {
                con.Open();
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                //string SelectNewId =
                //    "SELECT IDENT_CURRENT('CustomerId') FROM CUSTOMERS";
                //SqlCommand selectCommand = new SqlCommand(SelectNewId, con);
                //int NewId = Convert.ToInt32(selectCommand.ExecuteScalar());
                //return NewId;
                return result;

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

    }
}