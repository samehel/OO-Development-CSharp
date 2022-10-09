using System;
using CourseraGraderNetCore3;

namespace learn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Product P1 = new Product();
            System.Console.WriteLine(P1);

            Product P2 = new Product("Phone", 100.0);
            System.Console.WriteLine(P2);

            Product P3 = new Product("HomePhone", 100.0);
            Console.WriteLine(P3.Price);


            Console.WriteLine(P3.ToString());
            Console.WriteLine(P3.SalePrice());
            Console.WriteLine(P3.PrintPriceNTimes(3));
            Console.WriteLine();


        }
    }
}
