namespace GoodDaySafetyApp;

public partial class DirectionalArea : ContentPage
{
	public string directionalArea;
	public DirectionalArea()
	{
		InitializeComponent();
	}

	private void NextPage_Click(object sender, EventArgs e)
	{
		if (Ndirectionentry.IsChecked == true)
		{
			directionalArea = "North";
            Navigation.PushAsync(new UnsafeConditions());
        }
		else if (NEdirectionentry.IsChecked)
		{
			directionalArea = "North East";
            Navigation.PushAsync(new UnsafeConditions());
        }
		else if (Edirectionentry.IsChecked)
		{
			directionalArea = "East";
            Navigation.PushAsync(new UnsafeConditions());
        }
		else if (SEdirectionentry.IsChecked)
		{
			directionalArea = "South East";
            Navigation.PushAsync(new UnsafeConditions());

        }
        else if (Sdirectionentry.IsChecked)
        {
            directionalArea = "South";
            Navigation.PushAsync(new UnsafeConditions());
        }
        else if (SWdirectionentry.IsChecked)
        {
            directionalArea = "South West";
            Navigation.PushAsync(new UnsafeConditions());
        }
        else if (Wdirectionentry.IsChecked)
        {
            directionalArea = "West";
            Navigation.PushAsync(new UnsafeConditions());
        }
        else if (NWdirectionentry.IsChecked)
        {
            directionalArea = "North West";
            Navigation.PushAsync(new UnsafeConditions());
        }

        
	}
}