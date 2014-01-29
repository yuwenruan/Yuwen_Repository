using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

/// <summary>
/// Summary description for Package
/// </summary>

public class Package
{	
    //constructor
    public Package() { }  
    //properties
    public int PackageId { get; set; }
    public string PkgName { get; set; }
    public DateTime PkgStartDate { get; set; }
    public DateTime PkgEndDate { get; set; }
    public string PkgDesc { get; set; }
    public decimal PkgBasePrice { get; set; }
    public decimal PkgAgencyCommission { get; set; }
}