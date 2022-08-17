<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Employee/EmployeeMaster.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="FarmerMarket.Views.Employee.Categories" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
    <div class="container-fluid">
    <div class="row">
        <div class="col-md4"></div>
        <div class="col-md8"><br /><img src="../../Asset/Images/icons8-vegetarian-food-50.png"/></div>

    </div>
        <div class="row">
    <div class="col-md-4">
        <h2 class="text-info">Category Details</h2>
     
             <div class="mb-3">
    <label for="exampleInputPassword1" class="form-label">Category Name </label>
    <input type="text" class="form-control" id="CatNameTb" runat="server">
 
                 </div>
              <div class="mb-3">
    <label for="exampleInputPassword1" class="form-label">Category Remarks  </label>
    <input type="text" class="form-control" id="CatRemarkTb" runat="server">
 
                 </div>
            <br /><br /><br />
                <label id="ErrMsg" runat="server" class="text-danger"></label><br />
        <asp:Button text="  Edit  " CssClass="btn btn-success" runat="server" ID="EdiBtn" OnClick="EdiBtn_Click"/>
        <asp:Button text="  Save  " CssClass="btn btn-success" runat="server" ID="SaveBtn" OnClick="SaveBtn_Click"/>
        <asp:Button text="Delete" CssClass="btn btn-success" runat="server" ID="DeleteBtn" OnClick="DeleteBtn_Click"/>

    </div>
     <div class="col-md-8">
         <h2 class="text-info">Manage Categories</h2>
         <asp:GridView runat="server" class="table table-hover" ID="CategoryGV" AutoGenerateSelectButton="True" OnSelectedIndexChanged="CategoryGV_SelectedIndexChanged" >

</asp:GridView>
     </div>

    </div>

    </div>
</asp:Content>
