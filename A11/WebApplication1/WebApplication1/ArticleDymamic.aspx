<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ArticleDymamic.aspx.cs" Inherits="WebApplication1.ArticleDymamic" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="ArticleId" DataSourceID="SqlDataSource1" GridLines="Horizontal" PageSize="4">
    <AlternatingRowStyle BackColor="#F7F7F7" />
    <Columns>
        <asp:BoundField DataField="ArticleId" HeaderText="ArticleId" ReadOnly="True" SortExpression="ArticleId" />
        <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
        <asp:BoundField DataField="Content" HeaderText="Content" SortExpression="Content" />
        <asp:BoundField DataField="PublishDate" HeaderText="PublishDate" SortExpression="PublishDate" />
    </Columns>
    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
    <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
    <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
    <SortedAscendingCellStyle BackColor="#F4F4FD" />
    <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
    <SortedDescendingCellStyle BackColor="#D8D8F0" />
    <SortedDescendingHeaderStyle BackColor="#3E3277" />
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ContentDbConnectionString %>" DeleteCommand="DELETE FROM [Article] WHERE [ArticleId] = @ArticleId" InsertCommand="INSERT INTO [Article] ([ArticleId], [Title], [Content], [PublishDate]) VALUES (@ArticleId, @Title, @Content, @PublishDate)" ProviderName="<%$ ConnectionStrings:ContentDbConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Article]" UpdateCommand="UPDATE [Article] SET [Title] = @Title, [Content] = @Content, [PublishDate] = @PublishDate WHERE [ArticleId] = @ArticleId">
    <DeleteParameters>
        <asp:Parameter Name="ArticleId" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="ArticleId" Type="Int32" />
        <asp:Parameter Name="Title" Type="String" />
        <asp:Parameter Name="Content" Type="String" />
        <asp:Parameter Name="PublishDate" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="Title" Type="String" />
        <asp:Parameter Name="Content" Type="String" />
        <asp:Parameter Name="PublishDate" Type="DateTime" />
        <asp:Parameter Name="ArticleId" Type="Int32" />
    </UpdateParameters>
</asp:SqlDataSource>
</asp:Content>
