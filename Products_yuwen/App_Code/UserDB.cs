using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


/// <summary>
/// Summary description for UserDB
/// </summary>
public static class UserDB
{
    public static bool ExistUserByUserName(string username)
    {
        int count=0;
        SqlConnection con = new SqlConnection(TravelExpertDB.GetConnectionString());

  
        string selectState = "SELECT count(UserName) FROM Users WHERE UserName=@UserName";


        SqlCommand cmd = new SqlCommand(selectState, con);
        cmd.Parameters.AddWithValue("@UserName", username);
        try
        {
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr != null && dr.Read())
            {
                count = (int)dr[0];
            }
            if (count > 0)
            {
                return true;
            }
            else
                return false;
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

    //insert a new user with userid and password
    public static bool InsertNewUser(User user)
    {
        SqlConnection con=new SqlConnection(TravelExpertDB.GetConnectionString());
        
        string insertstate = "INSERT INTO Users (UserName,Password,CustomerId) VALUES(@username,@password,@customerid)";

        SqlCommand cmd = new SqlCommand(insertstate, con);

        cmd.Parameters.AddWithValue("@username",user.UserName);
        string EncryptedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(user.Password, "SHA1");
        cmd.Parameters.AddWithValue("@password", EncryptedPassword);
        cmd.Parameters.AddWithValue("@customerid", user.CustomerId);

        try
        {
            con.Open();
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
            {
                return true;        //insert new user successfully

            }
            else
                return false;       //did not insert user


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

    public static bool GetExistUser(int customerid)
    {
        SqlConnection con = new SqlConnection(TravelExpertDB.GetConnectionString());

        string strstate = "SELECT UserName,Password,CustomerId FROM Users WHERE CustomerId=@customeid";

        SqlCommand cmd = new SqlCommand(strstate, con);

        
        cmd.Parameters.AddWithValue("@customerid", customerid);

        try
        {
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return true;        //there is customer

            }
            else
            {
                return false;
            }
        

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

    public static User GetUser(int customerid)
    {
        SqlConnection con = new SqlConnection(TravelExpertDB.GetConnectionString());
        User user = new User();

        string strstate = "SELECT Id,UserName,Password,CustomerId FROM Users WHERE CustomerId=@customerid";

        SqlCommand cmd = new SqlCommand(strstate, con);


        cmd.Parameters.AddWithValue("@customerid", customerid);

        try
        {
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                user.Id = (int)dr[0];
                user.UserName = dr[1].ToString();
                user.Password = dr[2].ToString();
                user.CustomerId = (int)dr[3];

            }
            return user;
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

    public static int SuccessLog(string username, string password)
    {
        SqlConnection con = new SqlConnection(TravelExpertDB.GetConnectionString());

        string selstate = "select UserName,Password,CustomerId FROM USERS WHERE UserName=@username AND Password=@password";

        SqlCommand cmd = new SqlCommand(selstate, con);

        cmd.Parameters.AddWithValue("@username", username);
        string EncryptedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(password, "SHA1");
        cmd.Parameters.AddWithValue("@password", EncryptedPassword);

        try
        {
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int customerid = (int)dr[2];
                return customerid;

            }
            else
            {
                return -1;       //did not insert user
            }


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

    public static bool UpdatePassword(User user)
    {
        SqlConnection con = new SqlConnection(TravelExpertDB.GetConnectionString());

        string Upstate = "UPDATE Users SET Password = @Password WHERE Id=@id";

        SqlCommand cmd = new SqlCommand(Upstate, con);

        string EncryptedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(user.Password, "SHA1");
        if(EncryptedPassword != null)

        cmd.Parameters.AddWithValue("@password", EncryptedPassword);
        cmd.Parameters.AddWithValue("@id", user.Id);

        try
        {
            con.Open();
            
            int count= cmd.ExecuteNonQuery();
            if (count > 0)
                return true;
            else
                return false;


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