<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LogIn.aspx.cs" Inherits="LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server"></head>
   
<body>
 <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

<style> 
body,
html {
  height: 100%;
  min-height: 600px;
  min-width: 800px;
  overflow: hidden;
  margin: 0;
  padding: 0;
}
html {
  overflow: auto;
}
form {
  height: 100%;
}


</style>
    <div style="height:100%;"">
<div style="width:50%;height:100%; float:left;">
<h1 style="padding-left:20px;">Welcome</h1>
    <br />
    <br />
<h3 style="padding-left:20px;">Develop our community</h3>
<h3 style="padding-left:20px;">Help to learn programming languages</h3>
<h3 style="padding-left:20px;">More language are comming</h3>


</div>
<div style="width:50%;height:100%; float:left;background-color:black" >
<h1 style="color:white;padding-left:20px;">Sign In </h1>
<form  runat="server"  style="padding-left:50px;padding-top:20px;" >
    <div  class="form-group">
      <label style="color:white;" for="email">Email:</label>
      <asp:Textbox  runat="server"  style="width:60%;" class="form-control" id="email" placeholder="Enter email" name="email"/>
    </div>
    <div class="form-group">
      <label style="color:white;" for="pwd">Password:</label>
      <asp:Textbox runat="server" type="password" style="width:60%;" class="form-control" id="pwd" placeholder="Enter password" name="pwd"/>
    </div>
    <div style="color:white;" class="checkbox">
      <label><input type="checkbox" style="color:white;" name="remember"/> Remember me</label>
    </div>
    <asp:Button  ID="button1" runat="server"  Text="Submit" class="btn btn-default" OnClick="button1_Click"/>
  </form>


</div>
        </div>
</body>




</html>
