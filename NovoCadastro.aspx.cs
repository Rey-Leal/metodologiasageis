using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.OleDb;

public partial class NovoCadastro : System.Web.UI.Page
{
    public void LimparCampos()
    {
        txtNome.Text = null;
        txtIdade.Text = null;
        ddlUf.Text = null;
        txtLogon.Text = null;
        txtSenha.Text = null;
    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        if ((!txtNome.Text.Equals("")) && (!txtIdade.Text.Equals("")) && (!ddlUf.Text.Equals("")) && (!txtLogon.Text.Equals("")) && (!txtSenha.Text.Equals("")))
        {
            String nome = txtNome.Text;
            int idade = Convert.ToInt32(txtIdade.Text);
            String uf = ddlUf.Text;
            String logon = txtLogon.Text;
            String senha = txtSenha.Text;
            String salva = Controle.CriaUsuario(nome, idade, uf, logon, senha);
            if (salva.Equals("Usuario Salvo"))
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "alerta", "alert('Usuário salvo com sucesso!')", true);
                LimparCampos();
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "alerta", "alert(" + salva + ")", true);
                lblMensagem.Text = salva;
            }
        }
        else
        {
            lblMensagem.Text = "Dados Obrigatórios";
        }
    }
}
