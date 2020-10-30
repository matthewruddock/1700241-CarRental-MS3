<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="_1700241_CarRental_MS2.ProductDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:DataList ID="dlProductDetails" runat="server" RepeatColumns="1" >
        <ItemTemplate>
            <table style="width:100%;">
                <tr>
                    <td style="width: 125px">
                        <asp:Image ID="Image1" runat="server" Height="95px" ImageUrl='<%# "imgs/"+Eval("image") %>' Width="118px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 125px">Year:</td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("year") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 125px">Make:</td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("make") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 125px">Model:</td>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("model") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 125px">Type:</td>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("type") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 125px">Description:</td>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("description") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 125px">Cost:</td>
                    <td>
                        $<asp:Label ID="Label6" runat="server" Text='<%# Eval("cost") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 125px">Start Date:</td>
                    <td>

                        <asp:TextBox id="startDate" runat="server"></asp:TextBox>

                        <td><asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Selection_Change1"></asp:Calendar></td>
                    </td>

                </tr>
                <tr>
                    <td style="width: 125px">End Date:</td>
                    <td>

                        <asp:TextBox id="endDate" runat="server"></asp:TextBox>
                        <td><asp:Calendar ID="Calendar2" runat="server" OnSelectionChanged="Selection_Change2"></asp:Calendar></td>
                    </td>

                </tr>
                <tr>
                    <td style="width: 125px">&nbsp;</td>
                    <td>
                        <asp:Button ID="BtnAddToCart_ProDetail" OnClick="btnAddToCart_ProDetail_Click" runat="server" Text="Add to Cart" Width="108px" />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
