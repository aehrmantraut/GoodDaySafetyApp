namespace GoodDaySafetyApp;

public partial class ProjectName : ContentPage
{
    public string projectname;
	public ProjectName()
	{
		InitializeComponent();
	}
    private void NextPage_Click(object sender, EventArgs e)
    {
        projectname = projectNameEntry.Text;
       
        Navigation.PushAsync(new ProjectLocation());
        
    }
}