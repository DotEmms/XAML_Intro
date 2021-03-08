using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MirrorExercise
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<SmartMirror> news;
        public ObservableCollection<SmartMirror> stocks;
        public ObservableCollection<SmartMirror> forecast;
        SmartMirror myMirrorCodeBehind;
        public MainWindow()
        {
            InitializeComponent();
            myMirrorCodeBehind = new SmartMirror
            {
                Name = "Emma",
                Temperature = -3,
                Today = DateTime.Now,
            };
            news = GetNews();
            stocks = GetStocks();
            forecast = GetForecast();
            myGrid.DataContext = myMirrorCodeBehind;
            NewsOverviewList.ItemsSource = news;
            StocksOverviewList.ItemsSource = stocks;
            ForecastOverviewList.ItemsSource = forecast;
        }
        private ObservableCollection<SmartMirror> GetNews()
        {
            var result = new ObservableCollection<SmartMirror> 
            { 
                new SmartMirror("Personenongeval ter hoogte van Antwerpen Centraal."),
                new SmartMirror("5 tieners opgepakt wegens openbare dronkenschap."),
                new SmartMirror("Crazy cat lady strikes again!"),
                new SmartMirror("Coolest Fridge Ever!"),
            };
            return result;
        }
        private ObservableCollection<SmartMirror> GetStocks()
        {
            var result = new ObservableCollection<SmartMirror>
            {
                new SmartMirror(1, "ABI 53,61 (-0,85)"),
                new SmartMirror(2, "COLR 51,00 (-0.93)"),
                new SmartMirror(3, "BAR 18,62 (+1,00)"),
                new SmartMirror(4, "AGS 45,16 (-0,62)"),
            };
            return result;
        }
        private ObservableCollection<SmartMirror> GetForecast()
        {
            var result = new ObservableCollection<SmartMirror>
            {
                new SmartMirror(1, -2, -11, "D:/emmad/Downloads/partly_cloudy.png","Partly Clouded"),
                new SmartMirror(2, -1, -9, "D:/emmad/Downloads/sunny.png", "Sunny"),
                new SmartMirror(3, -3, -10, "D:/emmad/Downloads/partly_cloudy.png", "Partly Clouded"),
                new SmartMirror(4, -1, -7, "D:/emmad/Downloads/partly_cloudy.png", "Partly Clouded"),
            };
            return result;
        }

        private void ListViewItem_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            //extract selected Pie from ListView
            var listItem = sender as ListViewItem;
            SmartMirror weather = listItem.Content as SmartMirror;

            SmartMirror selectedWeather = forecast.FirstOrDefault(x => x.ID == 3);
            if (weather != null)
            {
                var detailView = new WeatherDetailView(weather);
                detailView.ShowDialog();
            }

        }
    }
}
