<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FarmerMarket.Views.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Login </title>
         <link rel =" stylesheet" href ="../Asset/Lib/Bootstrap/css/bootstrap.min.css" /> 
</head>
<body>
    <%--<form id="form1" runat="server">
        <div>


        </div>
    </form>--%>
    <div class="container-fluid">
<div class="row" style ="height :90px" > </div>
        <div class ="row" > </div>
        <div class ="col-md-2"></div>
         <div class ="col-md-4">
             <img src="../Asset/Images/Grocery.jpg" class ="img-fluid" /> 
             <!--2022. Vegetable Food. [image] Available at: <https://icons8.com/icons/set/vegetable-food> [Accessed 13 June 2022].-->
         </div>
         <div class ="col-md-4 shadow-lg">
             <h1 class="text-success"> Login In</h1>
             <form runat ="server">
                 <div class="mb-3">
    <label for="EmailId" class="form-label">Email address</label>
    <input type="email" class="form-control" id="EmailId" runat="server" required="required" >
   
  </div>
  <div class="mb-3">
    <label for="UserPassword" class="form-label">Password</label>
    <input type="password" class="form-control" id="UserPasswordId" runat="server" required="required">
  </div>
  <div class="mb-3 form-group">
    <input type="radio" class="form-check-input" id="SellerRadio" name="Role" runat="server">
    <label class="form-check-label" for="exampleCheck1">Farmer</label>
  <input type="radio" class="form-check-input" id="AdminRadio" checked="true" name ="Role" runat="server">
    <label class="form-check-label" for="AdminRadio" >Employee</label>
      </div>

                 <div class="mb-3 d-grid">
                     <label id="InfoMsg" runat="server" class="text-danger"></label>
                             <asp:Button text="  Login  " class="btn btn-success btn-block" runat="server" ID="SaveBtn" OnClick="SaveBtn_Click" />

  </div>
             </form>
         </div>
    </div>
</body>
</html>
