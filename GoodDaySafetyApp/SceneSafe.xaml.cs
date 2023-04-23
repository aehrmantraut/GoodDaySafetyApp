



namespace GoodDaySafetyApp;

public partial class SceneSafe : ContentPage
{
    public string value;
	public SceneSafe()
	{
		InitializeComponent();
	}

    private void NextPage_Click(object sender, EventArgs e)
    {
        if (yesButton.IsChecked == true)
        {
           
            value = "yes";
            Navigation.PushAsync(new ProjectName());
        }
        else if (noButton.IsChecked == true)
                {
            value = "no";
            Navigation.PushAsync(new ProjectName());
        }
    
        
    }
}