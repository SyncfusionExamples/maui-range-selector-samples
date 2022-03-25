namespace GettingStarted;

public partial class SelectorWithTooltips : ContentPage
{
	public SelectorWithTooltips()
	{
		InitializeComponent();
	}

    private void OnSelectorLabelCreated(object sender, Syncfusion.Maui.Sliders.SliderLabelCreatedEventArgs e)
    {
		string[] text = e.Text.Split();
        if (text[0].Contains("Jan"))
        {
            e.Text = text[0] + " " + text[1].Substring(2);
            e.Style.ActiveTextColor = Colors.DarkViolet;
            e.Style.InactiveTextColor = Colors.DarkViolet;
            return;
        }

        e.Text = text[0];
    }
}