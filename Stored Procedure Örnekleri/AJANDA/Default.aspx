<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body background="img/computer.bmp">
    <form id="form1" runat="server">
    <div style="font-family: Arial; font-size: x-large">
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
        AJANDA<br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    CellPadding="4" DataKeyNames="id" DataSourceID="SqlDataSource1" 
                    EnableModelValidation="True" ForeColor="#333333" GridLines="None" 
                    onselectedindexchanged="GridView1_SelectedIndexChanged" 
                    style="font-family: Calibri; font-size: medium">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                        <asp:BoundField DataField="isim" HeaderText="isim" SortExpression="isim" />
                        <asp:BoundField DataField="soyad" HeaderText="soyad" SortExpression="soyad" />
                        <asp:TemplateField HeaderText="meslek" SortExpression="meslek">
                            <EditItemTemplate>
                                <asp:DropDownList ID="DropDownList1" runat="server" 
                                    DataSourceID="SqlDataSource2" DataTextField="meslek" DataValueField="meslek" 
                                    SelectedValue='<%# Bind("meslek", "{0}") %>'>
                                </asp:DropDownList>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("meslek") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <EditRowStyle BackColor="#7C6F57" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                </asp:GridView>
                <br />
                <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
                    BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" 
                    CellPadding="3" DataKeyNames="id" DataSourceID="SqlDataSource1" 
                    DefaultMode="Insert" GridLines="Vertical" Height="50px" 
                    style="font-family: Calibri; font-size: medium;" Width="125px">
                    <AlternatingRowStyle BackColor="#DCDCDC" />
                    <EditRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                    <Fields>
                        <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                            ReadOnly="True" SortExpression="id" />
                        <asp:BoundField DataField="isim" HeaderText="isim" SortExpression="isim" />
                        <asp:BoundField DataField="soyad" HeaderText="soyad" SortExpression="soyad" />
                        <asp:TemplateField HeaderText="meslek" SortExpression="meslek">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("meslek") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <InsertItemTemplate>
                                <asp:DropDownList ID="DropDownList2" runat="server" 
                                    DataSourceID="SqlDataSource2" DataTextField="meslek" DataValueField="meslek" 
                                    SelectedValue='<%# Bind("meslek", "{0}") %>'>
                                </asp:DropDownList>
                            </InsertItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("meslek") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:CommandField ShowInsertButton="True" />
                    </Fields>
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                </asp:DetailsView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:AJANDADBConnectionString %>" 
                    DeleteCommand="DELETE FROM [kisiler] WHERE [id] = @id" InsertCommand="kisi" 
                    InsertCommandType="StoredProcedure" SelectCommand="SELECT * FROM [kisiler]" 
                    UpdateCommand="kisi" UpdateCommandType="StoredProcedure">
                    <DeleteParameters>
                        <asp:Parameter Name="id" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="id" Type="Int32" />
                        <asp:Parameter Name="isim" Type="String" />
                        <asp:Parameter Name="soyad" Type="String" />
                        <asp:Parameter Name="meslek" Type="String" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="id" Type="Int32" />
                        <asp:Parameter Name="isim" Type="String" />
                        <asp:Parameter Name="soyad" Type="String" />
                        <asp:Parameter Name="meslek" Type="String" />
                    </UpdateParameters>
                </asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:AJANDADBConnectionString %>" 
                    SelectCommand="SELECT [meslek] FROM [meslekler]"></asp:SqlDataSource>
                <br />
                <br />
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
    
    </div>
    </form>
</body>
</html>
