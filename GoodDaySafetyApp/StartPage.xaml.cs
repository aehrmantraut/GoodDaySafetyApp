


namespace GoodDaySafetyApp;

public partial class StartPage : ContentPage
{
    public string name;
	public StartPage()
	{
		InitializeComponent();
	}
    

    private void NextPage_Click(object sender, EventArgs e)
    {
         name = entry.Text;
         Navigation.PushAsync(new SceneSafe());
   
    }
    
  
}