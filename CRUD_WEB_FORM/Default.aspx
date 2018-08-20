<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CRUD_WEB_FORM.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
        <asp:TextBox ID="txt_nombre" runat="server"></asp:TextBox>
        <asp:Label ID="lbl_estado" runat="server" Text="Estado"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Apellido:"></asp:Label>
        <asp:TextBox ID="txt_apellido" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Guardar" />
        <asp:Button ID="btn_mostrar" runat="server" OnClick="btn_mostrar_Click" Text="Mostrar Datos" />
    
    </div>
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        </asp:GridView>
    </form>
</body>
</html>
