namespace PuzzleHuntTool;

public partial class Baconian : ContentPage
{
	public Baconian()
	{
		InitializeComponent();
	}

    private void calcLetter()
    {
        int letter = 0;
        string message = "";
        if (Box1.BackgroundColor == Colors.Yellow)
            letter += 1;
        if (Box2.BackgroundColor == Colors.Yellow)
            letter += 2;
        if (Box4.BackgroundColor == Colors.Yellow)
            letter += 4;
        if (Box8.BackgroundColor == Colors.Yellow)
            letter += 8;
        if (Box16.BackgroundColor == Colors.Yellow)
            letter += 16;
        if(letter > 0 && letter <= 26)
        { 
            message += (char)(letter + 64);
            Display.Text = message;
        } else
        {
            Display.Text = "";
        }
    }

    private void Box_Clicked(object sender, EventArgs e)
    {
        var box = (Button)sender;
        if (box.BackgroundColor == Colors.LightGray)
        {
            box.BackgroundColor = Colors.Yellow;
        } else
        {
            box.BackgroundColor = Colors.LightGray;
        }


        calcLetter();
    }

}