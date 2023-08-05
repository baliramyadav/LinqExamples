<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LinqWithArray.aspx.cs" Inherits="LinqExamples.LinqWithArray" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LinqWithArray</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Get values > 40 using Imperative Code" Width="300px" OnClick="Button1_Click" /><br />
            <asp:Label ID="Label1" runat="server" ForeColor="Red" /><br />
            <asp:Button ID="Button2" runat="server" Text="Get values > 40 using Declarative Code" Width="300px" OnClick="Button2_Click" /><br />
            <asp:Label ID="Label2" runat="server" ForeColor="Red" />

        </div>
    </form>
</body>
</html>
