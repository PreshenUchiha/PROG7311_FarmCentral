using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FarmerMarket.Views.Employee
{
    public partial class Farmer : System.Web.UI.Page
    {
        Models.SqlFunction Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.SqlFunction();
            ShowFarmers();
        }

        public override void VerifyRenderingInServerForm(Control control)
        {
        }
        private void ShowFarmers() 
        {
            string Query = "select * from FarmerTbl";
            FarmerGV.DataSource = Con.getData(Query);
            FarmerGV.DataBind();

        }
        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (FarmerPassTb.Value == "" || FEmailTb.Value == "" || FNameTb.Value == "" || FarmerPhoneTb.Value == "" || FarmerAddressTb.Value == "")
                {
                    ErrMsg.InnerText = "Missing Data";
                }else
                {
                    string FName = FNameTb.Value;
                    string FEmail = FEmailTb.Value;
                    string Password = FarmerPassTb.Value;
                    string Phone = FarmerPhoneTb.Value;
                    string Address = FarmerAddressTb.Value;


                    string Query = "insert into FarmerTbl values('{0}','{1}','{2}','{3}','{4}')";
                    Query = string.Format(Query, FName, FEmail, Password, Phone, Address);
                    Con.SetData(Query);
                    ShowFarmers();
                    ErrMsg.InnerText = "Farmer Added!!!";
                }
                
            }
            catch (Exception Ex)
            {

                ErrMsg.InnerText = Ex.Message;
            }
        }
        int Key = 0;
        protected void FarmerGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            FNameTb.Value = FarmerGV.SelectedRow.Cells[2].Text;
            FEmailTb.Value = FarmerGV.SelectedRow.Cells[3].Text;
            FarmerPassTb.Value = FarmerGV.SelectedRow.Cells[4].Text;
            FarmerPhoneTb.Value = FarmerGV.SelectedRow.Cells[5].Text;
            FarmerAddressTb.Value = FarmerGV.SelectedRow.Cells[6].Text;
            if (FNameTb.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(FarmerGV.SelectedRow.Cells[1].Text);
            }

        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (FarmerPassTb.Value == "" || FEmailTb.Value == "" || FNameTb.Value == "" || FarmerPhoneTb.Value == "" || FarmerAddressTb.Value == "")
                {
                    ErrMsg.InnerText = "Missing Data";
                }
                else
                {
                    string FName = FNameTb.Value;
                    string FEmail = FEmailTb.Value;
                    string Password = FarmerPassTb.Value;
                    string Phone = FarmerPhoneTb.Value;
                    string Address = FarmerAddressTb.Value;


                    string Query = "update FarmerTbl set FarmerName='{0}',FarmerEmail='{1}',FarmerPassword='{2}',FarmerPhone ='{3}',FarmerAddress = '{4}' where FarmerId = {5}";
                    Query = string.Format(Query, FName, FEmail, Password, Phone, Address, FarmerGV.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowFarmers();
                    ErrMsg.InnerText = "Farmer Updated!!!";
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
                if (FarmerPassTb.Value == "")
                {
                    ErrMsg.InnerText = "Missing Data";
                }
                else
                {


                    string Query = "delete from FarmerTbl where FarmerId = {0}";
                    Query = string.Format(Query, FarmerGV.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowFarmers();
                    ErrMsg.InnerText = "Farmer Deleted!!!";
                }

            }
            catch (Exception Ex)
            {

                ErrMsg.InnerText = Ex.Message;
            }
        }
    }
}