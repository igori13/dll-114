// Студет Корнилов Артем
using System;

namespace MyLibrary
{
    public class Hobby : IComparable<Hobby>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Hobby(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void Show()
        {
            Console.WriteLine($"Hobby: Name={Name}, Description={Description}");// Студет Корнилов Артем
        }

        public int CompareTo(Hobby other)
        {
            return string.Compare(Name, other.Name, StringComparison.Ordinal);// Студет Корнилов Артем
        }
    }
}
