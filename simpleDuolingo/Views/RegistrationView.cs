namespace simpleDuolingo.Views;

public partial class RegistrationView : UserControl
{
    private readonly Form _parentForm;
    public RegistrationView(Form parentForm)
    {
        _parentForm = parentForm;
        InitializeComponent();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        _parentForm.SwitchView(Form.ViewType.NavigationView);
    }
}