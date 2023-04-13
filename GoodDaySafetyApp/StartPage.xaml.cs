namespace GoodDaySafetyApp;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
	}

    private void NextPage_Click(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SceneSafe());
    }
}