using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualTren
{
    internal class ClassAnimals
    {
        public  virtual void MakeSound()
        {
            Console.WriteLine("Sound");
        }

    }


    internal class cat : ClassAnimals
    {
        public override void MakeSound()
        {
            Console.WriteLine("mew mew");
        }

    }

    internal class dog : ClassAnimals
    {
        public override void MakeSound()
        {
            Console.WriteLine("raf raf");
        }

    }
}


