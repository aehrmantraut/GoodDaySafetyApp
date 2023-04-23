namespace GoodDaySafetyApp;

public partial class Comments : ContentPage
{
    public string comments;
	public Comments()
	{
		InitializeComponent();
	}
    private void NextPage_Click(object sender, EventArgs e)
    {
        comments = commentsentry.Text;
        Navigation.PushAsync(new Picture());
    }
}