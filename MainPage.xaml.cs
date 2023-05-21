namespace CodeSnippetManager;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	public void OnExploreClicked(object sender, EventArgs e)
	{
        Navigation.PushAsync(new SnippetListPage());
    }
}

