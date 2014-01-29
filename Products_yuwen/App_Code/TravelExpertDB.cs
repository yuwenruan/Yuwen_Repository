using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
/// <summary>
/// Summary description for TravelExpertDB
/// </summary>
public static class TravelExpertDB
{
    public static string GetConnectionString()
    {
        return ConfigurationManager.ConnectionStrings
            ["TravelExpertsConnectionString"].ConnectionString;
    }
}