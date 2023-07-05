using System;
using System.Collections.Generic;

namespace MyLibrary// Студет Корнилов Артем
{
    public class Person// Студет Корнилов Артем
    {
        public string Address { get; set; }
        public List<Hobby> Hobbies { get; set; }

        public Person(string address)
        {
            Address = address;
            Hobbies = new List<Hobby>();
        }

        public void AddHobby(Hobby hobby)// Студет Корнилов Артем
        {
            Hobbies.Add(hobby);
        }

        public void Show()
        {
            Console.WriteLine($"Person: Address={Address}");// Студет Корнилов Артем
        }

        public void ShowAll()
        {
            foreach (Hobby hobby in Hobbies)// Студет Корнилов Артем
            {
                hobby.Show();
            }
        }
    }
}
