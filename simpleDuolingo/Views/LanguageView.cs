using simpleDuolingo.Models;

namespace simpleDuolingo.Views;

public partial class LanguageView : UserControl
{
    private readonly Form _parentForm;
    private readonly DbDriver _DbDriver;
    public LanguageView(Form parentForm, DbDriver dbDriver)
    {
        _parentForm = parentForm;
        _DbDriver = dbDriver;
        InitializeComponent();
        loadListData();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        _parentForm.SwitchView(Form.ViewType.NavigationView);
    }
    
    //create language

    private void AddLanguage()
    {
        string name = nameInput.Text;
        string difficulty = difficultyInput.Text;

        if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(difficulty))
        {
            errorText.Text = "Input is empty";
        } else if (string.IsNullOrEmpty(name))
        {
            errorText.Text = "Name input is empty";
        } else if (string.IsNullOrEmpty(difficulty))
        {
            errorText.Text = "Difficulty input is empty";
        }
        else
        {
            try
            {
                _DbDriver.CreateLanguage(name, errorText, Convert.ToInt32(difficulty));
            }
            catch
            {
                errorText.Text = "Difficulty must be a number";
            }
            nameInput.Text = "";
            difficultyInput.Text = "";
            _parentForm.RegistrationView.RefreshAllLists();
            loadListData();
        }
    }
    
    private void createInput_Click(object sender, EventArgs e)
    {
        AddLanguage();
    }


    private void nameInput_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter)
        {
            AddLanguage();
        }
    }
    
    
    //load language
    private void loadListData()
    {
        List<Language> languages = _DbDriver.GetAllLanguages();
        languageList.Items.Clear();
        foreach (var language in languages)
        {
            ListViewItem listItem = new ListViewItem(language.id.ToString());
            listItem.SubItems.Add(language.name);
            listItem.SubItems.Add(language.difficulty.ToString());
            listItem.SubItems.Add(language.date_created.ToString("yyyy-MM-dd HH:mm:ss"));
            listItem.SubItems.Add(language.date_modified.ToString("yyyy-MM-dd HH:mm:ss"));
            languageList.Items.Add(listItem);
        }
    }
    //delete language

    private void DeleteLanguage()
    {
        if (string.IsNullOrEmpty(idInput.Text))
        {
            errorText.Text = "ID not entered";
        }
        else
        {
            string[] languageIds = idInput.Text.Split(",").ToArray();
            if (!languageIds.All(id => int.TryParse(id, out _)))
            {
                errorText.Text = "Invalid input";
                return;
            }
            List<int> nonExistentId = new List<int>();
            foreach (var languageId in languageIds)
            {
                int id = int.Parse(languageId);
                if (!_DbDriver.LanguageExists(id))
                {
                    nonExistentId.Add(id);
                    continue;
                }
                _DbDriver.DeleteLanguage(id, errorText);
            }
            if (nonExistentId.Count > 0)
            {
                errorText.Text = $"ID {string.Join(", ", nonExistentId)} do not exist!";
            }
            else
            {
                errorText.Text = "";
            }
            _parentForm.RegistrationView.RefreshAllLists();
            loadListData();
            idInput.Text = "";
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        DeleteLanguage();
    }

    private void idInput_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter)
        {
            DeleteLanguage();
        }
    }
}