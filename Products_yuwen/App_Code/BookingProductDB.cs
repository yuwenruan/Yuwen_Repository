using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
/// <summary>
/// Summary description for BookingProductDB
/// </summary>
[DataObject(true)]
public static class BookingProductDB
{
    [DataObjectMethod(DataObjectMethodType.Select)]
    public static List<BookingProduct> GetBookingProductById(int customerId)
    {
        SqlConnection con = new SqlConnection(TravelExpertDB.GetConnectionString());
        List<BookingProduct> bookingproducts = new List<BookingProduct>();

        string sel = "SELECT p.ProdName, bd.Description,bd.Destination, " +
                    "bd.TripStart, bd.TripEnd, bd.BasePrice,bd.AgencyCommission " +
                    "FROM Products p,Customers c, Bookings b,BookingDetails bd, " +
                    "Products_Suppliers ps " +
                    "where c.CustomerId=b.CustomerId AND " +
                    "b.BookingId=bd.BookingId AND " +
                    " bd.ProductSupplierId = ps.ProductSupplierId AND " +
                    "ps.ProductId=p.ProductId AND c.CustomerId=@CustomerId ";
        SqlCommand cmd = new SqlCommand(sel, con);
        cmd.Parameters.AddWithValue("@CustomerId", customerId);
        try
        {
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            bookingproducts.Clear();
            while (dr.Read())
            {
                //"SELECT p.ProdName, bd.Description,bd.Destination, " +
                //    "bd.TripStart, bd.TripEnd, bd.BasePrice,bd.AgencyCommission " 
                BookingProduct bookingproduct = new BookingProduct();
                bookingproduct.ProdName = dr[0].ToString();
                bookingproduct.Description= dr[1].ToString();
                bookingproduct.Destination=dr[2].ToString();
                bookingproduct.TripStart = dr[3] as DateTime? ?? default(DateTime);
                bookingproduct.TripEnd = dr[4] as DateTime? ?? default(DateTime);
                bookingproduct.BasePrice = dr[5] as decimal? ?? default(decimal);
                bookingproduct.AgencyCommission = dr[6] as decimal? ?? default(decimal);
                //                sumSpending += package.PkgBasePrice + package.PkgAgencyCommission;
                bookingproducts.Add(bookingproduct);
            }
            return bookingproducts;
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

    [DataObjectMethod(DataObjectMethodType.Select)]
    public static double GetBookingProductTotal(int customerId)
    {
        double sum = 0;
        SqlConnection con = new SqlConnection(TravelExpertDB.GetConnectionString());        

        string sel = "SELECT sum( bd.BasePrice),sum(bd.AgencyCommission) " +
                    "FROM Products p,Customers c, Bookings b,BookingDetails bd, " +
                    "Products_Suppliers ps " +
                    "where c.CustomerId=b.CustomerId AND " +
                    "b.BookingId=bd.BookingId AND " +
                    " bd.ProductSupplierId = ps.ProductSupplierId AND " +
                    "ps.ProductId=p.ProductId AND c.CustomerId=@CustomerId ";
        SqlCommand cmd = new SqlCommand(sel, con);
        cmd.Parameters.AddWithValue("@CustomerId", customerId);
        try
        {
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                sum += Convert.ToDouble(dr[0]) + Convert.ToDouble(dr[1]);
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