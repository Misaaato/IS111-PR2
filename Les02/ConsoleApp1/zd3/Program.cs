using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd3
{
    using System;

    class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        ~Person()
        {
            Name = string.Empty;
        }

        public override string ToString()
        {
            return Name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[3];

            for (int i = 0; i < people.Length; i++)
            {
                Console.Write("Введите имя человека: ");
                string name = Console.ReadLine();
                people[i] = new Person(name);
            }

            Console.WriteLine("Имена введенных людей:");
            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine(people[i]);
            }
            Console.ReadLine();
        }
    }
}
