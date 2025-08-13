using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualTren
{
    public abstract class Animal
    {

        public abstract void MakeSound();

        public virtual void Feed()
        {
            Console.WriteLine("Animal is eating");
        }
    }

    public class Lion : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Roar!!");
        }

        public override void Feed() => Console.WriteLine("Lion eats meat");
    }

    public class Elephant : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Trumpet!!");
        }
    }

    public class Parrot : Animal 
    {
        public override void MakeSound()
        {
            Console.WriteLine("Squack!");
        }

        public override void Feed() => Console.WriteLine("Parrots eat seeds");

    }

    public class Zoo
    {
        public static void MakeAllSounds(Animal[] animal)
        {
            foreach (Animal anim in animal)
            {
                anim.MakeSound();
            }
        }
gggggggggg
        public static void FeedAll(Animal[] animal)
        {
            foreach (Animal anim in animal)
            {
                anim.Feed();
            }
        }
    }

}
