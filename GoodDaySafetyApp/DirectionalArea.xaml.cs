namespace GoodDaySafetyApp;

public partial class DirectionalArea : ContentPage
{
	public DirectionalArea()
	{
		InitializeComponent();
	}

	private void NextPage_Click(object sender, EventArgs e)
	{
		Navigation.PushAsync(new UnsafeConditions());
	}
}