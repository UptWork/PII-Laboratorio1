<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PruebaRadioButton._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Ingrese primer valor
        <asp:TextBox ID="txtValor1" runat="server"></asp:TextBox>
        <br />
        Ingrese primer valor
        <asp:TextBox ID="txtValor2" runat="server"></asp:TextBox>
        <br />
        <asp:RadioButton ID="rdSuma" runat="server" Checked="True" GroupName="Operacion" Text="Sumar" />
        <br />
        <asp:RadioButton ID="rdResta" runat="server" GroupName="Operacion" Text="Restar" />
        <br />
        <asp:Button ID="btnSumar" runat="server" OnClick="btnSumar_Click" Text="Resultado" />
        <br />
        <asp:Label ID="lblTest" runat="server" Text="Respuesta"></asp:Label>
    
    </div>
    </form>
</body>
</html>
