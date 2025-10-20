using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }

        public Person(string name, int age, int height)
        {
            Name = name;
            Age = age;
            Height = height;
        }

        public static Person GetMe()
        {
            return new Person("Csaba", 21, 180);
        }

        public string GetDiscription()
        {
            return $"{Name} ({Height} cm) születésnapja {DateTime.Now.Year-Age}.{DateTime.Now.Month}.{DateTime.Now.Day}";
        }
    }
}
