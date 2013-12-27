<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EjercicioPropuesto1._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        PRUEBA EN ASP .NET<br />
        <br />
        1. ¿.NET es un framework o un lenguaje?
        <br />
        <asp:Panel ID="Panel1" runat="server">
            <asp:RadioButton ID="rdRespuesta11" runat="server" Checked="True" GroupName="Pregunta1" Text="Framework" />
            <br />
            <asp:RadioButton ID="rdRespuesta12" runat="server" GroupName="Pregunta1" Text="Lenguaje" />
        </asp:Panel>
        <br />
        <br />
        2. ¿El lenguaje C# es orientado a objetos?
        <br />
        <br />
        <asp:Panel ID="Panel2" runat="server">
            <asp:RadioButton ID="rdRespuesta21" runat="server" Checked="True" GroupName="Pregunta2" Text="Verdadero" />
            <br />
            <asp:RadioButton ID="rdRespuesta22" runat="server" GroupName="Pregunta2" Text="Falso" />
        </asp:Panel>
        <br />
        <br />
        3. ¿Cual es la version mas reciente de .NET?
        <br />
        <asp:Panel ID="Panel3" runat="server">
            <asp:RadioButton ID="rdRespuesta31" runat="server" Checked="True" GroupName="Pregunta3" Text="4.0" />
            <br />
            <asp:RadioButton ID="rdRespuesta32" runat="server" GroupName="Pregunta3" Text="3.5" />
            <br />
            <asp:RadioButton ID="rdRespuesta33" runat="server" GroupName="Pregunta3" Text="5.0" />
            <br />
            <asp:RadioButton ID="rdRespuesta34" runat="server" GroupName="Pregunta3" Text="4.5" />
        </asp:Panel>
        <br />
        4. ¿Cual es la version mas reciente de MVC ASP .NET?
        <br />
        <asp:Panel ID="Panel4" runat="server">
            <asp:RadioButton ID="rdRespuesta35" runat="server" Checked="True" GroupName="Pregunta4" Text="4" />
            <br />
            <asp:RadioButton ID="rdRespuesta36" runat="server" GroupName="Pregunta4" Text="4.5" />
            <br />
            <asp:RadioButton ID="rdRespuesta43" runat="server" GroupName="Pregunta4" Text="5" />
        </asp:Panel>
        <br />
        5. ¿Cuanto es 2+3?
        <br />
        <asp:Panel ID="Panel5" runat="server">
            <asp:RadioButton ID="rdRespuesta51" runat="server" Checked="True" GroupName="Pregunta5" Text="5" />
            <br />
            <asp:RadioButton ID="rdRespuesta38" runat="server" GroupName="Pregunta5" Text="4" />
        </asp:Panel>
        <br />
        6. ¿Cuantas preguntas tiene este cuestionario?
        <br />
        <asp:Panel ID="Panel6" runat="server">
            <asp:RadioButton ID="rdRespuesta39" runat="server" Checked="True" GroupName="Pregunta6" Text="5" />
            <br />
            <asp:RadioButton ID="rdRespuesta62" runat="server" GroupName="Pregunta6" Text="6" />
            <br />
            <asp:RadioButton ID="rdRespuesta41" runat="server" GroupName="Pregunta6" Text="7" />
            <br />
            <asp:RadioButton ID="rdRespuesta42" runat="server" GroupName="Pregunta6" Text="4" />
        </asp:Panel>
        <br />
        <asp:Button ID="btnSumar" runat="server" OnClick="btnSumar_Click" Text="Resultado" />
        <br />
        <asp:Label ID="lblTest" runat="server" Text="Respuesta"></asp:Label>
    
    </div>
    </form>
</body>
</html>
