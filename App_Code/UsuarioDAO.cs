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
/// Summary description for UsuarioDAO
/// </summary>
/// 

//SQL---------------------------------------------------------------------------------------
//public class UsuarioDAO
//{
//    //1
//    public String BuscaUsuario(String logon)
//    {
//        try
//        {
//            OleDbConnection conexao1 = Conexao.Conecta();
//            conexao1.Open();
//            SqlCommand cmd1 = new SqlCommand("SELECT logon FROM Usuarios WHERE logon = '" + logon + "'", conexao1);
//            SqlDataReader dr1 = cmd1.ExecuteReader();
//            cmd1.Dispose();

//            if (dr1.Read())
//            {
//                dr1.Dispose();
//                conexao1.Close();
//                return ("Usuário existe");
//            }
//            else
//            {
//                conexao1.Close();
//                return ("Usuário inexistente");
//            }
//        }
//        catch (SqlException e)
//        {
//            return ("Erro na conexão: " + e);
//        }
//    }
//    //2
//    public String BuscaUsuarioSenha(String logon, String senha)
//    {
//        try
//        {
//            OleDbConnection conexao2 = Conexao.Conecta();
//            conexao2.Open();
//            SqlCommand cmd2 = new SqlCommand("SELECT logon FROM Usuarios WHERE logon = '" + logon + "' AND senha = '" + senha + "'", conexao2);
//            SqlDataReader dr2 = cmd2.ExecuteReader();
//            cmd2.Dispose();

//            if (dr2.Read())
//            {
//                dr2.Dispose();
//                conexao2.Close();
//                return ("Usuário existe");
//            }
//            else
//            {
//                conexao2.Close();
//                return ("Usuário inexistente, ou senha errada");
//            }
//        }
//        catch (SqlException e)
//        {
//            return ("Erro na conexão: " + e);
//        }
//    }
//    //3
//    public String Logon(String logon, String senha)
//    {
//        try
//        {
//            OleDbConnection conexao3 = Conexao.Conecta();
//            conexao3.Open();
//            SqlCommand cmd3 = new SqlCommand("SELECT nome FROM Usuarios WHERE logon = '" + logon + "' AND senha = '" + senha + "'", conexao3);
//            SqlDataReader dr3 = cmd3.ExecuteReader();
//            if (dr3.Read())
//            {
//                String nome = dr3["nome"].ToString();
//                conexao3.Close();
//                return (nome);
//            }
//            else
//            {
//                conexao3.Close();
//                return ("Erro na senha");
//            }
//        }
//        catch (SqlException e)
//        {
//            return ("Erro na conexão");
//        }
//    }
//    //4
//    public String SalvaUsuario(UsuarioBO usr)
//    {
//        try
//        {
//            OleDbConnection conexao4 = Conexao.Conecta();
//            conexao4.Open();
//            SqlCommand cmd4 = new SqlCommand("INSERT INTO Usuarios(nome, idade, uf, logon, senha) VALUES('"+ usr.Nome +"',"+ usr.Idade +",'"+ usr.Uf +"','"+ usr.Logon +"','"+ usr.Senha +"')", conexao4);
//            SqlDataReader dr4 = cmd4.ExecuteReader();
//            conexao4.Close();
//            return ("Usuario Salvo");
//        }
//        catch (SqlException e)
//        {
//            return ("Erro na conexão");
//        }
//    }
//    //5
//    public DataSet ListaUsuarios()
//    {
//        try
//        {
//            OleDbConnection conexao5 = Conexao.Conecta();
//            SqlDataAdapter sqlAdp = new SqlDataAdapter();
//            conexao5.Open();
//            sqlAdp.SelectCommand = new SqlCommand("SELECT * FROM Usuarios ORDER BY id", conexao5);
//            DataSet ds = new DataSet();
//            sqlAdp.Fill(ds, "Resultado");
//            conexao5.Close();
//            return ds;           
//        }
//        catch (SqlException e)
//        {
//            return (null);
//        }
//    }
//}

//ACCESS-------------------------------------------------------------------------------------
public class UsuarioDAO
{
    //1
    public String BuscaUsuario(String logon)
    {
        try
        {
            OleDbConnection conexao1 = Conexao.Conecta();
            conexao1.Open();
            OleDbCommand cmd1 = new OleDbCommand(@"SELECT logon 
                                                   FROM Usuarios 
                                                   WHERE logon = '" + logon + "'", conexao1);
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            cmd1.Dispose();

            if (dr1.Read())
            {
                dr1.Dispose();
                conexao1.Close();
                return ("Usuário existe");
            }
            else
            {
                conexao1.Close();
                return ("Usuário inexistente");
            }
        }
        catch (OleDbException e)
        {
            return (e.ToString());
        }
    }
    //2
    public String BuscaUsuarioSenha(String logon, String senha)
    {
        try
        {
            OleDbConnection conexao2 = Conexao.Conecta();
            conexao2.Open();
            OleDbCommand cmd2 = new OleDbCommand(@"SELECT logon 
                                                   FROM Usuarios 
                                                   WHERE logon = '" + logon + "' AND senha = '" + senha + "'", conexao2);
            OleDbDataReader dr2 = cmd2.ExecuteReader();
            cmd2.Dispose();

            if (dr2.Read())
            {
                dr2.Dispose();
                conexao2.Close();
                return ("Usuário existe");
            }
            else
            {
                conexao2.Close();
                return ("Usuário inexistente, ou senha errada");
            }
        }
        catch (OleDbException e)
        {
            return (e.ToString());
        }
    }
    //3
    public String Logon(String logon, String senha)
    {
        try
        {
            OleDbConnection conexao3 = Conexao.Conecta();
            conexao3.Open();
            OleDbCommand cmd3 = new OleDbCommand(@"SELECT nome 
                                                   FROM Usuarios 
                                                   WHERE logon = '" + logon + "' AND senha = '" + senha + "'", conexao3);
            OleDbDataReader dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {
                String nome = dr3["nome"].ToString();
                conexao3.Close();
                return (nome);
            }
            else
            {
                conexao3.Close();
                return ("Erro na senha");
            }
        }
        catch (Exception e)
        {
            return (e.ToString());
        }
    }
    //4
    public String SalvaUsuario(UsuarioBO usr)
    {
        try
        {
            OleDbConnection conexao4 = Conexao.Conecta();
            conexao4.Open();
            OleDbCommand cmd4 = new OleDbCommand(@"INSERT INTO Usuarios(nome, idade, uf, logon, senha, tipo) 
                                                   VALUES('" + usr.Nome + "'," + usr.Idade + ",'" + usr.Uf + "','" + usr.Logon + "','" + usr.Senha + "', 0)", conexao4);
            cmd4.ExecuteNonQuery();
            conexao4.Close();
            return ("Usuario Salvo");
        }
        catch (OleDbException e)
        {
            return (e.ToString());
        }
    }
    //5
    public DataSet ListaUsuarios()
    {
        try
        {
            OleDbConnection conexao5 = Conexao.Conecta();
            OleDbDataAdapter OleDbAdp = new OleDbDataAdapter();
            conexao5.Open();
            OleDbAdp.SelectCommand = new OleDbCommand(@"SELECT * FROM Usuarios 
                                                        ORDER BY id", conexao5);
            DataSet ds = new DataSet();
            OleDbAdp.Fill(ds, "Resultado");
            conexao5.Close();
            return ds;
        }
        catch (OleDbException)
        {
            return (null);
        }
    }
    //6
    public UsuarioBO BuscaDadosUsuario(String logon, String senha)
    {
        try
        {
            OleDbConnection conexao6 = Conexao.Conecta();
            conexao6.Open();
            OleDbCommand cmd6 = new OleDbCommand(@"SELECT * FROM Usuarios 
                                                   WHERE logon = '" + logon + "' AND senha = '" + senha + "'", conexao6);
            OleDbDataReader dr6 = cmd6.ExecuteReader();
            if (dr6.Read())
            {
                String nome = dr6["nome"].ToString();
                int idade = (int)dr6["idade"];
                String uf = dr6["uf"].ToString();
                String logon2 = dr6["logon"].ToString();
                String senha2 = dr6["senha"].ToString();
                UsuarioBO usr = new UsuarioBO(nome, idade, uf, logon2, senha2);
                conexao6.Close();
                return usr;
            }
            else
            {
                conexao6.Close();
                return (null);
            }            
        }
        catch (OleDbException)
        {
            return (null);
        }
    }
    //7
    public String AlteraUsuario(UsuarioBO usr, String logon, String senha)
    {
        try
        {
            OleDbConnection conexao7 = Conexao.Conecta();
            conexao7.Open();
            OleDbCommand cmd7 = new OleDbCommand(@"UPDATE Usuarios 
                                                   SET nome = '" + usr.Nome + "', idade = " + usr.Idade + ", uf = '" + usr.Uf + "', logon = '" + usr.Logon + "', senha = '" + usr.Senha  + @"' 
                                                   WHERE logon = '" + logon + "' AND senha = '"+ senha +"'", conexao7);
            cmd7.ExecuteNonQuery();
            conexao7.Close();
            return ("Usuario Salvo");
        }
        catch (OleDbException e)
        {
            return (e.ToString());
        }
    }
}

