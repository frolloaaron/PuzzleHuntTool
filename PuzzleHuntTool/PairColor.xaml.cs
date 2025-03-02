namespace PuzzleHuntTool;

public partial class PairColor : ContentPage
{
	public PairColor()
	{
		InitializeComponent();

		CreatePickers();
	}

    int color1 = -1;
    int color2 = -1;

    private void CreatePickers()
    {
        //Create Lists for each color picker
        var majorList = new List<string>();
        majorList.Add("White");
        majorList.Add("Red");
        majorList.Add("Black");
        majorList.Add("Yellow");
        majorList.Add("Violet");

        majorPicker.ItemsSource = majorList;

        var minorList = new List<string>();
        minorList.Add("Blue");
        minorList.Add("Orange");
        minorList.Add("Green");
        minorList.Add("Brown");
        minorList.Add("Slate");

        //Create picker and add to VSL
        minorPicker.ItemsSource = minorList;
    }

    private void displayLetter()
    {
        if (color1 != -1 && color2 != -1)
        {
            int num = 1 + (5 * color1) + color2;
            Display.Text = $"{num} / {(char)(num+64)}";
        }
    }

    private void majorPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        int index = majorPicker.SelectedIndex;
        color1 = index;
        switch (index)
        {
            case 0:
                MajorBox.BackgroundColor = Colors.White;
                break;
            case 1:
                MajorBox.BackgroundColor = Colors.Red;
                break;
            case 2:
                MajorBox.BackgroundColor = Colors.Black;
                break;
            case 3:
                MajorBox.BackgroundColor = Colors.Yellow;
                break;
            case 4:
                MajorBox.BackgroundColor = Colors.Violet;
                break;
        }
        displayLetter();
    }

    private void minorPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        int index = minorPicker.SelectedIndex;
        color2 = index;
        switch (index)
        {
            case 0:
                MinorBox.BackgroundColor = Colors.Blue;
                break;
            case 1:
                MinorBox.BackgroundColor = Colors.Orange;
                break;
            case 2:
                MinorBox.BackgroundColor = Colors.Green;
                break;
            case 3:
                MinorBox.BackgroundColor = Colors.Brown;
                break;
            case 4:
                MinorBox.BackgroundColor = Colors.SlateGray;
                break;
        }
        displayLetter();
    }
}