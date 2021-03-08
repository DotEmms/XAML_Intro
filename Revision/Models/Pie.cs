using System;
using System.Collections.Generic;
using System.Text;

namespace Revision.Models
{
    public class Pie
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public Pie(int id, string name, string description = "A yummie pie")
        {
            ID = id;
            Name = name;
            Description = description;

            Price = 12.95;
            Image = "http://placekitten.com/50/50";
        }
        public override string ToString()
        {
            //string result = $"{Name} {Description}";
            //return result.ToString();
            return Name;
        }
    }
}
