using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_tasks1_02._07._2024
{
    interface ISound
    {
        void MakeSound();
    }
    class Fly : ISound
    {
        public void MakeSound()
        {
            Console.WriteLine("MakeSound");
        }
    }
    internal class task2
    {
    }
}
