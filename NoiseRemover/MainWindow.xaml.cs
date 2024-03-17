using NoiseRemover.Logic;
using NoiseRemover.Logic.Interfaces;
using System.Windows;
using ScottPlot;
using NoiseRemover.Logic.Classes;

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
        }

        private void LoadDataFromJson(object sender, RoutedEventArgs e)
        {
            IPrintGraph graph = new PrintGraph();
            graph.PrintedGraph(this);
            
        }
    }
}
