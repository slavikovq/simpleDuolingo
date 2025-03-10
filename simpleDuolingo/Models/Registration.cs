namespace simpleDuolingo.Models;

public class Registration
{
    public int id { get; set; }
    public int user_id { get; set; }
    public int language_id { get; set; }


    public Registration(int id, int userId, int languageId)
    {
        this.id = id;
        user_id = userId;
        language_id = languageId;
    }
}