namespace PuzzleHuntTool;

public partial class Atbash : ContentPage
{
	public Atbash()
	{
		InitializeComponent();
	}

    private void textEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        var curText = textEntry.Text;
        var cipherText = "";
        if (curText != null)
        {
            foreach (char c in curText)
            {
                if (c >= 'A' && c <= 'Z')
                    cipherText += (char)(155 - c);
                else if (c >= 'a' && c <= 'z')
                    cipherText += (char)(219 - c);
                else
                    cipherText += c;
            }
        }
        cipheredText.Text = cipherText;
    }
}