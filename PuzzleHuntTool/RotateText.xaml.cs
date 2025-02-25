namespace PuzzleHuntTool;

public partial class RotateText : ContentPage
{
	public RotateText()
	{
		InitializeComponent();

        //Create elements
        CreatePage();
    }


    private void CreatePage()
    {
        //Create List of Rotation Items
        var rotationList = new List<string>();
        for (int i = 1; i < 26; i++)
        {
            rotationList.Add("ROT " + i.ToString());
        }

        //Create picker and add to VSL
        rotPicker.ItemsSource = rotationList;
    }

    private void rotateText()
    {
        var curText = textEntry.Text;
        int rotAmount = rotPicker.SelectedIndex + 1;
        if (curText == null || rotAmount == 0)
            return;

        string rotText = "";
        char newchar;

        foreach (char c in curText)
        {
            if (c >= 65 && c <= 90)
            {
                newchar = (char)(c - rotAmount);
                if (newchar < 65)
                {
                    newchar = (char)(newchar + 26);
                }
                rotText += newchar;
            }
            else if (c >= 97 && c <= 122)
            {
                newchar = (char)(c - rotAmount);
                if (newchar < 97)
                {
                    newchar = (char)(newchar + 26);
                }
                rotText += newchar;
            }
            else
            {
                rotText += c;
            }
        }

        rotatedText.Text = rotText;
    }

    private void rotPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        rotateText();
    }

    private void textEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        rotateText();
    }
}