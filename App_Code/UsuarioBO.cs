using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

/// <summary>
/// Summary description for UsuarioBO
/// </summary>
public class UsuarioBO
{
    public UsuarioBO(String nome, int idade, String uf, String logon, String senha)
    {
        this.Nome = nome;
        this.Idade = idade;
        this.Uf = uf;
        this.Logon = logon;
        this.Senha = senha;
    }

    private String nome;
    private int idade;
    private String uf;
    private String logon;
    private String senha;

    public String Nome
    {
        get { return nome; }
        set
        {
            if (value.Length > 30)
            {
                nome = value.Substring(0, 30);
            }
            else
            {
                nome = value;
            }
        }
    }

    public int Idade
    {
        get { return idade; }
        set
        {
            if ((value < 1) || (value > 120))
            {
                idade = 0;
            }
            else
            {
                idade = value;
            }
        }
    }

    public String Uf
    {
        get { return uf; }
        set
        {
            if (value.Length > 2)
            {
                uf = value.Substring(0, 2);
            }
            else
            {
                uf = value;
            }
        }
    }

    public String Logon
    {
        get { return logon; }
        set
        {
            if (value.Length > 10)
            {
                logon = value.Substring(0, 10);
            }
            else
            {
                logon = value;
            }
        }
    }

    public String Senha
    {
        get { return senha; }
        set
        {
            if (value.Length > 10)
            {
                senha = value.Substring(0, 10);
            }
            else
            {
                senha = value;
            }
        }
    }
}
