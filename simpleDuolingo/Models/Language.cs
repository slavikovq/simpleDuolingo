namespace simpleDuolingo.Models;

public class Language
{
    public int id { get; set; }
    public string name { get; set; }
    public int difficulty { get; set; }
    public DateTime date_created { get; set; }
    public DateTime date_modified { get; set; }

    public Language(int id, string name, int difficulty, DateTime dateCreated, DateTime dateModified)
    {
        this.id = id;
        this.name = name;
        this.difficulty = difficulty;
        date_created = dateCreated;
        date_modified = dateModified;
    }
}