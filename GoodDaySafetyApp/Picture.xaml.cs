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

    private void CameraBtn_Clicked(object sender, EventArgs e)
    {
        myImage.Source = cameraView.GetSnapShot(Camera.MAUI.ImageFormat.PNG);
    }
}