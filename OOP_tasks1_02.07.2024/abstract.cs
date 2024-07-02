using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_tasks1_02._07._2024
{
  
    abstract class Animal
    {
        public string Name { get; set; }
        public Animal(string name) 
        {
            this.Name = name;
        }
        public abstract void Eat();
        public void Sleep()
        {
            Console.WriteLine("is sleeping");
        }

    }

    class Dog : Animal, ISound
    {
        public string Name_Eat { get; set; }

        public Dog(string name, string name_eat) : base(name)
        {
            this.Name_Eat = name_eat;
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name_Eat}");

        }
        public void MakeSound()
        {
            Console.WriteLine($"{Name} Woof");
        }
    }
    class Cat : Animal
    {
        public string Name_Eat { get; set; }

        public Cat(string name, string name_eat) : base(name)
        {
            this.Name_Eat = name_eat;
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name_Eat}");
        }
        public void MakeSound()
        {
            Console.WriteLine($"{Name} Meow");
        }
    }
}
