namespace simpleDuolingo.Models;

public class Language
{
    public int id { get; set; }
    public string name { get; set; }
    public int difficulty { get; set; }
    public DateTime date_created { get; set; }
    public DateTime date_modified { get; set; }
}