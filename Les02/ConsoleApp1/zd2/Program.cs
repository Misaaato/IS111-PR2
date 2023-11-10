using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd2
{
    using System;
    public class Laptop
    {
        protected string name;
        protected double price;
        protected string processor;
        protected int ram;
        protected int hdd;

        public Laptop(string name, double price, string processor, int ram, int hdd)
        {
            this.name = name;
            this.price = price;
            this.processor = processor;
            this.ram = ram;
            this.hdd = hdd;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Price : " + price + "Р");
            Console.WriteLine("Processor : " + processor);
            Console.WriteLine("RAM : " + ram + "GB");
            Console.WriteLine("HDD : " + hdd + "GB");
        }
    }
        public class Program
        {
            public static void Main(string[] args)
            {
                Laptop laptop1 = new Laptop("Lenovo", 60000, "i3", 2, 500);
                Laptop laptop2 = new Laptop("Dell", 80000, "i5", 4, 1000);
                Laptop laptop3 = new Laptop("Sony", 100000, "i9", 8, 1000);

                laptop1.PrintInfo();
                Console.WriteLine();
                Console.WriteLine("********************************************************");
                Console.WriteLine();
                laptop2.PrintInfo();
            Console.WriteLine();
            Console.WriteLine("********************************************************");
            Console.WriteLine();
            laptop3.PrintInfo();
            Console.WriteLine();
            Console.WriteLine("********************************************************");

                Console.ReadLine();
        }
        }
}
