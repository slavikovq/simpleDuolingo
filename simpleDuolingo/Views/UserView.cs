
using MySqlConnector;
using SimpleDuolingoWinForm;

namespace simpleDuolingo.Views;

public partial class UserView : UserControl
{
    private readonly Form _parentForm;
    private readonly DBDriver _DbDriver;
    public UserView(Form parentForm, DBDriver dbDriver)
    {
        _parentForm = parentForm;
        _DbDriver = dbDriver;
        InitializeComponent();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        _parentForm.SwitchView(Form.ViewType.NavigationView);
    }
    
    //create user

    private void AddUser()
    {
        string name = nameInput.Text;
        if (string.IsNullOrEmpty(name))
        {
            errorText.Text = "Input is empty!";
        }
        else
        {
                _DbDriver.CreateUser(name, errorText);
                nameInput.Text = "";
        }
    }
    private void nameInput_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter)
        {
            AddUser();
        }
    }


    private void button2_Click(object sender, EventArgs e)
    {
        AddUser();
    }
}