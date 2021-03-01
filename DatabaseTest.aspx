<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DatabaseTest.aspx.cs" Inherits="Translation.DatabaseTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
        <div>
            <table style="margin:auto; border:5px solid white">
                <tr>
                    <td>
                        <asp:Label ID="userlbl" runat="server" Text="UserName"></asp:Label>
                    </td>

                    <td>
                        <asp:TextBox ID="TextUserName" runat="server"></asp:TextBox>
                    </td>

                    <td>
                        <asp:Label ID="passlbl" runat="server" Text="Password"></asp:Label>
                    </td>

                    <td>
                        <asp:TextBox ID="TextPassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>

                </tr>

                <tr>
                    
                    <td>
                        <asp:Button ID="btnlogin" runat="server" Text="Login" OnClick="btnlogin_Click"/>
                    </td>

                    <td>
                        <asp:Button ID="btnback" runat="server" Text="Back" OnClick="btnback_Click"/>
                    </td>

                    <td>
                        <asp:Button ID="btnforgot" runat="server" Text="Forgot password?" OnClick="btnforgot_Click"/>
                    </td>


                </tr>

                <br />

                <%--<tr>
                    <asp:Button ID="btnCreateProfile" runat="server" Text="Create Profile" OnClick="btnCreateProfile_Click"/>
                </tr>--%>

                
                 <tr>
                    
                    <td>
                        <asp:Label ID="lblConnectionStatus" runat="server" ForeColor="Red"> </asp:Label>
                    </td>

                </tr>
                


            </table>

    </form>
    </div>
</body>
</html>
