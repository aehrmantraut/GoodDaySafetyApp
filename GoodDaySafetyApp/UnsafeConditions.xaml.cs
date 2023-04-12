namespace GoodDaySafetyApp;

public partial class UnsafeConditions : ContentPage
{
	public UnsafeConditions()
	{
		InitializeComponent();
	}

    private void NextPage_Click(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Comments());
    }
}