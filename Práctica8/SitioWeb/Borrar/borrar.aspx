<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="borrar.aspx.cs" Inherits="SitioWeb.borrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server"> 
    <table>
        <tr>
            <td>
                <asp:ListBox ID="ls_Nombres" runat="server" OnLoad="Page_Load" AutoPostBack="True" OnSelectedIndexChanged="ls_Nombres_SelectedIndexChanged"></asp:ListBox>
            </td>

            <td>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                         <asp:Image ID="Img" runat="server" />
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="ls_Nombres" EventName="SelectedIndexChanged" />
                    </Triggers>
                </asp:UpdatePanel>
            </td>

        </tr>
    </table>
    <br />
    <br />
<asp:Button ID="Button1" runat="server" Text="Borrar" OnClick="Button1_Click" />
</asp:Content>
