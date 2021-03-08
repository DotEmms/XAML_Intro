using System;
using System.Collections.Generic;
using System.Text;

namespace MirrorExercise
{
    public class SmartMirror
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _temperature;

        public int Temperature
        {
            get { return _temperature; }
            set { _temperature = value; }
        }
        private string _newsItems;

        public string NewsItems
        {
            get { return _newsItems; }
            set { _newsItems = value; }
        }
        private DateTime _today;

        public DateTime Today
        {
            get { return _today; }
            set { _today = value; }
        }
        private string _stocks;

        public string Stocks
        {
            get { return _stocks; }
            set { _stocks = value; }
        }
        public int ID { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string CloudsImage { get; set; }
        public string Clouds { get; set; }
        public SmartMirror()
        {

        }
        public SmartMirror( string news)
        {
            NewsItems = news;
        }
        public SmartMirror(int id, string stocks)
        {
            Stocks = stocks;
        }
        public SmartMirror(int id, int max, int min, string cloudsImage, string clouds)
        {
            ID = id;
            Min = min;
            Max = max;
            CloudsImage = cloudsImage;
            Clouds = clouds;
        }
    }
}
