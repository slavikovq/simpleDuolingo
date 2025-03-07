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

    private void PasswordLogin_Enter(object sender, EventArgs e)
    {
        PasswordLogin.Text = "";
        PasswordLogin.ForeColor = Color.Black;
        PasswordLogin.UseSystemPasswordChar = true;
    }

    private void PasswordLogin_Leave(object sender, EventArgs e)
    {
        if (PasswordLogin.Text.Length == 0)
        {
            PasswordLogin.ForeColor = Color.Gray;
            PasswordLogin.Text = "Password";
            PasswordLogin.UseSystemPasswordChar = false;
            SelectNextControl(PasswordLogin, true, true, false, true);
        }
    }
    

    private void LogInButton_Click(object sender, EventArgs e)
    {
        
    }

    private void PasswordLogin_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter)
        {
            
        }
    }
}