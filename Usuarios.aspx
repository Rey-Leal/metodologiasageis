<%@ Page Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true"
    CodeFile="Usuarios.aspx.cs" Inherits="ListaUsuarios" Title="MetodologiasAgeis" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="w3-container w3-justify w3-content" style="max-width: 600px">
        <p>
            Usuários cadastrados atualmente
        </p>        
        <asp:GridView ID="grdListaUsuarios" runat="server" ForeColor="#333333" GridLines="Both"
            Height="61px" Width="95%" CellSpacing="1" CaptionAlign="Left">
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="#EFF3FB" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
    </div>
    <br />
</asp:Content>
