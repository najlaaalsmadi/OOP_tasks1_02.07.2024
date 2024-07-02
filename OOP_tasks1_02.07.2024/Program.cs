using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_tasks1_02._07._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("string Make=");
            string make = Console.ReadLine();
            Console.Write("int year=");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("string type=");
            string type = Console.ReadLine();
            Console.Write("double price=");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.Write("string model=");
            string model = Console.ReadLine();
            Console.Write("int pallet_no=");
            int pallet_no = Convert.ToInt32(Console.ReadLine());
            Console.Write("string color=");
            string color = Console.ReadLine();
            Console.Write("bool engineState=");
            bool engineState = Convert.ToBoolean(Console.ReadLine());
            Console.Write("string series=");
            string series = Console.ReadLine();

            BMW bmw = new BMW(make, year, type, price, model, pallet_no, color, engineState, series);
            bmw.Display();
            bmw.Display();
            bmw.DisplayInfo("bmw1");
            bmw.DisplayInfo("bmw1", 1998);
            Cars cars = new BMW(make, year, type, price, model, pallet_no, color, engineState, series);
            cars.Display();
            cars.Display();
            cars.Display();
            Fly fly = new Fly();
            fly.MakeSound();
            Console.Write("string Name dog=");
            string Name_dog = Console.ReadLine();
            Console.Write("string Name_Eat dog=");
            string Name_Eat_dog = Console.ReadLine();        
            Dog dog1 = new Dog(Name_dog, Name_Eat_dog);
            dog1.Eat();
            dog1.Sleep();
            dog1.MakeSound();
            Console.Write("string Name cat =");
            string Name_cat = Console.ReadLine();
            Console.Write("string Name_Eat cat=");
            string Name_Eat_cat = Console.ReadLine();
            Cat cat=new Cat(Name_cat, Name_Eat_cat);
            cat.Eat();  
            cat.Sleep();
            cat.MakeSound();

        }
    }
}
