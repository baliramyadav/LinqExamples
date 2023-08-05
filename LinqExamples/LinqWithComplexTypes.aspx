<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LinqWithComplexTypes.aspx.cs" Inherits="LinqExamples.LinqWithComplexTypes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LinqWithComplexTypes</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" width="560px">
                <caption><h3>Storing user-defined type values in Collection (LINQ to Object)</h3></caption>
                <tr>
                    <td align="center">
                        <asp:DropDownList ID="ddlJobs" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlJobs_SelectedIndexChanged" /></td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:GridView ID="gvEmp" runat="server" Width="500px" />
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
