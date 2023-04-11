namespace GoodDaySafetyApp;

public partial class Picture : ContentPage
{
	public Picture()
	{
		InitializeComponent();

	}
    private void cameraView_CamerasLoaded(object sender, EventArgs e) { 
		cameraView.Camera = cameraView.Cameras.First(); 
		MainThread.BeginInvokeOnMainThread(async () => { 
			await cameraView.StopCameraAsync(); 
			await cameraView.StartCameraAsync(); 
		}); 
	}
}