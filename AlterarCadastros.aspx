<%@ Page Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true"
    CodeFile="AlterarCadastros.aspx.cs" Inherits="Cadastros" Title="MetodologiasAgeis" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="w3-container w3-justify w3-content" style="max-width: 600px">
        <p>Alterar usuários previamente cadastrados</p>
        <table width="100%">
            <tr>
                <td>
                    <br />
                    Nome
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox><br />
                    <asp:RequiredFieldValidator ID="rfvNome" runat="server" ErrorMessage="RequiredFieldValidator"
                        ControlToValidate="txtNome">Campo Obrigatório</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <table>
                        <tr>
                            <td>Idade
                            </td>
                            <td>UF
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="txtIdade" runat="server" Width="73px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlUf" runat="server" Width="73px">
                                    <asp:ListItem>AC</asp:ListItem>
                                    <asp:ListItem>AL</asp:ListItem>
                                    <asp:ListItem>GO</asp:ListItem>
                                    <asp:ListItem>MG</asp:ListItem>
                                    <asp:ListItem>RJ</asp:ListItem>
                                    <asp:ListItem>RS</asp:ListItem>
                                    <asp:ListItem>SP</asp:ListItem>
                                    <asp:ListItem>SC</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:RequiredFieldValidator ID="rfvIdade" runat="server" ErrorMessage="RequiredFieldValidator"
                        ControlToValidate="txtIdade">Campos Obrigatórios</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Logon
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtLogon" runat="server"></asp:TextBox><br />
                    <asp:RequiredFieldValidator ID="rfvLogon" runat="server" ErrorMessage="RequiredFieldValidator"
                        ControlToValidate="txtLogon">Campo Obrigatório</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Senha
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox><br />
                    <asp:RequiredFieldValidator ID="rfvSenha" runat="server" ErrorMessage="RequiredFieldValidator"
                        ControlToValidate="txtSenha">Campo Obrigatório</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnAlterar" runat="server" Text="Alterar" OnClick="btnAlterar_Click" class="w3-btn" />
                    <input type="Reset" value="Limpar" class="w3-btn" />
                </td>
            </tr>
        </table>
        <p>
            <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
        </p>
    </div>
    <br />
</asp:Content>
