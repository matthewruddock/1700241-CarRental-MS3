using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1700241_CarRental_MS2.App_Code
{
    public class Order
    {
        //OrderID, CarID, Username, StartDate, EndDate, NumberOfDays, Subtotal
        public string OrderID { get; set; }
        public int CarID { get; set; }
        public string Username { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int NumberOfDays { get; set; }
        public float Subtotal { get; set; }

        public Order()
        {
            this.OrderID = "none";
            this.CarID = 0;
            this.Username = "none";
            this.StartDate = "none";
            this.EndDate = "none";
            this.NumberOfDays = 0;
            this.Subtotal = 0;
        }
        public Order(string orderid, int carid, string username, string startdate, string enddate, int nod, float subtotal)
        {
            this.OrderID = orderid;
            this.CarID = carid;
            this.Username = username;
            this.StartDate = startdate;
            this.EndDate = enddate;
            this.NumberOfDays = nod;
            this.Subtotal = subtotal;
        }
    }
}