using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1700241_CarRental_MS2
{
    public class Cart
    {
        public List<Cars> CarsList { get; set; }

        public Cart()
        {
            CarsList = new List<Cars>();

        }
        private int CarsListIndexOf(int ID)
        {
            foreach (Cars item in CarsList)
            {
                if (item.Id == ID)
                {
                    return CarsList.IndexOf(item);
                }
            }
            return -1;
        }

        public void Insert(Cars item)
        {
            int index = CarsListIndexOf(item.Id);
            if (index == -1)
            {
                CarsList.Add(item);
            }
            else
            {
                CarsList[index].Qty++;
            }
        }

        public void Delete(int rowID)
        {
            CarsList.RemoveAt(rowID);
        }

        public void Update(int rowID, int Qty)
        {
            if (Qty > 0)
            {
                CarsList[rowID].Qty = Qty;
            }
            else
            {
                Delete(rowID);
            }
        }

        public float GrandTotal
        {
            get
            {
                if (CarsList == null)
                {
                    return 0;
                }
                else
                {
                    float grandTotal = 0;
                    foreach (Cars item in CarsList)
                    {
                        grandTotal += item.Qty * item.Cost;
                    }
                    return grandTotal;
                }
            }
        }
    }
}