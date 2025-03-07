namespace simpleDuolingo.Views;

public partial class UserView : UserControl
{
    private readonly Form _parentForm;
    public UserView(Form parentForm)
    {
        _parentForm = parentForm;
        InitializeComponent();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        _parentForm.SwitchView(Form.ViewType.NavigationView);
    }
}