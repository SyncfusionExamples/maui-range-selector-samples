using System.Windows.Input;

namespace GettingStarted
{
    public enum ListItems
    {
        NumericScale,
        DateTimeScale,
        Ticks,
        Labels,
        Dividers,
        Tooltips,
        Regions,
        Zooming
    }

    public class MainPageViewModel
    {
        public MainPageViewModel()
        {
            ItemTappedCommand = new Command(execute: OnItemTapped);
        }

        public Array Items
        {
            get { return Enum.GetValues(typeof(ListItems)); }
        }

        public ICommand ItemTappedCommand { private set; get; }

        private void OnItemTapped(object item)
        {
            switch (item)
            {
                case ListItems.NumericScale:
                    Application.Current.MainPage.Navigation.PushAsync(new SelectorWithNumericScale());
                    break;
                case ListItems.DateTimeScale:
                    Application.Current.MainPage.Navigation.PushAsync(new SelectorWithDateTimeScale());
                    break;
                case ListItems.Ticks:
                    Application.Current.MainPage.Navigation.PushAsync(new SelectorWithTicks());
                    break;
                case ListItems.Labels:
                    Application.Current.MainPage.Navigation.PushAsync(new SelectorWithLabels());
                    break;
                case ListItems.Dividers:
                    Application.Current.MainPage.Navigation.PushAsync(new SelectorWithDividers());
                    break;
                case ListItems.Tooltips:
                    Application.Current.MainPage.Navigation.PushAsync(new SelectorWithTooltips());
                    break;
                case ListItems.Regions:
                    Application.Current.MainPage.Navigation.PushAsync(new SelectorWithRegions());
                    break;
                case ListItems.Zooming:
                    Application.Current.MainPage.Navigation.PushAsync(new ZoomingPage());
                    break;
            }
        }
    }
}
