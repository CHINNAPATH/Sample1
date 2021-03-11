using System;

namespace work3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mode :");
            string mode;
            double x, y;
            mode = Console.ReadLine();
            Console.Write("X :");
            x = double.Parse(Console.ReadLine());
            Console.Write("Y :");
            y = double.Parse(Console.ReadLine());
            if (x >= 0)
            {
                switch (mode)
                {
                    case "time":
                        y = Math.Pow(x - 1, 2);
                        Console.WriteLine("Time :{0}", x);
                        Console.WriteLine("Price :{0}", y);
                        break;
                    case "price":
                        x = Math.Sqrt(y) + 1;
                        Console.WriteLine("Time :{0}", x);
                        Console.WriteLine("Price :{0}", y);
                        break;
                    default:
                        Console.WriteLine("Invalid mode");
                        break;
                }
            }
            else if (x < 0)
            {
                Console.WriteLine("Invalid mouse position");
            }

        }
    }
}