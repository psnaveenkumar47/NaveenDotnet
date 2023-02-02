<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="operations.aspx.cs" Inherits="CRUDConnectedDisconnected.operations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvEmployee" runat="server"  OnRowCommand="gvSearch_RowDataBound" OnSelectedIndexChanged="gvEmployee_SelectedIndexChanged" BorderStyle="Dashed"  >
              
                <Columns>
                <asp:TemplateField>
            <ItemTemplate>
                <asp:Button Text="Select" runat="server" CommandName="Select" CommandArgument="<%# Container.DataItemIndex %> "/>
            </ItemTemplate>
        </asp:TemplateField>
                </Columns>
                
            </asp:GridView>
        &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:GridView ID="gvDetails" runat="server"  OnRowCommand="gvdetail_RowDataBound" BorderStyle="Dashed" HorizontalAlign="Center">
                <Columns>
                <asp:TemplateField>
            <ItemTemplate>
                <asp:Button Text="Aggregate" runat="server" CommandName="Aggregate" CommandArgument="<%# Container.DataItemIndex %>" />
            </ItemTemplate>
        </asp:TemplateField>
                </Columns>
            </asp:GridView>

        </div>
        
        <asp:Button ID="Button1" runat="server"  OnClick="Button1_Click" Text="show details" />
    </form>
</body>
</html>
