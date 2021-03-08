using System;
using System.Collections.Generic;
using System.Text;

namespace DataBindingExample
{
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Hobbies { get; set; }
        public int SelectedValue { get; set; }

        public Person()
        {
            Age = 24;
            Name = "Jack";
            Hobbies = "Hiking";
            SelectedValue = 5;
        }
    }
}
