using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd5
{
    using System;

    abstract class Animal
    {
        protected string Name { get; set; }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public abstract void Eat();
    }

    class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Собака ест");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя собаки: ");
            string name = Console.ReadLine();

            Dog dog = new Dog();
            dog.SetName(name);

            Console.WriteLine("Имя собаки: " + dog.GetName());
            dog.Eat();
            Console.ReadLine();
        }
    }
}
