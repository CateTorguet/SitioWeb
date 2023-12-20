<%@ Page Title="Añadir foto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Añadir.aspx.cs" Inherits="SitioWeb.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
 <h2>Añadir foto - Album de fotos </h2>
 <p>
 Todos los usuarios, autenticados o no, podrán ver las fotos, sólo los
 usuarios autenticados podrán añadir fotos y sólo los usuarios autenticados
 que tengan asignada la función de “Administradores” podrán borrar fotos.
 </p>
</div>

    <div>
        <asp:Label ID="Label4" runat="server" Text="Seleccione una foto:"></asp:Label>
        <br />
        <asp:FileUpload ID="sa_SubirArchivo" runat="server"/>
        <asp:Label ID="et_Archivo" runat="server" Text="" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Nombre de la foto:"></asp:Label>
        <br />
        <asp:TextBox ID="ct_Nombre" runat="server"  MaxLength="30"></asp:TextBox> 
        <asp:Label ID="et_Nombre" runat="server" Text="" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Autor:"></asp:Label>
        <br />
        <asp:TextBox ID="ct_Autor" runat="server" MaxLength="30"></asp:TextBox>
        <asp:Label ID="et_Autor" runat="server" Text="" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Descripción:"></asp:Label>
        <br />
        <asp:TextBox ID="ct_Descripcion" runat="server" MaxLength="400"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="bt_Añadir" runat="server" Height="29px" Text="Button" Width="55px" OnClick="bt_Añadir_Click" />
    </div>
</asp:Content>


