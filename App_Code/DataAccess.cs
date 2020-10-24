using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace _1700241_CarRental_MS2
{
    public static class DataAccess
    {
        private static string DefaultConnectionString;
        static DataAccess()
        {
            DefaultConnectionString = WebConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        }

        public static DataTable selectQuery(string query)
        {
            DataTable dt = new DataTable();
            SqlConnection cnn = new SqlConnection(DefaultConnectionString);
            cnn.Open();

            SqlCommand cmd = new SqlCommand(query, cnn);
            dt.Load(cmd.ExecuteReader());
            cnn.Close();
            return dt;
        }
    }
}