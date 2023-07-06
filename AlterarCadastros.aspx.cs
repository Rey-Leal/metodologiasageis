using System;

public partial class Cadastros : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Session["restrito"].ToString().Equals("ComAcesso"))
        {
            Response.Redirect("Default.aspx");
        }
        LimparCampos();
        String logon = Session["logon"].ToString();
        String senha = Session["senha"].ToString();
        UsuarioBO usr = Controle.BuscaDadosUsuario(logon, senha);
        txtNome.Text = usr.Nome;
        txtIdade.Text = usr.Idade.ToString();
        ddlUf.Text = usr.Uf;
        txtLogon.Text = usr.Logon;
        txtSenha.Text = usr.Senha;
    }

    public void LimparCampos()
    {
        txtNome.Text = null;
        txtIdade.Text = null;
        ddlUf.Text = null;
        txtLogon.Text = null;
        txtSenha.Text = null;
    }

    protected void btnAlterar_Click(object sender, EventArgs e)
    {
        if ((!txtNome.Text.Equals("")) && (!txtIdade.Text.Equals("")) && (!ddlUf.Text.Equals("")) && (!txtLogon.Text.Equals("")) && (!txtSenha.Text.Equals("")))
        {
            String nome = txtNome.Text;
            int idade = Convert.ToInt32(txtIdade.Text);
            String uf = ddlUf.Text;
            String logonNovo = txtLogon.Text;
            String senhaNova = txtSenha.Text;
            String logon = Session["logon"].ToString();
            String senha = Session["senha"].ToString();
            String altera = Controle.AlteraUsuario(nome, idade, uf, logonNovo, senhaNova, logon, senha);
            if (altera.Equals("Usuario Salvo"))
            {
                LimparCampos();
                Session["restrito"] = "SemAcesso";
                Response.Redirect("Login.aspx");
            }
            else
            {
                lblMensagem.Text = altera;
            }
        }
        else
        {
            lblMensagem.Text = "Dados Obrigatórios";
        }
    }
}
