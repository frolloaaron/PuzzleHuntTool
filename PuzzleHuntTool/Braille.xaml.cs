namespace PuzzleHuntTool;

public partial class Braille : ContentPage
{
	public Braille()
	{
		InitializeComponent();
	}

    int total = 0;


    private void calcLetter()
    {
        switch (total)
        {
            case 1:
                display.Text = "A";
                break;
            case 5:
                display.Text = "B";
                break;
            case 3:
                display.Text = "C";
                break;
            case 11:
                display.Text = "D";
                break;
            case 9:
                display.Text = "E";
                break;
            case 7:
                display.Text = "F";
                break;
            case 15:
                display.Text = "G";
                break;
            case 13:
                display.Text = "H";
                break;
            case 6:
                display.Text = "I";
                break;
            case 14:
                display.Text = "J";
                break;
            case 17:
                display.Text = "K";
                break;
            case 21:
                display.Text = "L";
                break;
            case 19:
                display.Text = "M";
                break;
            case 27:
                display.Text = "N";
                break;
            case 25:
                display.Text = "O";
                break;
            case 23:
                display.Text = "P";
                break;
            case 31:
                display.Text = "Q";
                break;
            case 29:
                display.Text = "R";
                break;
            case 22:
                display.Text = "S";
                break;
            case 30:
                display.Text = "T";
                break;
            case 49:
                display.Text = "U";
                break;
            case 53:
                display.Text = "V";
                break;
            case 46:
                display.Text = "W";
                break;
            case 51:
                display.Text = "X";
                break;
            case 59:
                display.Text = "Y";
                break;
            case 57:
                display.Text = "Z";
                break;
            case 58:
                display.Text = "#";
                break;
            default:
                display.Text = "";
                break;
        }

    }

    private void buttonChange(Button b, int a)
    {
        if (b.BackgroundColor == Colors.LightGray)
        {
            b.BackgroundColor = Colors.Yellow;
            total += a;
        }
        else
        {
            b.BackgroundColor = Colors.LightGray;
            total -= a;
        }
        calcLetter();
    }

    private void BoxTL_Clicked(object sender, EventArgs e)
    {
        buttonChange((Button)sender, 1);
    }

    private void BoxTR_Clicked(object sender, EventArgs e)
    {
        buttonChange((Button)sender, 2);
    }

    private void BoxML_Clicked(object sender, EventArgs e)
    {
        buttonChange((Button)sender, 4);
    }

    private void BoxMR_Clicked(object sender, EventArgs e)
    {
        buttonChange((Button)sender, 8);
    }

    private void BoxBL_Clicked(object sender, EventArgs e)
    {
        buttonChange((Button)sender, 16);
    }

    private void BoxBR_Clicked(object sender, EventArgs e)
    {
        buttonChange((Button)sender, 32);
    }
}