<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EntityDeneme._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 300px;
            color: red;  
            text-align:center; 
            top:200px;   
        }
        .style2
        {
         background-color: #FFFF00;   
        }
        .style3
        {
            background-color:Aqua;
            color: red;  
        }
        .style4
        {
            background-color:Fuchsia;
           height:600px;
        }
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="style4">
   
        <table class="style1">
            <tr>
                <td class="style2" >
                    Ad</td>
                <td class="style2">
                    :</td>
                <td class="style2">
                    <asp:TextBox ID="txtAd" runat="server" CssClass="style3"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Soyad</td>
                <td class="style2">
                    :</td>
                <td class="style2">
                    <asp:TextBox ID="txtSoyad" runat="server" CssClass="style3"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Email</td>
                <td class="style2">
                    :</td>
                <td class="style2">
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="style3"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style2">
                    <asp:Button ID="btnEkle" runat="server" onclick="btnEkle_Click" Text="Ekle" 
                        CssClass="style3" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
