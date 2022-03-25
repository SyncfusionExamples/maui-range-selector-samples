using System.Collections.ObjectModel;

namespace GettingStarted
{
    public partial class Model
    {
        public Model(DateTime x, double numX, double y)
        {
            X = x;
            NumX = numX;
            Y = y;
        }

        public DateTime X { get; set; }

        public double NumX { get; set; }

        public double Y { get; set; }
    }

    public class ChartViewModel
    {
        public ChartViewModel()
        {
            Source = new ObservableCollection<Model>
            {
                new Model(new DateTime(1990, 01, 01), 01, 415),
                new Model(new DateTime(1990, 01, 16), 02, 408),
                new Model(new DateTime(1990, 02, 01), 03, 415),
                new Model(new DateTime(1990, 02, 16), 04, 350),
                new Model(new DateTime(1990, 03, 01), 05, 375),
                new Model(new DateTime(1990, 03, 16), 06, 500),
                new Model(new DateTime(1990, 04, 01), 07, 390),
                new Model(new DateTime(1990, 04, 16), 08, 400),
                new Model(new DateTime(1990, 05, 01), 09, 440),
                new Model(new DateTime(1990, 05, 16), 10, 350),
                new Model(new DateTime(1990, 06, 01), 11, 400),
                new Model(new DateTime(1990, 06, 16), 12, 365),
                new Model(new DateTime(1990, 07, 01), 13, 490),
                new Model(new DateTime(1990, 07, 16), 14, 400),
                new Model(new DateTime(1990, 08, 01), 15, 520),
                new Model(new DateTime(1990, 08, 16), 16, 510),
                new Model(new DateTime(1990, 09, 01), 17, 395),
                new Model(new DateTime(1990, 09, 16), 18, 380),
                new Model(new DateTime(1990, 10, 01), 19, 404),
                new Model(new DateTime(1990, 10, 16), 20, 430),
                new Model(new DateTime(1990, 11, 01), 21, 375),
                new Model(new DateTime(1990, 11, 16), 22, 350),
                new Model(new DateTime(1990, 12, 01), 23, 398),
                new Model(new DateTime(1990, 12, 16), 24, 432),
            };
        }

        public ObservableCollection<Model> Source { get; set; }
    }
}
