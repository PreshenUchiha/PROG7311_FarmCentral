<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Employee/EmployeeMaster.Master" AutoEventWireup="true" CodeBehind="Farmer.aspx.cs" Inherits="FarmerMarket.Views.Employee.Farmer" %>
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
        <h2 class="text-success">Details of Farmer</h2>
     
             <div class="mb-3">
    <label for="FNameTb" class="form-label">Farmer Name </label>
    <input type="text" class="form-control" id="FNameTb" runat="server">
 
                 </div>
              <div class="mb-3">
    <label for="FEmailTb" class="form-label">Farmer Email </label>
    <input type="email" class="form-control" id="FEmailTb" runat="server">
 
                 </div>
            <div class="mb-3">
    <label for="exampleInputPassword1" class="form-label">Farmer Password </label>
    <input type="password" class="form-control" id="FarmerPassTb" runat="server">
 
                 </div>
        <div class="mb-3">
    <label for="exampleInputPassword1" class="form-label">Farmer Phone </label>
    <input type="text" class="form-control" id="FarmerPhoneTb" runat="server">
 
                 </div>
        <div class="mb-3">
    <label for="exampleInputPassword1" class="form-label">Farmer Address</label>
    <input type="text" class="form-control" id="FarmerAddressTb" runat="server">
 
                 </div>
        <label id="ErrMsg" runat="server" class="text-danger"></label><br />
        <asp:Button text="  Edit  " CssClass="btn btn-success" runat="server" ID="EditBtn" OnClick="EditBtn_Click"/>
        <asp:Button text="  Save  " CssClass="btn btn-success" runat="server" ID="SaveBtn" OnClick="SaveBtn_Click"/>
        <asp:Button text="Delete" CssClass="btn btn-success" runat="server" ID="DeleteBtn" OnClick="DeleteBtn_Click"/>

    </div>
     <div class="col-md-8">
         <h2 class="text-info">Manage Farmers</h2>
<asp:GridView runat="server" class="table table-hover" ID="FarmerGV" AutoGenerateSelectButton="True" OnSelectedIndexChanged="FarmerGV_SelectedIndexChanged">

</asp:GridView>
     </div>

    </div>

    </div>
</asp:Content>
