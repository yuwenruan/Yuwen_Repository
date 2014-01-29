using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BookingProduct
/// </summary>
public class BookingProduct
{
    public BookingProduct() { }

    public string ProdName { get; set; }
    public string Description { get; set; }
    public string Destination { get; set; }
    public DateTime TripStart { get; set; }
    public DateTime TripEnd { get; set; }   
    public decimal BasePrice { get; set; }
    public decimal AgencyCommission { get; set; }

}