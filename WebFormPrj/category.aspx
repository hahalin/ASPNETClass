<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="category.aspx.cs" Inherits="WebFormPrj.category" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <asp:Label ID="lbCategory" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="244px" Width="638px">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="編號">
                <HeaderStyle Font-Bold="True" Font-Size="18px" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="cname" HeaderText="品名" />
            </Columns>
        </asp:GridView>
        <br />
        
    </div>
    </form>
</body>
</html>
