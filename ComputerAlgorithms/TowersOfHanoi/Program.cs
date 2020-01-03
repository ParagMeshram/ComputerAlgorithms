namespace TowersOfHanoi
{
    using System;

    internal class Program
    {
        private static void Main()
        {
            MoveDisk(5, "X", "Y", "Z");
            Console.ReadKey();
        }


        public static void MoveDisk(int n, string x, string y, string z)
        {
            if(n == 0) return;

            MoveDisk(n - 1, x, z, y);
            Console.WriteLine($"move top disk from tower {x} to top of tower {y}");
            MoveDisk(n - 1, z, y, x);
        }
    }
}
