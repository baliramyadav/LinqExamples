<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestVideoPlayer.aspx.cs" Inherits="LinqExamples.TestVideoPlayer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <h1 style="background-color: yellow; color: red; text-align: center">Travel Analog</h1>
<table align="center">
   <tr>
      <td align="center">
         <asp:DropDownList ID="ddlContinents" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlContinents_SelectedIndexChanged" />
      </td>
   </tr>
   <tr>
      <td>
         <asp:Repeater ID="rptLocations" runat="server">
            <HeaderTemplate>
               <table border="1" align="center">
                  <tr>
                     <th>Location</th>     <th>Continent</th>     <th>Video</th>     <th>Image</th>     <th>Price</th>
                  </tr>
            </HeaderTemplate>
            <ItemTemplate>
               <tr>
                  <td><%# Eval("Name") %></td>
                  <td><%# Eval("Continent") %></td>
                  <td>
                    <%-- <cc1:VideoPlayer ID="VideoPlayer1" runat="server" Width="300" Height="200" Controls="true" 
Mp4Url='<%# "/Videos/" + Eval("Video") %>' />--%>

                  </td>
                  <td>
                     <asp:Image ID="Image1" runat="server" Width="200" Height="200" 
ImageUrl='<%# "/Images/" + Eval("Photo") %>' />
                  </td>
                  <td align="right"><%# Eval("Price") %></td>
               </tr>
            </ItemTemplate>
            <FooterTemplate>
               </table>
            </FooterTemplate>
         </asp:Repeater>
      </td>
   </tr>
</table>

            
        </div>
    </form>
</body>
</html>
