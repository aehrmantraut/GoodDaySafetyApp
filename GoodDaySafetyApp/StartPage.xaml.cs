


namespace GoodDaySafetyApp;

public partial class StartPage : ContentPage
{

    public static string ID;
	public StartPage()
	{
		InitializeComponent();
	}
    

    private void NextPage_Click(object sender, EventArgs e)
    {
         ID = entry.Text;
         Navigation.PushAsync(new SceneSafe());
   
    }
    
  
}