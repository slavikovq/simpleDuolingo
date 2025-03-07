using MySqlConnector;

namespace SimpleDuolingoWinForm;

public class DBDriver
{
    public string ServerDomain = "vydb1.spsmb.cz";
    public string Username = "barbora.slavikova";
    public string Password = "";
    public string Database = "student_barbora.slavikova_simpleDuolingo";
    
    public string connectionString =>
        $"Server={ServerDomain};Database={Database};User={Username};Password={Password};";

    public Exception? ThrownException;

    public DBDriver(string password)
    {
        Password = password;
    }

    public MySqlConnection GetConnection()
    {
        return new MySqlConnection(connectionString);
    }
}