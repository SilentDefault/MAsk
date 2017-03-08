using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Post
/// </summary>
public class Post
{
    public Post()
    {

    }
    public Post(int id, string urlmedia, string content, int comments, string date, string user, string mask, int aplausos, int piedra, int papel, int tijeras)
    {
        this.ID = id;
        this.urlMedia = urlmedia;
        this.Content = content;
        this.Comments = comments;
        this.Date = date;
        this.Mask = mask;
        this.User = user;
        this.Aplausos = aplausos;
        this.Piedra = piedra;
        this.Papel = papel;
        this.Tijeras = tijeras;
    }
    public Post(int id, string urlmedia, string content, int comments, string date, string user, string mask, int aplausos, int piedra, int papel, int tijeras, string boardname, string boardlink)
    {
        this.ID = id;
        this.urlMedia = urlmedia;
        this.Content = content;
        this.Comments = comments;
        this.Date = date;
        this.Mask = mask;
        this.User = user;
        this.Aplausos = aplausos;
        this.Piedra = piedra;
        this.Papel = papel;
        this.Tijeras = tijeras;
        this.BoardName = boardname;
        this.BoardLink = boardlink;
    }
    public int ID { get; set; }
    public string urlMedia { get; set; }
    public string Content { get; set; }
    public int Comments { get; set; }
    public string Date { get; set; }
    public string Mask { get; set; }
    public string User { get; set; }
    public int Board { get; set; }
    public string BoardName { get; set; }
    public string BoardLink { get; set; }
    public int Aplausos { get; set; }
    public int Piedra { get; set; }
    public int Papel { get; set; }
    public int Tijeras { get; set; }
    public int Reportes { get; set; }
}