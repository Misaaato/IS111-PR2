using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Money
    {
        private int rubles;
        private int kopeks;

        public int Rubles
        {
            get { return rubles; }
            set { rubles = value; }
        }

        public int Kopeks
        {
            get { return kopeks; }
            set { kopeks = value; }
        }

        public Money(int rubles, int kopeks)
        {
            this.rubles = rubles;
            this.kopeks = kopeks;
        }

        public void Display()
        {
            Console.WriteLine("{0} рублей {1} копеек", rubles, kopeks);
        }
    }

    public class Good
    {
        private string name;
        private Money price;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Money Price { get; set; }
        public Good(string name, Money price)
        {
            this.name = name;
            this.price = price;
        }

        public void DecreasePriceByPercentage(int percentage)
        {
            int totalKopeks = price.Rubles * 100 + price.Kopeks;
            totalKopeks -= totalKopeks * percentage / 100;

            int newRubles = totalKopeks / 100;
            int newKopeks = totalKopeks % 100;

            price.Rubles = newRubles;
            price.Kopeks = newKopeks;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Money price = new Money(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Good good = new Good("Хороший пример", price);
            Console.WriteLine("Получаемая цена:");
            good.Price.Display();

            Console.WriteLine("Введите процент");
            int Proc = Convert.ToInt32(Console.ReadLine());
            good.DecreasePriceByPercentage(Proc);
            
            Console.WriteLine($"Цена после скидки в: {Proc}%");
            good.Price.Display();
            Console.ReadLine();

        }
    }
}
