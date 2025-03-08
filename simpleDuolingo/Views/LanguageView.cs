using SimpleDuolingoWinForm;

namespace simpleDuolingo.Views;

public partial class LanguageView : UserControl
{
    private readonly Form _parentForm;
    private readonly DBDriver _DbDriver;
    public LanguageView(Form parentForm, DBDriver dbDriver)
    {
        _parentForm = parentForm;
        _DbDriver = dbDriver;
        InitializeComponent();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        _parentForm.SwitchView(Form.ViewType.NavigationView);
    }
}