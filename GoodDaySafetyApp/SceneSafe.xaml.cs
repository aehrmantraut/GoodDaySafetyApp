namespace GoodDaySafetyApp;

public partial class SceneSafe : ContentPage
{
	public SceneSafe()
	{
		InitializeComponent();
	}

    private void NextPage_Click(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ProjectName());
    }
}