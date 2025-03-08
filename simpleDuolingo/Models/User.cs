namespace simpleDuolingo.Models;

public class User
{
    public int id {get; set;}
    public string username {get; set;}
    public DateTime date_created {get; set;}
    public DateTime date_modified {get; set;}

    public User(int id, string username, DateTime dateCreated, DateTime dateModified)
    {
        this.id = id;
        this.username = username;
        date_created = dateCreated;
        date_modified = dateModified;
    }
}