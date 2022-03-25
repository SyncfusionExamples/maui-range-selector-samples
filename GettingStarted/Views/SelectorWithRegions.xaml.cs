namespace GettingStarted;

public partial class SelectorWithRegions : ContentPage
{
	public SelectorWithRegions()
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
            e.Style.InactiveTextColor = Colors.DarkViolet.WithAlpha(0.25f);
            return;
        }

        e.Style.InactiveTextColor = e.Style.InactiveTextColor.WithAlpha(0.25f);
        e.Text = text[0];
    }
}