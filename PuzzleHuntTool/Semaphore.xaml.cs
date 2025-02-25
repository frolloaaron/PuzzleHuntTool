namespace PuzzleHuntTool;

public partial class Semaphore : ContentPage
{
	public Semaphore()
	{
		InitializeComponent();
	}

	int total = 0;


	private void calcLetter()
	{
        switch (total)
        {
            case 96:
                display.Text = "A";
                break;
            case 72:
                display.Text = "B";
                break;
            case 65:
                display.Text = "C";
                break;
            case 66:
                display.Text = "D";
                break;
            case 68:
                display.Text = "E";
                break;
            case 80:
                display.Text = "F";
                break;
            case 192:
                display.Text = "G";
                break;
            case 40:
                display.Text = "H";
                break;
            case 33:
                display.Text = "I";
                break;
            case 18:
                display.Text = "J";
                break;
            case 34:
                display.Text = "K";
                break;
            case 36:
                display.Text = "L";
                break;
            case 48:
                display.Text = "M";
                break;
            case 160:
                display.Text = "N";
                break;
            case 9:
                display.Text = "O";
                break;
            case 10:
                display.Text = "P";
                break;
            case 12:
                display.Text = "Q";
                break;
            case 24:
                display.Text = "R";
                break;
            case 136:
                display.Text = "S";
                break;
            case 3:
                display.Text = "T";
                break;
            case 5:
                display.Text = "U";
                break;
            case 130:
                display.Text = "V";
                break;
            case 20:
                display.Text = "W";
                break;
            case 132:
                display.Text = "X";
                break;
            case 17:
                display.Text = "Y";
                break;
            case 144:
                display.Text = "Z";
                break;
            case 6:
                display.Text = "Numerals";
                break;
            case 129:
                display.Text = "Ignore previous message";
                break;
            case 64:
                display.Text = "Space";
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

    private void BoxT_Clicked(object sender, EventArgs e)
    {
        buttonChange((Button)sender, 2);
    }

    private void BoxTR_Clicked(object sender, EventArgs e)
    {
        buttonChange((Button)sender, 4);
    }

    private void BoxML_Clicked(object sender, EventArgs e)
    {
        buttonChange((Button)sender, 8);
    }

    private void BoxMR_Clicked(object sender, EventArgs e)
    {
        buttonChange((Button)sender, 16);
    }

    private void BoxBL_Clicked(object sender, EventArgs e)
    {
        buttonChange((Button)sender, 32);
    }

    private void BoxBM_Clicked(object sender, EventArgs e)
    {
        buttonChange((Button)sender, 64);
    }

    private void BoxBR_Clicked(object sender, EventArgs e)
    {
        buttonChange((Button)sender, 128);
    }
}