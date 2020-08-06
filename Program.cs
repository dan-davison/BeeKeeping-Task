using System;
using System.Collections.Generic;

namespace BeeKeeping_DanDavison
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Create Behive
            Beehive BeeHive1 = new Beehive(4);
            Beehive BeeHive2 = new Beehive(3);

            //Create Bees
            Bee b1 = new Bee("John", 3.2f);
            Bee b2 = new Bee("Paul", 2.7f); 
            Bee b3 = new Bee("George", 1.1f);
            Bee b4 = new Bee("Ringo", 2.0f);
            Bee b5 = new Bee("Kurt", 2.3f);
            Bee b6 = new Bee("Dave", 7.4f);
            Bee b7 = new Bee("Krist", 1.5f);

            //Add Bees to their Beehive
            BeeHive1.AddBee(b1);
            BeeHive1.AddBee(b2);
            BeeHive1.AddBee(b3);
            BeeHive1.AddBee(b4);
            BeeHive2.AddBee(b5);
            BeeHive2.AddBee(b6);
            BeeHive2.AddBee(b7);

            //Report on the BeeHives
            Console.WriteLine("");
            Console.WriteLine("_____________________");
            Console.WriteLine("");

            Console.WriteLine("BeeHive1 contains " + b1.BeeName + ", " + b2.BeeName + ", " + b3.BeeName + " & " + b4.BeeName + ".");
            BeeHive1.CollectHoney(10);

            Console.WriteLine("");
            Console.WriteLine("_____________________");
            Console.WriteLine("");

            Console.WriteLine("BeeHive2 contains " + b5.BeeName + ", " + b6.BeeName + " & " + b7.BeeName + ".");
            BeeHive2.CollectHoney(10);

            Console.WriteLine("");
            Console.WriteLine("_____________________");
            Console.WriteLine("");

            
        }
    }
}