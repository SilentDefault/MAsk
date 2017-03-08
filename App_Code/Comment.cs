using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Comment
/// </summary>
public class Comment
{
    public Comment()
    {

    }
    public Comment(int id, string urlmedia, string content, string date, string mask, string user)
    {
        this.ID = id;
        this.urlMedia = urlmedia;
        this.Content = content;
        this.Date = date;
        this.Mask = mask;
        this.User = user;
    }
    public int ID { get; set; }
    public string urlMedia { get; set; }
    public string Content { get; set; }
    public string Date { get; set; }
    public string Mask { get; set; }
    public string User { get; set; }
}