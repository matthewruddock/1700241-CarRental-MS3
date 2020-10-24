using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace _1700241_CarRental_MS2
{
    public partial class Products : System.Web.UI.Page
    { 
        Cart myCart;

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                dlProducts.DataSource = DataAccess.selectQuery("SELECT * FROM Products");
                dlProducts.DataBind();
            }
            
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            /*
            if(Session["myCart"] == null)
            {
               this.myCart = new Cart();
               Session["myCart"]= myCart;
            }
            //Request.QueryString is null, find go-around
            string id = Request.QueryString["id"];

            myCart = (Cart)Session["myCart"];

            DataTable dt = DataAccess.selectQuery("SELECT * FROM Products WHERE id="+ id);
            DataRow row = dt.Rows[0];
            
            //Data is not populating in row
            myCart.Insert(new Cars(
                Int32.Parse("id"), 
                row["year"].ToString(),
                row["make"].ToString(),
                row["model"].ToString(),
                row["type"].ToString(),
                row["description"].ToString(),
                float.Parse(row["cost"].ToString()),
                row["image"].ToString(),
                1)
           );

            */
        }

       
    }
}