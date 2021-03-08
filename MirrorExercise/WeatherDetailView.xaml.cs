using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MirrorExercise
{
    /// <summary>
    /// Interaction logic for WeatherDetailView.xaml
    /// </summary>
    public partial class WeatherDetailView : Window
    {
        public SmartMirror MyDetailedWeather { get; set; }
        public WeatherDetailView(SmartMirror mirror)
        {
            InitializeComponent();
            MyDetailedWeather = mirror;
            this.DataContext = mirror;
        }
        
    }
}
