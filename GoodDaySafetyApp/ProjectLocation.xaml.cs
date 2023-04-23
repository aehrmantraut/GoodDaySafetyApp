namespace GoodDaySafetyApp;

public partial class ProjectLocation : ContentPage
{
    public static string projectLocation;
	public ProjectLocation()
	{
		InitializeComponent();
	}
    private void NextPage_Click(object sender, EventArgs e)
    {
        projectLocation = projectLocationTextBox.Text;
     
            Navigation.PushAsync(new DirectionalArea());
       
    }
}