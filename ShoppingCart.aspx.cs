using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Configuration;

namespace _1700241_CarRental_MS2
{
    public partial class ShoppingCart : System.Web.UI.Page {

        Cart myCart;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["myCart"] == null)
            {
                Session["myCart"] = new Cart();
            }

            myCart = (Cart)Session["myCart"];

            if (!IsPostBack)
            {
                FillData();
            }
        }

        private void FillData()
        {
            gvShoppingCart.DataSource = myCart.CarsList;
            gvShoppingCart.DataBind();

            if (myCart.CarsList.Count == 0)
            {
                lblGrandTotal.Visible = false;
                cartStatus.Text = "Cart is empty";
                cartStatus.Visible = true;
            }
            else
            {
                lblGrandTotal.Text = string.Format("Grand Total = {0,19:C}", myCart.GrandTotal);
                lblGrandTotal.Visible = true;
                btnCheckout.Visible = true;
            }
        }
        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            Response.Redirect("OrderDetails.aspx");
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void getShoppingCart_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvShoppingCart.EditIndex = -1;
            FillData();
        }

        protected void getShoppingCart_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            myCart.Delete(e.RowIndex);
            FillData();
        }

        protected void getShoppingCart_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            TextBox txtQuantity = (TextBox)gvShoppingCart.Rows[e.RowIndex].Cells[5].Controls[0];
            int quantity = Int32.Parse(txtQuantity.Text);
            myCart.Update(e.RowIndex, quantity);
            gvShoppingCart.EditIndex = -1;
            FillData();
        }

        protected void getShoppingCart_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvShoppingCart.EditIndex = e.NewEditIndex;
            FillData();
        }
    }
}