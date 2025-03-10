
using MySqlConnector;
using simpleDuolingo.Models;
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

        loadListData();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        _parentForm.SwitchView(Form.ViewType.NavigationView);
        errorText.Text = "";
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
            loadListData();
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

    //load users

    private void loadListData()
    {
        List<User> users = _DbDriver.GetAllUsers();
        userList.Items.Clear();
        foreach (var user in users)
        {
            ListViewItem listItem = new ListViewItem(user.id.ToString());
            listItem.SubItems.Add(user.username);
            listItem.SubItems.Add(user.date_created.ToString("yyyy-MM-dd HH:mm:ss"));
            listItem.SubItems.Add(user.date_modified.ToString("yyyy-MM-dd HH:mm:ss"));
            userList.Items.Add(listItem);
        }
    }

    //delete user

    private void DeleteUser()
    {
        if (string.IsNullOrEmpty(idInput.Text))
        {
            errorText.Text = "ID not entered";
        }
        else
        {
            string[] userIds = idInput.Text.Split(",").ToArray();
            if (!userIds.All(id => int.TryParse(id, out _)))
            {
                errorText.Text = "Invalid input";
                return;
                
            }

            List<int> nonExistentId = new List<int>();
            foreach (var userId in userIds)
            {
                int id = int.Parse(userId);
                if (!_DbDriver.UserExists(id))
                {
                    nonExistentId.Add(id);
                    continue;
                }
                _DbDriver.DeleteUser(id, errorText);
            }

            if (nonExistentId.Count > 0)
            {
                errorText.Text = $"ID {string.Join(", ", nonExistentId)} do not exist!";
            }
            else
            {
                errorText.Text = "";
            }
            loadListData();
            idInput.Text = "";
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        DeleteUser();
        
    }


    private void idInput_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter)
        {
            DeleteUser();
        }
    }
}