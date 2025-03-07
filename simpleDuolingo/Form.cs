using simpleDuolingo.Views;

namespace simpleDuolingo;

    public partial class Form : System.Windows.Forms.Form
    {
    private NavigationView _navigationView;
    private UserView _userView;
    private RegistrationView _registrationView;
    private LanguageView _languageView;
    private LoginView _loginView;
    
    private UserControl _currentView;

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
        _navigationView = new NavigationView(this);
        _userView = new UserView(this);
        _registrationView = new RegistrationView(this);
        _languageView = new LanguageView(this);
        
        SwitchView(ViewType.LoginView);
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