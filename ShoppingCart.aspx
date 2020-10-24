<%@ Page Title="Shopping Cart" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="_1700241_CarRental_MS2.ShoppingCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class ="centreh2"><%: Title %></h2>
    <hr class="mild">

    <div class="product_row">
  
        <asp:GridView ID="gvShoppingCart" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" AutoGenerateColumns="False" 
            OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="800px" Height="200px" 
            OnRowCancelingEdit="getShoppingCart_RowCancelingEdit" OnRowDeleting="getShoppingCart_RowDeleting" 
            OnRowEditing="getShoppingCart_RowEditing" OnRowUpdating="getShoppingCart_RowUpdating" CellPadding="1" CellSpacing="5" HorizontalAlign="Center">
            <AlternatingRowStyle HorizontalAlign="Center" />
            <Columns>
                <asp:BoundField DataField="year" HeaderText="Year" />
                <asp:BoundField DataField="make" HeaderText="Make" />
                <asp:BoundField DataField="model" HeaderText="Model" />
                <asp:ImageField DataImageUrlField="image" DataImageUrlFormatString="~\imgs\{0}" HeaderText="Image" >
                    <ControlStyle Height="100px" Width="200px" />
                </asp:ImageField>
                <asp:BoundField DataField="cost" HeaderText="Cost" />
                <asp:BoundField DataField="qty" HeaderText="Number of Days" />
                <asp:TemplateField HeaderText="Total">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# float.Parse(Eval("cost").ToString())*Int32.Parse(Eval("qty").ToString()) %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle ForeColor="#000066" />
                </asp:TemplateField>
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
            <EditRowStyle BorderColor="White" Font-Names="Arial" Font-Size="X-Small" />
            <HeaderStyle BackColor="#00CC99" BorderColor="#00CC99" BorderStyle="Solid" BorderWidth="2px" Height="50px" HorizontalAlign="Center" VerticalAlign="Middle" />
            <PagerStyle HorizontalAlign="Center" />
            <RowStyle HorizontalAlign="Center" />
        </asp:GridView>

        <h4 style="color:red; font-weight: bold;" ><asp:Label ID="lblGrandTotal" runat="server" Text="Label" Visible="False"></asp:Label></h4>
    </div>
    
</asp:Content>
