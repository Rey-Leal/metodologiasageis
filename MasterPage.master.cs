using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String sessao = Session["restrito"].ToString();
        if (!sessao.Equals(null) && (sessao.Equals("ComAcesso") || sessao.Equals("UsuarioComum")))
        {
            String logon = Session["logon"].ToString();
            String senha = Session["senha"].ToString();
            String nome = Controle.Logon(logon, senha);            
            if (sessao.Equals("ComAcesso"))
            {
                LiberaAcesso();
            }
        }
    }

    public void LiberaAcesso()
    {
        pnlAdmin.Visible = false;
        pnlUsuario.Visible = false;
        if (Session["logon"].ToString() == "admin")
        {
            pnlAdmin.Visible = true;            
        }
        else
        {
            pnlUsuario.Visible = true;
        }
        Session["restrito"] = "ComAcesso";
    }

    public void RestringeAcesso()
    {        
        pnlAdmin.Visible = false;
        pnlUsuario.Visible = false;
        Session["logon"] = null;
        Session["senha"] = null;
        Session["restrito"] = "SemAcesso";
        Response.Redirect("Default.aspx");
    }

    protected void btnSair_Click(object sender, EventArgs e)
    {
        RestringeAcesso();
    }
}
