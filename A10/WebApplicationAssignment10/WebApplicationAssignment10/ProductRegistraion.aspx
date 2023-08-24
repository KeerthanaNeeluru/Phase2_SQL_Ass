<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductRegistraion.aspx.cs" Inherits="WebApplicationAssignment10.ProductRegistraion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 247px;
        }
        .auto-style3 {
            width: 247px;
            height: 33px;
        }
        .auto-style4 {
            height: 33px;
            width: 763px;
        }
        .auto-style5 {
            width: 763px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">ProductName</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtProdName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="ValName" runat="server" ControlToValidate="txtProdName" ErrorMessage="Enter Product Name" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td rowspan="7">
                    <asp:Image ID="imgProd" runat="server" Height="100px" ImageUrl="~/images/product.jpg" Width="100px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Category</td>
                <td class="auto-style5">
                    <asp:DropDownList ID="ddlCat" runat="server">
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="ValCat" runat="server" ControlToValidate="ddlCat" ErrorMessage="Please Enter The Category" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Price</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="ValPrice" runat="server" ControlToValidate="txtPrice" ErrorMessage="Enter Price of the Product" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegExpPrice" runat="server" ControlToValidate="txtPrice" ErrorMessage="Enter only numbers" ForeColor="Red" ValidationExpression="^[0-9]*$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Description</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtDes" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtDes" ErrorMessage="Enter description"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">ReleaseDate</td>
                <td class="auto-style5">
                    <asp:Calendar ID="CalRel" runat="server" ShowGridLines="True"></asp:Calendar>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">
                    <asp:Button ID="BtnSubmit" runat="server" OnClick="BtnSubmit_Click" Text="Submit" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblMsg" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
