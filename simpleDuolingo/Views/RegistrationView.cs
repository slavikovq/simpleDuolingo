using System.Security.Cryptography.Pkcs;
using simpleDuolingo.Models;

namespace simpleDuolingo.Views;

public partial class RegistrationView : UserControl
{
    private readonly Form _parentForm;
    private readonly DbDriver _DbDriver;
    private int _userId = 0;
    private int _languageId = 0;
    public RegistrationView(Form parentForm, DbDriver dbDriver)
    {
        _parentForm = parentForm;
        _DbDriver = dbDriver;
        InitializeComponent();
        loadListUsers();
        loadListLanguages();
        loadListData();
    }

    public void RefreshAllLists()
    {
        loadListUsers();
        loadListLanguages();
        loadListData();
    }
    
    private void button3_Click(object sender, EventArgs e)
    {
        _parentForm.SwitchView(Form.ViewType.NavigationView);
    }
    
    //load user list

    private void loadListUsers()
    {
        List<User> users = _DbDriver.GetAllUsers();
        userList.Items.Clear();
        foreach (var user in users)
        {
            ListViewItem listItem = new ListViewItem(user.id.ToString());
            listItem.SubItems.Add(user.username);
            userList.Items.Add(listItem);
        }
    }
    
    
    //load languages list

    private void loadListLanguages()
    {
            List<Language> languages = _DbDriver.GetAllLanguages();
            languageList.Items.Clear();
            foreach (var language in languages)
            {
                ListViewItem listItem = new ListViewItem(language.id.ToString());
                listItem.SubItems.Add(language.name);
                listItem.SubItems.Add(language.difficulty.ToString());
                languageList.Items.Add(listItem);
            }
    }
    
    //registration

    private void userList_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (userList.SelectedItems.Count == 0) return;
        ListViewItem selectedItem = userList.SelectedItems[0];
        int id = Convert.ToInt32(selectedItem.SubItems[0].Text);
        _userId = id;
        infoLabel1.Text = $"User ID: {id}";
    }

    private void languageList_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (languageList.SelectedItems.Count == 0) return;
        ListViewItem selectedItem = languageList.SelectedItems[0];
        int id = Convert.ToInt32(selectedItem.SubItems[0].Text);
        _languageId = id;
        infoLabel2.Text = $"ID: {id}";
    }

    private void loadListData()
    {
        List<Registration> registrations = _DbDriver.GetAllRegistrations();
        registrationList.Items.Clear();
        foreach (var registration in registrations)
        {
            ListViewItem listItem = new ListViewItem(registration.id.ToString());
            listItem.SubItems.Add(registration.user_id.ToString());
            listItem.SubItems.Add(registration.language_id.ToString());
            registrationList.Items.Add(listItem);
        }
    }
    
    //create registration

    private void AddRegistration()
    {
        if (_userId == 0 && _languageId == 0)
        {
            errorText.Text = "No User and Language ID";
        } else if (_userId == 0)
        {
            errorText.Text = "No User ID";
        } else if (_languageId == 0)
        {
            errorText.Text = "No Language ID";
        }
        else
        {
            if (!_DbDriver.ExistingRegistration(_userId, _languageId))
            {
                _DbDriver.CreateRegistration(_userId,  errorText, _languageId);
                loadListData();
                infoLabel1.Text = "";
                infoLabel2.Text = "";
                errorText.Text = "";
                _userId = 0;
                _languageId = 0;
            }
            else
            {
                errorText.Text = "User is already registered!";
            }
        }
    }

    private void registerButton_Click(object sender, EventArgs e)
    {
        AddRegistration();
    }
    
    //delete registration

    private void DeleteRegistration()
    {
        if (string.IsNullOrEmpty(idInput.Text))
        {
            errorText.Text = "ID not entered";
        }
        else
        {
            string[] registrationIds = idInput.Text.Split(",").ToArray();

            if (!registrationIds.All(id => int.TryParse(id, out _)))
            {
                errorText.Text = "Invalid input";
                return;
            }

            List<int> nonExistentId = new List<int>();
            foreach (var registrationId in registrationIds)
            {
                int id = int.Parse(registrationId);
                if (!_DbDriver.RegistrationExists(id))
                {
                    nonExistentId.Add(id);
                    continue;
                }
                _DbDriver.DeleteRegistration(id, errorText);
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

    private void deleteButton_Click(object sender, EventArgs e)
    {
        DeleteRegistration();
    }

    private void idInput_KeyPress(object sender, KeyPressEventArgs e)
    {
        if(e.KeyChar == (char)Keys.Enter)
        {
            DeleteRegistration();
        }
    }
}