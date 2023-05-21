namespace CodeSnippetManager;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	public void OnExploreClicked(object sender, EventArgs e)
	{
        Shell shell = Shell.Current;
        ShellContent SnippetList = shell.FindByName<ShellContent>("Snippets");
        shell.CurrentItem = SnippetList;
    }
}

