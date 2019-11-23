using System;

namespace Fib_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
           
                int z = 0;
                int y = 0;
                int x = 0;
                int i = 0;

                x = 1;
                y = 1;

                while (i < 255)
                {
                    i++;
                    int fib_z = x + y;
                    x = y + fib_z;
                    y = fib_z + x;
                   
                    Console.WriteLine("{0}, {1}, {2}", fib_z, x, y);
                }

           
        }

    }
}

