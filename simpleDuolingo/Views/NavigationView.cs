namespace simpleDuolingo.Views;

public partial class NavigationView : UserControl
{
    private readonly Form _parentForm;
    public NavigationView(Form parentForm)
    {
        _parentForm = parentForm;
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        _parentForm.SwitchView(Form.ViewType.UserView);
    }

    private void button2_Click(object sender, EventArgs e)
    {
        _parentForm.SwitchView(Form.ViewType.LanguageView);
    }

    private void button3_Click(object sender, EventArgs e)
    {
        _parentForm.SwitchView(Form.ViewType.RegistrationView);
    }
}