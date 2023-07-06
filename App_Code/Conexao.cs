using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
//using System.Data.SqlClient;
using System.Data.OleDb;

/// <summary>
/// Summary description for Conexao
/// </summary>
public class Conexao
{
    //local server SQL
    //public static SqlConnection Conecta()
    //{
    //    try
    //    {
    //        string connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Meus Documentos\Projects Web\PosIFSUL\MetodologiasAgeis\App_Data\MetodologiasAgeis.mdb;Integrated Security=True;User Instance=True";
    //        SqlConnection conexao = new SqlConnection(connectionString);
    //        return conexao;
    //    }
    //    catch(sqlException e)
    //    {
    //        return null;
    //    }
    //}

    //web server SQL
    //public static SqlConnection Conecta()
    //{
    //    try
    //    {
    //        string connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Inetpub\vhosts\infoqmais.com.br\httpdocs\reyleal\App_Data\MetodologiasAgeis.mdf;Integrated Security=True;User Instance=True";
    //        SqlConnection conexao = new SqlConnection(connectionString);
    //        return conexao;
    //    }
    //    catch(sqlException e)
    //    {
    //        return null;
    //    }
    //}


    //local server ACCESS
    public static OleDbConnection Conecta()
    {
        try
        {
            string caminho = HttpContext.Current.Request.MapPath("~").ToString();
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + caminho + @"\App_Data\MetodologiasAgeis.mdb";
            OleDbConnection conexao = new OleDbConnection(connectionString);
            return conexao;
        }
        catch (OleDbException)
        {
            return null;
        }
    }

    //web server ACCESS
    //public static OleDbConnection Conecta()
    //{
    //    try
    //    {
    //        string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Inetpub\vhosts\infoqmais.com.br\httpdocs\reyleal\App_Data\MetodologiasAgeis.mdb";
    //        OleDbConnection conexao = new OleDbConnection(connectionString);
    //        return conexao;
    //    }
    //    catch (OleDbException)
    //    {
    //        return null;
    //    }
    //}
}