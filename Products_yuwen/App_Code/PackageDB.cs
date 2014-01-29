using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

/// <summary>
/// Summary description for PackageDB
/// </summary>
/// 
[DataObject(true)]
public static class PackageDB
{
   // public decimal sumSpending;

    [DataObjectMethod(DataObjectMethodType.Select)]
    public static List<Package> GetProductsByCustomerId(int customerId)
    {
        SqlConnection con = new SqlConnection(TravelExpertDB.GetConnectionString());
        List<Package> packages = new List<Package>();
        
        string sel = "SELECT p.PackageId,p.PkgName, p.PkgStartDate,p.PkgEndDate, " +
                    "p.PkgDesc,p.PkgBasePrice,p.PkgAgencyCommission  " +
                    "FROM Packages p,Customers c, Bookings b,BookingDetails bd, " +
                    "Packages_Products_Suppliers pps " +
                    "where c.CustomerId=b.CustomerId AND " +
                    "b.BookingId=bd.BookingId AND " +
                    " bd.ProductSupplierId = pps.ProductSupplierId AND " +
                    "pps.PackageId=p.PackageId AND c.CustomerId=@CustomerId ";
        SqlCommand cmd = new SqlCommand(sel, con);
        cmd.Parameters.AddWithValue("@CustomerId", customerId);
        try
        {
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            packages.Clear();
            while (dr.Read())
            {
                Package package = new Package();
                package.PackageId = (int)dr[0];
                package.PkgName=(string)dr[1];
                package.PkgStartDate = dr[2] as DateTime? ?? default(DateTime);
                package.PkgEndDate = dr[3] as DateTime? ?? default(DateTime);
                package.PkgDesc = (string)dr[4];
                package.PkgBasePrice = dr[5] as decimal? ?? default(decimal);
                package.PkgAgencyCommission = dr[6] as decimal? ?? default(decimal);
//                sumSpending += package.PkgBasePrice + package.PkgAgencyCommission;
                packages.Add(package);
            }
            return packages;
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

    public static decimal GetTotalMoneyById(int customerId)
    {
        SqlConnection con = new SqlConnection(TravelExpertDB.GetConnectionString());
        decimal sum = 0;

        string sel = "SELECT sum(p.PkgBasePrice),sum(p.PkgAgencyCommission)  " +
                    "FROM Packages p,Customers c, Bookings b,BookingDetails bd, " +
                    "Packages_Products_Suppliers pps " +
                    "where c.CustomerId=b.CustomerId AND " +
                    "b.BookingId=bd.BookingId AND " +
                    " bd.ProductSupplierId = pps.ProductSupplierId AND " +
                    "pps.PackageId=p.PackageId AND c.CustomerId=@CustomerId ";
        SqlCommand cmd = new SqlCommand(sel, con);
        cmd.Parameters.AddWithValue("@CustomerId", customerId);
        try
        {
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                sum += dr[0] as decimal? ?? default(decimal);
                sum += dr[1] as decimal? ?? default(decimal);
            }
            return sum;
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