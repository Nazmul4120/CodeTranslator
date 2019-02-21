<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

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

</script>

    <style media="screen"  >

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



body {
        overflow: hidden;
    }

    #editor {
       height:128px; 
           width:90%; 
           float:left; 
           font-size:medium;
           
           margin-left:25px;  
           
              
    }
 #editor1 {
       height:128px; 
           width:90%; 
           float:left; 
           font-size:medium;
           margin-left:25px;  
           
              
    }



</style>
   
          
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
  <li><a href="LogIn.aspx">Developer</a></li>
  <li><a href="#contact">About</a></li>
  <li><a href="#about">Contact</a></li>
  <li><a href="Wiki.aspx">Wiki</a></li>
  <li><a class="active" href="Default.aspx">Home</a></li>
     <li style="width:42%; margin-left:18px; float:left"><h3 style="color:white;width:75%">CODE TRANSLATOR</h3></li>
</ul>


    
    
   
    <div>
    
        <div style="width:50%; float:left"><h3  style="margin-left:25px;">C</h3>
    

        




          
            


  <div  id="editor" runat="server" onkeyup="er()"  ></div>

<script src="ace-builds-master/src-noconflict/ace.js" type="text/javascript" charset="utf-8"></script>

<script>

    
 var editor = ace.edit("editor");
 function er() {
     var editor = ace.edit("editor");
    
	    var myCode = editor.getSession().getValue();
	    
	        
	    
    var control = '<%=get.ClientID%>';
    document.getElementById(control).value = myCode;
    




 }




    editor.setTheme("ace/theme/twilight");
    editor.session.setMode("ace/mode/c_cpp");
  
  
</script>
           
   


            <button id="b1" onclick="qwe()" value="go" >go</button>
             <br />
           <form id="form1" runat="server">
            <asp:ScriptManager  ID="ScriptManager1" runat="server"></asp:ScriptManager>
 
 <asp:UpdatePanel ID="UpdatePanel1" runat="server" >
 <ContentTemplate>
     
     <input id="get" type="hidden" runat="server"    />
      <input id="getOut" type="hidden"  runat="server"    />
     <asp:Button ID="Button3" class="btn btn-primary" OnClientClick="ey()" onChange="er()" runat="server" Text="Go" style="margin-bottom: 0px;margin-left:25px" OnClick="Button1_Click"  /> 
      
     
  </div>
     
           


  </ContentTemplate>
     </asp:UpdatePanel>
              
       </form> 

           
            </div>
                
    <div  id="editor1"   ></div> 
       
<script src="ace-builds-master/src-noconflict/ace.js" type="text/javascript" charset="utf-8"></script>
<script>
    
    var editor = ace.edit("editor1");
    
   function ey() {
            
  //     editor.setValue('<%=Button3.Text%>');
                
   }
    editor.setShowPrintMargin(false);
    editor.setTheme("ace/theme/twilight");
    editor.session.setMode("ace/mode/csharp");

    
    
    
</script>
       <script>
           
          


       </script>
            
           
            </div>
   
</body>
</html>
