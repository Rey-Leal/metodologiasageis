<%@ Page Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true"
    CodeFile="Login.aspx.cs" Inherits="Login" Title="MetodologiasAgeis" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="w3-container w3-justify w3-content" style="max-width: 600px">
        <p>
            Login<br />
            <asp:TextBox ID="txtLogon" runat="server"></asp:TextBox><br />
            <asp:RequiredFieldValidator ID="rfvLogon" runat="server" ErrorMessage="RequiredFieldValidator"
                ControlToValidate="txtLogon">  Login obrigatório!</asp:RequiredFieldValidator>
        </p>
        <p>
            Senha<br />
            <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox><br />
            <asp:RequiredFieldValidator ID="rfvSenha" runat="server" ErrorMessage="RequiredFieldValidator"
                ControlToValidate="txtSenha">  Senha obrigatória!</asp:RequiredFieldValidator>
        </p>
        <p>
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="BtnLogin_Click" class="w3-btn"/>
            <input type="Reset" value="Limpar" class="w3-btn"/>
            <p>
                <asp:Label ID="lblLogado" runat="server" Text=""></asp:Label>
            </p>
        </p>
    </div>
    <br />

</asp:Content>
