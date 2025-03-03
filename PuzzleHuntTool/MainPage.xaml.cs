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

        private void Braille_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Braille());
        }

        private void PairColor_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PairColor());
        }

        private void Atbash_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Atbash());
        }
    }

}
