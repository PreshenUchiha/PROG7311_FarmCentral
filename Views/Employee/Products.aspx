<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Employee/EmployeeMaster.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="FarmerMarket.Views.Employee.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
    <div class="container-fluid">
    <div class="row">
        <div class="col-md4"></div>
        <div class="col-md8"><img src="../../Asset/Images/icons8-vegetarian-food-50.png"/></div>

    </div>
        <div class="row">
    <div class="col-md-4">
        <h2 class="text-success">Details of Product</h2>
     
             <div class="mb-3">
    <label for="PNameTb" class="form-label">Product Name</label>
    <input type="text" class="form-control" id="PNameTb" runat="server">
 
                 </div>
               <div class="mb-3">
    <label for="PrCatTb" class="form-label">Product Category</label>
    <input type="text" class="form-control" id="PrCatTb" runat="server">
 
                 </div>
            <div class="mb-3">
    <label for="exampleInputPassword1" class="form-label">Product Price</label>
    <input type="number" class="form-control" id="PriceTb" runat="server">
 
                 </div>
        <div class="mb-3">
    <label for="exampleInputPassword1" class="form-label">Product Quantity</label>
    <input type="number" class="form-control" id="ProdQtyTb" runat="server">
 
                 </div>
        <div class="mb-3">
    <label for="exampleInputPassword1" class="form-label">Expiration Date</label>
    <input type="date" class="form-control" id="ExpDate" runat="server">
 
                 </div>
        <label id="ErrMsg" runat="server" class="text-danger"></label><br />
        <asp:Button text="  Save  " CssClass="btn btn-success" runat="server" ID="SaveBtn" OnClick="SaveBtn_Click"/>
        

    </div>
     <div class="col-md-8">
         <h2 class="text-info">Hello Farmer! Here Is Your Products</h2>
<asp:GridView runat="server" class="table table-hover" ID="ProductsGV" AutoGenerateSelectButton="True" OnSelectedIndexChanged="ProductsGV_SelectedIndexChanged">

</asp:GridView>
     </div>

    </div>

    </div>
</asp:Content>