using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Globalization;

namespace _1700241_CarRental_MS2
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        Cart myCart;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request.QueryString["id"];
                if (id != null)
                {
                    dlProductDetails.DataSource = DataAccess.selectQuery("SELECT * FROM Products WHERE id= " + id);
                    dlProductDetails.DataBind();
                }
            }
        }

        protected void Selection_Change1(Object sender, EventArgs e)
        {
            startDate.Text = Calendar1.SelectedDate.ToShortDateString();
        }
        protected void Selection_Change2(Object sender, EventArgs e)
        {
            endDate.Text = Calendar2.SelectedDate.ToShortDateString();
        }

        protected void btnAddToCart_ProDetail_Click(object sender, EventArgs e)
        {/*
            if (startDate.Text != "" && endDate.Text != "")
            {
                //Storing input Dates  
                DateTime StartDate = Convert.ToDateTime(startDate.Text);
                DateTime EndDate = Convert.ToDateTime(endDate.Text);

                //Creating object of TimeSpan Class  
                TimeSpan objTimeSpan = EndDate - StartDate;

                //TotalDays  
                double Days = Convert.ToDouble(objTimeSpan.TotalDays);
            }
            */
            if (Session["myCart"] == null)
            {
                this.myCart = new Cart();
                Session["myCart"] = myCart;
            }
            string id = Request.QueryString["id"];

            myCart = (Cart)Session["myCart"];

            DataTable dt = DataAccess.selectQuery("SELECT * FROM Products WHERE id = " + id);
            DataRow row = dt.Rows[0];

            myCart.Insert(new Cars(
                Int32.Parse(id),
                row["year"].ToString(),
                row["make"].ToString(),
                row["model"].ToString(),
                row["type"].ToString(),
                row["description"].ToString(),
                float.Parse(row["cost"].ToString()),
                row["image"].ToString(),
                1)
           );



        }
    }
}