<%@ Page Title="Products" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="_1700241_CarRental_MS2.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class ="centreh2"><%: Title %></h2>
    <hr class="mild">

    <div class="product_row">

    <asp:DataList ID="dlProducts" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" CellPadding="4" RepeatColumns="2" RepeatDirection="Horizontal" CellSpacing="20" HorizontalAlign="Center" Width="955px">
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <ItemStyle BackColor="#E3EAEB" />
        <ItemTemplate>
            <table style="width: 100%; height: 262px;" border="1">
                <tr>
                    <td style="width: 233px">
                        <asp:Image ID="Image1" runat="server" Height="150px" Width="250px" ImageUrl='<%# "imgs/"+Eval("image") %>'  />
                    </td>
                </tr>
                <tr>
                    <td style="width: 233px; font-family: Arial; font-size: small">Year: </td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("year") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 233px; font-family: Arial; font-size: small; height: 28px;">Make:</td>
                    <td style="height: 28px">
                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("make") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 233px; font-family: Arial; font-size: small">Model:</td>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text='<%# Eval("model") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 233px; font-family: Arial; font-size: small">Type:</td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("type") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 233px; font-family: Arial; font-size: small">Description:</td>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("description") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="height: 10px; width: 233px; font-family: Arial; font-size: small">Cost:</td>
                    <td style="height: 10px">
                        $<asp:Label ID="Label4" runat="server" Text='<%# Eval("cost") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="height: 10px; width: 233px">&nbsp;</td>
                    <td style="height: 10px">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "ProductDetails.aspx?id="+Eval("id") %>' Text='<%# "Add" %>'></asp:HyperLink>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
        <SelectedItemStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
    </asp:DataList>
    </div>
</asp:Content>
