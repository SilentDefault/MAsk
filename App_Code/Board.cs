using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Board
/// </summary>
public class Board
{
    public Board()
    {

    }
    public Board(int id, string v1, string v2)
    {
        this.ID = id;
        this.Name = v1;
        this.Descripcion = v2;
    }

    public Board(string v1, string v2, string v3)
    {
        this.Name = v1;
        this.url = v2;
        this.Descripcion = v3;

    }

    public int ID { get; set; }
    public string Name { get; set; }
    public string Descripcion { get; set; }

    public string url { get; set; }
}
