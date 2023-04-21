namespace GoodDaySafetyApp;

public partial class ProjectLocation : ContentPage
{
    public string projectLocation;
	public ProjectLocation()
	{
		InitializeComponent();
	}
    private void NextPage_Click(object sender, EventArgs e)
    {
        projectLocation = projectLocationTextBox.Text;
        if (projectLocation != null)
        {
            Navigation.PushAsync(new DirectionalArea());
        }
    }
}