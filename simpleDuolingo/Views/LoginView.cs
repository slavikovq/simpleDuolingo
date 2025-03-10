using MySqlConnector;
using SimpleDuolingoWinForm;

namespace simpleDuolingo.Views;

public partial class LoginView : UserControl
{
    private readonly Form _parentForm;
    private DBDriver? _dbDriver;
    
    public LoginView(Form parentForm)
    {
        _parentForm = parentForm;
        InitializeComponent();
    }
    
    private void Login()
    {
        errorText.Text = "";
        string password = PasswordLogin.Text;
        
        if(string.IsNullOrEmpty(password))
        {
            errorText.Text = "Password not entered";
            return;
        }

        try
        {
            _dbDriver = new DBDriver(password);
            using (MySqlConnection conn = _dbDriver.GetConnection())
            {
                conn.Open();
                _parentForm.InitializeDatabase(password);
                conn.Close();
            } ;
        }
        catch (MySqlException e)
        {
            errorText.Text = $"Error: {e.Message}";
        }
    }

    private void PasswordLogin_Enter_1(object sender, EventArgs e)
    {
        PasswordLogin.Text = "";
        PasswordLogin.ForeColor = Color.Black;
        PasswordLogin.UseSystemPasswordChar = true;
    }

    private void PasswordLogin_Leave_1(object sender, EventArgs e)
    {
        if (PasswordLogin.Text.Length == 0)
        {
            PasswordLogin.ForeColor = Color.Gray;
            PasswordLogin.Text = "Password";
            PasswordLogin.UseSystemPasswordChar = false;
            SelectNextControl(PasswordLogin, true, true, false, true);
        }
    }

    private void PasswordLogin_KeyPress_1(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter)
        {
            Login();
        }
    }

    private void LogInButton_Click(object sender, EventArgs e)
    {
        Login();
    }
}