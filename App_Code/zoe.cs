using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using MySql.Data.MySqlClient;
using System.Web.Script.Serialization;

/// <summary>
/// Descripción breve de zoe
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente.
[System.Web.Script.Services.ScriptService]
public class zoe : System.Web.Services.WebService
{
    MySqlConnection conn = new MySqlConnection("Server=localhost;Database=mask;Uid=root;pwd=1212;");
    public zoe()
    {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados
        //InitializeComponent();
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hola a todos";
    }
    [WebMethod]
    public List<Post> Posts(string board)
    {
        string sql = " CALL PostByBoard('" + board + "');";
        MySqlCommand cmd = new MySqlCommand(sql, conn);
        List<Post> lista = new List<Post>();
        conn.Open();
        MySqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            lista.Add(new Post(
                dr.GetInt32(0),     // ID
                dr.GetString(1),    // urlMedia
                dr.GetString(2),    //Conetent
                dr.GetInt32(3),    //commentarios
                dr.GetString(4),    //fecha
                dr.GetString(5),    //user
                dr.GetString(6), //mask
                dr.GetInt32(7), //aplausos
                dr.GetInt32(8), //piedra
                dr.GetInt32(9), //papel
                dr.GetInt32(10) //tijeras
                ));
        }
        conn.Close();
        return lista;
    }
    [WebMethod]
    public List<Board> BoardLinks()
    {
        string sql = "SELECT Name,url,Descripcion,Color FROM boards ORDER BY name ASC";
        MySqlCommand cmd = new MySqlCommand(sql, conn);
        List<Board> lista = new List<Board>();
        conn.Open();
        MySqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            lista.Add(new Board(
                dr.GetString(0),    // Name
                dr.GetString(1),    // url
                dr.GetString(2),    //Descripcion
                dr.GetString(3)     //color
                ));
        }
        conn.Close();
        return lista;
    }

    [WebMethod]
    public List<Post> Last(int board)
    {
        List<Post> lista = new List<Post>();
        MySqlCommand cmd = new MySqlCommand("CALL Last('" + board + "');", conn);
        conn.Open();
        MySqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            lista.Add(new Post(
                dr.GetInt32(0),     // ID
                dr.GetString(1),    //Conetent
                dr.GetString(2),    // urlMedia
                dr.GetInt32(3),    //commentarios
                dr.GetString(4),    //fecha
                dr.GetString(5),    //user
                dr.GetString(6), //mask
                dr.GetInt32(7), //aplausos
                dr.GetInt32(8), //piedra
                dr.GetInt32(9), //papel
                dr.GetInt32(10), //tijeras
                dr.GetString(11),     //BoardName
                dr.GetString(12)      //BoardLink
                ));
        }
        conn.Close();
        return lista;
    }
}
