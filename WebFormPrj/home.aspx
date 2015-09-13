<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="WebFormPrj.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="css/main.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <br />
            <asp:Label ID="Label1" runat="server" Text="使用者名稱"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            &nbsp;<asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            </br>
        <ul>
            <asp:ListView ID="ListView1" runat="server">


                <ItemTemplate>

                    <li class="menuli mainnav">
                        <a href="category.aspx?id=<%# Eval("id") %>" target="_blank">
                            <%#Eval("cname") %>
                        </a>
                    </li>
                </ItemTemplate>

            </asp:ListView>
        </ul>


        </div>
    </form>
</body>
</html>
