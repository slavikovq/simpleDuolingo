using simpleDuolingo.Views;
using SimpleDuolingoWinForm;

namespace simpleDuolingo;

    public partial class Form : System.Windows.Forms.Form
    {
    private NavigationView _navigationView;
    private UserView _userView;
    private RegistrationView _registrationView;
    private LanguageView _languageView;
    private LoginView _loginView;
    
    private UserControl _currentView;
    private DBDriver _dbDriver;
    

    public enum ViewType
    {
        LoginView,
        NavigationView,
        UserView,
        RegistrationView,
        LanguageView
    }
    
    public Form()
    {
        InitializeComponent();
        _loginView = new LoginView(this);
        
        SwitchView(ViewType.LoginView);
    }

    public void InitializeDatabase(string password)
    {
       _dbDriver = new DBDriver(password);
        _loginView = new LoginView(this);
        _navigationView = new NavigationView(this);
        _userView = new UserView(this, _dbDriver);
        _registrationView = new RegistrationView(this, _dbDriver);
        _languageView = new LanguageView(this, _dbDriver);
        
        SwitchView(ViewType.NavigationView);
    }

    public void SwitchView(ViewType view)
    {
        Controls.Remove(_currentView);
        _currentView = view switch
        {
            ViewType.LoginView => _loginView,
            ViewType.NavigationView => _navigationView,
            ViewType.UserView => _userView,
            ViewType.RegistrationView => _registrationView,
            ViewType.LanguageView => _languageView,
        };
        Controls.Add(_currentView);
    }
    
    
}