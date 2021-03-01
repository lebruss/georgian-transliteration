<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Translation.WebForm1" %>

<!DOCTYPE html>
<html lang="en">
<head>
  <title>Bootstrap 4 Examples</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>
  <link href="default.css" rel="stylesheet" />


</head>
<body>
    <div id=header>Geotranslate</div>
	
	<div id=login>
        
        <li><a href=DatabaseTest.aspx>Login Page [test]</a></li>

    </div>
	<br />
	<div id=navigation>
		<p>Options პარამეტრები</p>
	<ul>
		<li><a href=WebForm1.aspx>English-alphabet Georgian translate</a></li>
		<li><a href=WebForm4.aspx>About Xinkalinglish</a></li>
		<li><a href=WebForm5.aspx>Feedback & Contact</a></li>
	</ul>
	</div>
	
	
	<div id=content>
		
		<h1>Homonym Correction</h1>
		<div class="text-center">
			<img src="images/homonym.PNG" />
		</div>
        
	</div> <!-- for id=content -->

	
	<div id=footer>&copy; Caleb Russell 2020</div>
     </body>
    </html>
