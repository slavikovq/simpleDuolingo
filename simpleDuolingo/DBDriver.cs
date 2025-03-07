using MySqlConnector;

namespace simpleDuolingo;

public class DBDriver
{
    public string ServerDomain = "vydb1.spsmb.cz";
    public string Username = "barbora.slavikova";
    public string Password = "heslo123";
    public string Database = "student_barbora.slavikova_simpleDuolingo";

    public DBDriver()
    {
    }

    string connectionString =>
        $"Server={ServerDomain};Database={Database};User={Username};Password={Password};SslMode=None;";

    public DBDriver(string serverDomain, string username, string password, string database)
    {
        this.ServerDomain = serverDomain;
        this.Username = username;
        this.Password = password;
        this.Database = database;
    }

    public MySqlConnection GetConnection()
    {
        try
        {
            var connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }
        catch (MySqlException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return null;
        }
    }
}