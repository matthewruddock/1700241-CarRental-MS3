using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace _1700241_CarRental_MS2
{
    public class Cars
    {
        public int Id { get; set; }
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public string Type { get; set; }
        public string Description { get; set; }
        public float Cost { get; set; }
        public string Image { get; set; }
        public int Qty{ get; set; }
        

        public Cars()
        {
            
            this.Id = 0;
            this.Year = "none";
            this.Make = "none";
            this.Model = "none";
            this.Type = "none";
            this.Description = "none";
            this.Cost = 0;
            this.Image = "none";
            this.Qty = 0;
            
        }

        public Cars(int id, string year, string make, string model,string type, string description, float cost, string image, int qty)
        {
            this.Id = id;
            this.Year = year;
            this.Make = make;
            this.Model = model;
            this.Type = type;
            this.Description = description;
            this.Cost = cost;
            this.Image = image;
            this.Qty = qty;
        }

    }
}