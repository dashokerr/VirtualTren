using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualTren
{
    public abstract class Transport
    {
        abstract public void Move(); 
    }

    public class Car : Transport
    {
        public override void Move()
        {
            Console.WriteLine("rrrr eeeeee");
        }
    }

    public class Bicucle : Transport
    {
        public override void Move()
        {
            Console.WriteLine("use wheels");
        }
    }

    public class Airplan : Transport
    {
        public override void Move()
        {
            Console.WriteLine("fly in the sky");
        }
    }
}
