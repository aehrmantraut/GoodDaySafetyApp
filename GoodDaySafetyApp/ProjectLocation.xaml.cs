namespace GoodDaySafetyApp;

public partial class ProjectLocation : ContentPage
{
	public ProjectLocation()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        string userProjectLocation = projectLocationTextBox.Text;
        projectLocationTextBox.Text = "";

    }
}