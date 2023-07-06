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

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    public void LimparCampos()
    {
        txtLogon.Text = null;
        txtSenha.Text = null;
    }

    protected void BtnLogin_Click(object sender, EventArgs e)
    {
        Session["logon"] = txtLogon.Text;
        Session["senha"] = txtSenha.Text;
        String logon = Session["logon"].ToString();
        String senha = Session["senha"].ToString();

        if ((!logon.Equals("")) && (!senha.Equals("")))
        {
            String logar = Controle.Logon(logon, senha);
            if ((!logar.Equals("Erro na senha")) && (!logar.Equals("Erro na conexão")))
            {
                Session["restrito"] = "ComAcesso";
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "alerta", "alert('Seja Bem Vindo')", true);
                LimparCampos();
            }
            Response.Redirect("Default.aspx");
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "alerta", "alert('Erro na tentativa de login!')", true);
            LimparCampos();
            txtLogon.Focus();
        }
    }
}
