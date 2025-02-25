namespace PuzzleHuntTool
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void RotateText_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RotateText());
        }

        private void Semaphore_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Semaphore());
        }
    }

}
