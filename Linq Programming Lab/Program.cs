using System;

            //Use this Main method to test your code.
            /*to run this project, follow these steps:
             1. Got to the View -> Terminal
             2. In the terminal window, type "dotnet run"
             3. You will see the output of your program
             */

namespace CourseraGraderNetCore3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing NumSqure function
            int[] A = new int[] { 3, 4, 10, 5 };
            IEnumerable<object> q = LearnerProgram.NumSquare(A);

            foreach(var e in q)
                Console.WriteLine(e);

            // Testing EvenNumber function
            int[] B = new int[] { 1, 2, 3, 4, 5, 6 };
            IEnumerable<int> q2 = LearnerProgram.EvenNumber(B);

            foreach (var e in q2)
                Console.Write($"{e} ");
            Console.WriteLine();

            // Testing FindCity function
            string[] cities = new string[] { "New York", "Amman", "Paris" };
            IEnumerable<string> q3 = LearnerProgram.FindCity(cities);

            foreach (var e in q3)
                Console.Write($"{e} ");
            Console.WriteLine();

            // Testing OrderString function
            string[] names = new string[] { "Sami", "Samah", "Lamar", "Leen", "Mahmoud", "Layan", "Yousef" };
            IEnumerable<string> q4 = LearnerProgram.OrderString(names);
            foreach (var e in q4)
                Console.Write($"{e} ");
            Console.WriteLine();
        }
    }
}
