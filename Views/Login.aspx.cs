using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FarmerMarket.Views
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.SqlFunction();
        }
        public static string FName;
        int SKey;

        Models.SqlFunction Con;
        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            if (AdminRadio.Checked)
            {
                if (EmailId.Value == "Admin@gmail.com" && UserPasswordId.Value == "Admin")
                {
                    Response.Redirect("Employee/Farmer.aspx");
                }
                else
                {
                    InfoMsg.InnerText = "Invalid Admin!!!!!";
                }
            }
            else
            {
                string Query = "select FarmerId,FarmerName,FarmerEmail,FarmerPassword from FarmerTbl where FarmerEmail = '{0}' and FarmerPassword = '{1}'";
                Query = string.Format(Query, EmailId.Value, UserPasswordId.Value);
                DataTable dt = Con.getData(Query);
                if(dt.Rows.Count == 0)
                {
                    InfoMsg.InnerText = "Invalid User!";
                }
                else
                {
                    FName = EmailId.Value;
                    SKey = Convert.ToInt32(dt.Rows[0][0].ToString());
                    Response.Redirect("Employee/Products.aspx");
                }

            }
        }
    }
} /*Code Attribution:
         MyCodeSpace, 2022. Online Grocery Shop Management System Using ASP.Net C# and SQL Server. [video] Available at: <https://youtu.be/LzEecpaWfbs> [Accessed 14 June 2022].*/