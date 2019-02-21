<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Developer.aspx.cs" Inherits="Developer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head >
<script src = '/jquery-1.12.4.js' type = 'text/javascript'></script>
  <script>

function copyToClipboard(element) {
  var $temp = $("<input>");
  $("body").append($temp);
  $temp.val($(element).text()).select();
  document.execCommand("copy");
  $temp.remove();






  
  }
$(function () {
    $(".e").linedtextarea(
		{ selectedLine: 1 }
	);
});


function myfunction() {
    var str = "Hello World!";
    var result = str.fontcolor("green");
    document.getElementById("TextBox1").innerHTML = result;
}



</script>
<script>
$(function() {
	$(".lined").linedtextarea(
		{selectedLine: 1}
	);
});
</script>

    <style>

ul {
    list-style-type: none;
    margin: 0;
    padding: 0;
    overflow: hidden;
    background-color: #333;

}

li {
    float: right;
   
}

li a {
    display: block;
    color: white;
    text-align: center;
    padding: 14px 16px;
    text-decoration: none;
}

li a:hover {
    background-color: #111;
}
h1{
  color: #b6ff00; 
  font-family: "Courier";
  font-size:32px;
  
  white-space: nowrap;
  overflow: hidden;
  width: 30em;
  text-shadow: 2px 2px 5px black;
  animation: type 4s steps(60, end); 
}


</style>
    <?php

        echo "Hello";
        ?>
          
<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.3.2/jquery.min.js"></script>
	<script src="jquery-linedtextarea.js"></script>
	<link href="jquery-linedtextarea.css" type="text/css" rel="stylesheet" />

<script src="https://ajax.googleapis.com/ajax/libs/jquery/2.0.0/jquery.min.js"></script>
<link href='https://fonts.googleapis.com/css?family=Oswald' rel='stylesheet' type='text/css'> 

<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>


</head>
   
<body>
 <ul>
  <li><a href="Default.aspx">Log Out</a></li>
  <li><a href="#contact">About</a></li>
  <li><a href="#about">Contact</a></li>
      <li><a href="#wiki">Wiki</a></li>
  <li><a class="active" href="Default.aspx">Home</a></li>
     <li Style="width:42%; margin-left:18px; float:left"><h3 style="color:white;width:100%">CODE TRANSLATOR (Developer Mode)</h3></li>
</ul>

       
    <form id="form1" runat="server">
      
   
    <div>
    
        <div style="width:50%; float:left"><h3  style="margin-left:25px;">C</h3>
    

        



            
<button style="float:right;margin-right:42px;  "  onclick="copyToClipboard('#TextBox1')">Copy To Clipboard</button><br />

  
            
            
   <asp:TextBox id="TextBox1"  runat="server" class="lined" SpellCheck="false"   Height="328px" Width="90%" style="float:left; background-color:	#F8F8FF; margin-left:25px;  resize:none" TextMode="MultiLine" Rows="10"       ></asp:TextBox>
            
          <asp:Button ID="Button3" class="btn btn-primary" runat="server"  Text="Test" style="margin-bottom: 0px;margin-left:25px" OnClick="Button1_Click"  />  </div>
        <div style="width:50%; float:left"><h3 style="margin-left:25px ;">C#</h3>
           
            <button style="float:right;margin-right:42px";  onclick="copyToClipboard('#TextBox2')">Copy To Clipboard</button>
        <asp:TextBox ID="TextBox2" runat="server" spellcheck="false" Height="328px" Width="90%" style=" margin-left: 25px; background-color:	#F8F8FF; resize:none" TextMode="MultiLine"  Rows="10" OnKeyUp="onTextBox1Change(this)" ></asp:TextBox>
     <asp:Button ID="Button2" class="btn btn-primary" runat="server" OnClientClick="return confirm('Are you sure to contribute?')" Text="Contribute" style="margin-bottom: 0px;margin-left:25px" OnClick="Button2_Click" />
         </div>
            <p>
     
            
     <tb></tb><tb></tb>
           
            </div>
    </form>
</body>
</html>