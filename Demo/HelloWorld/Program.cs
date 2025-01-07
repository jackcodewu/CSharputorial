using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            if (args?.Any() == true)
            {
                foreach (var item in args)
                {
                    Console.WriteLine($"传入的参数是：{item}");
                }
            }

            Console.ReadLine();

        }
    }
}
