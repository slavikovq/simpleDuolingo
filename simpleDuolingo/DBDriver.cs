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
        
        using (MySqlConnection connection = GetConnection())
        {
            connection.Open();
            
            string command = "SELECT * FROM users";
            var cmd = new MySqlCommand(command, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            
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
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string command = "DELETE FROM users WHERE id = @id";
                var cmd = new MySqlCommand(command, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
        catch (MySqlException e)
        {
            errorText.Text = $"Error: {e.Message}";
        }
    }

    public bool UserExists(int id)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string command = "SELECT COUNT(*) FROM users WHERE id = @id";
            var cmd = new MySqlCommand(command, conn);
            cmd.Parameters.AddWithValue("@id", id);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }
    }
    
    //languages
    
      public List<Language> GetAllLanguages()
    {
        List<Language> languages = new List<Language>();
        
        using (MySqlConnection connection = GetConnection())
        {
            connection.Open();
            
            string command = "SELECT * FROM languages";
            var cmd = new MySqlCommand(command, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                Language language = new Language(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetInt32(2),
                    reader.GetDateTime(3),
                    reader.GetDateTime(4)
                    
                );
                
                languages.Add(language);
            }
        }
        return languages;
    }

    public void CreateLanguage(string name, Label errorText, int difficulty)
    {
        try
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open(); 
                string command = "INSERT INTO languages (name, difficulty) VALUES (@name, @difficulty)";
                var cmd = new MySqlCommand(command, conn); 
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@difficulty", difficulty);
                cmd.ExecuteNonQuery();
            }
        }
        catch (MySqlException e)
        {
            errorText.Text = $"Error: {e.Message}";
        }
    }

    public void DeleteLanguage(int id, Label errorText)
    {
        try
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string command = "DELETE FROM languages WHERE id = @id";
                var cmd = new MySqlCommand(command, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
        catch (MySqlException e)
        {
            errorText.Text = $"Error: {e.Message}";
        }
    }

    public bool LanguageExists(int id)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string command = "SELECT COUNT(*) FROM languages WHERE id = @id";
            var cmd = new MySqlCommand(command, conn);
            cmd.Parameters.AddWithValue("@id", id);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }
    }
}