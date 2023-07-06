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

public partial class ListaUsuarios : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["restrito"].ToString().Equals("ComAcesso"))
        {
            grdListaUsuarios.DataSource = Controle.ListaUsuarios();
            grdListaUsuarios.DataBind();
        }
        else
        {
            Response.Redirect("Default.aspx");
        }
    }
}

