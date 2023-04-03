namespace MauiCameraMauiSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void cameraView_CamerasLoaded(object sender, EventArgs e)
        {
            cameraView.Camera = cameraView.Cameras.First();

            MainThread.BeginInvokeOnMainThread(async () =>
            {
                await cameraView.StopCameraAsync();
                await cameraView.StartCameraAsync();
            });
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            myImage.Source = cameraView.GetSnapShot(Camera.MAUI.ImageFormat.PNG);
        }
    }
}