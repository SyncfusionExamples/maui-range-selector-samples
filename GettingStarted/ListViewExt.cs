using System.Windows.Input;

namespace GettingStarted
{
    public class ListViewExt : ListView
    {
        public static BindableProperty ItemTappedCommandProperty =
            BindableProperty.Create(nameof(ItemTappedCommand), typeof(ICommand), typeof(ListViewExt));

        public ListViewExt()
        {
            ItemTapped += OnItemTapped;
        }

        public ICommand ItemTappedCommand
        {
            get { return (ICommand)GetValue(ItemTappedCommandProperty); }
            set { SetValue(ItemTappedCommandProperty, value); }
        }

        private void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null && ItemTappedCommand != null && ItemTappedCommand.CanExecute(e))
            {
                ItemTappedCommand.Execute(e.Item);
                SelectedItem = null;
            }
        }
    }
}
