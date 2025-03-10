using MySqlConnector;
using simpleDuolingo.Models;
using User = simpleDuolingo.Models.User;

namespace simpleDuolingo;

public class DbDriver
{
    public string ServerDomain = "localhost";
    public string Username = "root";
    public string Password = "";
    public string Database = "student_barbora.slavikova_simpleduolingo";
    
    public string ConnectionString =>
        $"Server={ServerDomain};Database={Database};User={Username};Password={Password}; Port=3306";

    public Exception? ThrownException;

    public DbDriver(string password)
    {
        Password = password;
    }

    public MySqlConnection GetConnection()
    {
        return new MySqlConnection(ConnectionString);
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
    
    //registration
    
          public List<Registration> GetAllRegistrations()
    {
        List<Registration> registrations = new List<Registration>();
        
        using (MySqlConnection connection = GetConnection())
        {
            connection.Open();
            
            string command = "SELECT * FROM user_language_registration";
            var cmd = new MySqlCommand(command, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                Registration registration = new Registration(
                    reader.GetInt32(0),
                    reader.GetInt32(1),
                    reader.GetInt32(2)
                );
                
                registrations.Add(registration);
            }
        }
        return registrations;
    }

    public void CreateRegistration(int userId, Label errorText, int languageId)
    {
        try
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open(); 
                string command = "INSERT INTO user_language_registration (user_id, language_id) VALUES (@user_id, @language_id)";
                var cmd = new MySqlCommand(command, conn); 
                cmd.Parameters.AddWithValue("@user_id", userId);
                cmd.Parameters.AddWithValue("@language_id", languageId);
                cmd.ExecuteNonQuery();
            }
        }
        catch (MySqlException e)
        {
            errorText.Text = $"Error: {e.Message}";
        }
    }

    public void DeleteRegistration(int id, Label errorText)
    {
        try
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string command = "DELETE FROM user_language_registration WHERE id = @id";
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
    public bool RegistrationExists(int id)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string command = "SELECT COUNT(*) FROM user_language_registration WHERE id = @id";
            var cmd = new MySqlCommand(command, conn);
            cmd.Parameters.AddWithValue("@id", id);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }
    }
    
    public bool ExistingRegistration(int userId, int languageId)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string command = "SELECT COUNT(*) FROM user_language_registration WHERE user_id = @userId AND language_id = @languageId";
            var cmd = new MySqlCommand(command, conn);
            cmd.Parameters.AddWithValue("@userId", userId);
            cmd.Parameters.AddWithValue("@languageId", languageId);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }
    }
}