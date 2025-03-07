namespace simpleDuolingo.Views;

public partial class LanguageView : UserControl
{
    private readonly Form _parentForm;
    public LanguageView(Form parentForm)
    {
        _parentForm = parentForm;
        InitializeComponent();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        _parentForm.SwitchView(Form.ViewType.NavigationView);
    }
}