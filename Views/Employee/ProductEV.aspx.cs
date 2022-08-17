using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FarmerMarket.Views.Employee
{
    public partial class ProductV : System.Web.UI.Page
    {
        Models.SqlFunction Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.SqlFunction();
            ShowProducts();
        }

        public override void VerifyRenderingInServerForm(Control control)
        {
        }

        private void ShowProducts()
        {
            string Query = "select * from ProductsTbl";
            ProductsGV.DataSource = Con.getData(Query);
            ProductsGV.DataBind();
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PNameTb.Value == "" || PrCatTb.Value == "" || PriceTb.Value == "" || ProdQtyTb.Value == "" || ExpDate.Value == "")
                {
                    ErrMsg.InnerText = "Missing Data";
                }
                else
                {
                    string PName = PNameTb.Value;
                    string PCat = PrCatTb.Value;
                    string PPrice = PriceTb.Value;
                    string PQty = ProdQtyTb.Value;
                    string PExpDate = ExpDate.Value;



                    string Query = "update ProductsTbl set PrName='{0}',PrCat='{1}',PrPrice='{2}',PrQty ='{3}',ExpDate = '{4}' where PrId = {5}";
                    Query = string.Format(Query, PName, PCat, PPrice, PQty, PExpDate, ProductsGV.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowProducts();
                    ErrMsg.InnerText = "Product Updated!!!";
                }

            }
            catch (Exception Ex)
            {

                ErrMsg.InnerText = Ex.Message;
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ExpDate.Value == "")
                {
                    ErrMsg.InnerText = "Missing Data";
                }
                else
                {


                    string Query = "delete from ProductsTbl where PrId = {0}";
                    Query = string.Format(Query, ProductsGV.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowProducts();
                    ErrMsg.InnerText = "Farmer Deleted!!!";
                }

            }
            catch (Exception Ex)
            {

                ErrMsg.InnerText = Ex.Message;
            }
        }
        int Key = 0;
        protected void ProductsGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            PNameTb.Value = ProductsGV.SelectedRow.Cells[2].Text;
            PrCatTb.Value = ProductsGV.SelectedRow.Cells[3].Text;
            PriceTb.Value = ProductsGV.SelectedRow.Cells[4].Text;
            ProdQtyTb.Value = ProductsGV.SelectedRow.Cells[5].Text;
            ExpDate.Value = ProductsGV.SelectedRow.Cells[6].Text;
            if (PNameTb.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ProductsGV.SelectedRow.Cells[1].Text);
            }
        }
    }
} /*Code Attribution:
         MyCodeSpace, 2022. Online Grocery Shop Management System Using ASP.Net C# and SQL Server. [video] Available at: <https://youtu.be/LzEecpaWfbs> [Accessed 14 June 2022].*/