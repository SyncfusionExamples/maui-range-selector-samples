using Syncfusion.Maui.Charts;
using Syncfusion.Maui.Sliders;

namespace GettingStarted;

public partial class ZoomingPage : ContentPage
{
    public ZoomingPage()
    {
        InitializeComponent();

        ChartViewModel viewModel = new ChartViewModel();

        SfDateTimeRangeSelector selector = new SfDateTimeRangeSelector()
        {
            Minimum = new DateTime(1990, 01, 01),
            Maximum = new DateTime(1991, 01, 01),
            RangeStart = new DateTime(1990, 03, 01),
            RangeEnd = new DateTime(1990, 09, 01),
            Interval = 1,
            IntervalType = SliderDateIntervalType.Months,
            ShowTicks = true,
            ShowLabels = true,
            DateFormat = "MMM",
            Tooltip = new SliderTooltip() { ShowAlways = true, DateFormat = "dd MMM" },
            HeightRequest = 150
        };

        SfCartesianChart areaChart = new SfCartesianChart();
        areaChart.XAxes.Add(new DateTimeAxis()
        {
            IsVisible = false,
            ShowMajorGridLines = false
        });
        areaChart.YAxes.Add(new NumericalAxis()
        {
            IsVisible = false,
            ShowMajorGridLines = false,
            Minimum = 250,
        });

        AreaSeries areaSeries = new AreaSeries()
        {
            ItemsSource = viewModel.Source,
            XBindingPath = "X",
            YBindingPath = "Y"
        };

        areaChart.Series.Add(areaSeries);

        selector.Content = areaChart;

        SfCartesianChart lineChart = new SfCartesianChart() { HeightRequest = 200 };

        DateTimeAxis dateTimeAxis = new DateTimeAxis();

        Binding binding = new Binding();
        binding.Source = selector;
        binding.Path = "RangeStart";
        dateTimeAxis.SetBinding(DateTimeAxis.MinimumProperty, binding);

        binding = new Binding();
        binding.Source = selector;
        binding.Path = "RangeEnd";
        dateTimeAxis.SetBinding(DateTimeAxis.MaximumProperty, binding);

        lineChart.XAxes.Add(dateTimeAxis);
        lineChart.YAxes.Add(new NumericalAxis());

        LineSeries lineSeries = new LineSeries()
        {
            ItemsSource = viewModel.Source,
            XBindingPath = "X",
            YBindingPath = "Y"
        };

        lineChart.Series.Add(lineSeries);

        VerticalStackLayout verticalStackLayout = new VerticalStackLayout()
        {
            Spacing = 15,
            MaximumWidthRequest = 400,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
        };

        verticalStackLayout.Children.Add(lineChart);
        verticalStackLayout.Children.Add(selector);

        //Content = verticalStackLayout;
    }
}
