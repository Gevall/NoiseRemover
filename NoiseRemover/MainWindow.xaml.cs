using NoiseRemover.Logic;
using NoiseRemover.Logic.Interfaces;
using System.Windows;
using ScottPlot;

namespace NoiseRemover
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Loaded += (s, e) =>
            {
                double[] dataX = { 1, 2, 3, 4, 5 };
                double[] dataY = { 1, 4, 9, 16, 25 };
                WpfPlot1.Plot.Add.Scatter(dataX, dataY);
                WpfPlot1.Refresh();
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ILoadData data = new LoadData();
            string path = data.OpenFile();
            var test = data.LoadDataFromFile(path);
        }
    }
}
