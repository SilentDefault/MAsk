using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Mask
/// </summary>
public class Mask
{
    public Mask()
    {

    }

    public Mask(int v1, string v2)
    {
        this.ID = v1;
        this.Name = v2;
    }

    public int ID { get; set; }

    public string Name { get; set; }
}