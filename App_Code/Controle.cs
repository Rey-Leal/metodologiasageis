using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.OleDb;
using System.Web.Mail;

/// <summary>
/// Summary description for Controle
/// </summary>
public class Controle
{
    public Controle()
    {
    }

    public static String CriaUsuario(String nome, int idade, String uf, String logon, String senha)
    {
        if (logon != "admin")
        {
            senha = Criptografa.Senha(senha);
            UsuarioBO usr = new UsuarioBO(nome, idade, uf, logon, senha);
            UsuarioDAO dao = new UsuarioDAO();
            return dao.SalvaUsuario(usr);
        }
        else
        {
            return "Não se pode criar novo usuário com este logon restrito! Favor escolher outro.";
        }
    }

    public static String AlteraUsuario(String nome, int idade, String uf, String logonNovo, String senhaNova, String logon, String senha)
    {
        if (logon != "admin" && logonNovo != "admin")
        {
            senhaNova = Criptografa.Senha(senhaNova);
            senha = Criptografa.Senha(senha);
            UsuarioBO usr = new UsuarioBO(nome, idade, uf, logonNovo, senhaNova);
            UsuarioDAO dao = new UsuarioDAO();
            return dao.AlteraUsuario(usr, logon, senha);
        }
        else
        {
            return "Atenção o usuário admin não pode ser alterado!";
        }
    }

    public static String Logon(String logon, String senha)
    {
        senha = Criptografa.Senha(senha);
        UsuarioDAO usrDAO = new UsuarioDAO();
        return usrDAO.Logon(logon, senha);
    }

    public static DataSet ListaUsuarios()
    {
        UsuarioDAO usrDAO = new UsuarioDAO();
        return usrDAO.ListaUsuarios();
    }

    public static UsuarioBO BuscaDadosUsuario(String logon, String senha)
    {
        senha = Criptografa.Senha(senha);
        UsuarioDAO usrDAO = new UsuarioDAO();
        return usrDAO.BuscaDadosUsuario(logon, senha);
    }
}
