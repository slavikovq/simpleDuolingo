using System.Security.Cryptography;
using Microsoft.VisualBasic.ApplicationServices;
using MySqlConnector;
using simpleDuolingo.Models;
using User = simpleDuolingo.Models.User;

namespace SimpleDuolingoWinForm;

public class DBDriver
{
    public string ServerDomain = "localhost";
    public string Username = "root";
    public string Password = "";
    public string Database = "student_barbora.slavikova_simpleduolingo";
    
    public string connectionString =>
        $"Server={ServerDomain};Database={Database};User={Username};Password={Password}; Port=3306";

    public Exception? ThrownException;

    public DBDriver(string password)
    {
        Password = password;
    }

    public MySqlConnection GetConnection()
    {
        return new MySqlConnection(connectionString);
    }
    
    // Users

    public List<User> GetAllUsers()
    {
        List<User> users = new List<User>();

        string command = "SELECT * FROM users";
        using (MySqlCommand cmd = new MySqlCommand(command, GetConnection()))
        using (MySqlDataReader reader = cmd.ExecuteReader())
        {
            while (reader.Read())
            {
                User user = new User(
                reader.GetInt32(0),
                reader.GetString(1),
                reader.GetDateTime(2),
                reader.GetDateTime(3)
                    );
                users.Add(user);
            }
        }

        return users;
    }

    public void CreateUser(string username, Label errorText)
    {
        try
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open(); 
                string command = "INSERT INTO users (username) VALUES (@username)";
                var cmd = new MySqlCommand(command, conn); 
                cmd.Parameters.AddWithValue("@username", username);
                cmd.ExecuteNonQuery();
            }
        }
        catch (MySqlException e)
        {
            errorText.Text = $"Error: {e.Message}";
        }
    }

    public void DeleteUser(int id, Label errorText)
    {
        try
        {
            string command = "DELETE FROM users WHERE id = @id";
            var cmd = new MySqlCommand(command, GetConnection());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
        catch (MySqlException e)
        {
            errorText.Text = $"Error: {e.Message}";
        }
    }
}