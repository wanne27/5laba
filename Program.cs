using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Bench bench1 = new Bench { name = "bench1", length = 23, mass = 15, width = 3 };

            Console.WriteLine(bench1.Cost(2));
            Console.WriteLine(Bench.Equals(bench1, bench1));

            Tennis tennis1 = new Tennis { number = 3, name = "tennis1", mass = 10, radius = 5 };

            Console.WriteLine(tennis1.Lifetime(5));             // методы абстрактного класса

            Tennis a = new Tennis { number = 1,name = "a" };
            Bench b = new Bench { length = 2, name = "b" }; 
            Console.WriteLine((a is Tennis) + " проверка использования is");
           // Bench x = b as Tennis;

            tennis1.ToString();

            set_of_classes ball1 = new set_of_classes();

            cube cub = new cube();
            cub.Print();
            Class2 cl1 = new Class2();                              // объект для одноименный метод в интерфейсе и в абстрактном классе



            Console.WriteLine(((Class1)cl1).SUM(2, 3));         // одноименный метод в интерфейсе и в абстрактном классе

            Printer pr = new Printer();

            Description[] arr = new Description[3] { bench1, tennis1, ball1 };
            pr.IAmPrinting(arr[0]);
            pr.IAmPrinting(arr[1]);
            pr.IAmPrinting(arr[2]);

            Console.ReadKey();

        }
    }
}
