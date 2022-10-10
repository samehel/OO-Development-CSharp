using System;
using System.Linq;

namespace CourseraGraderNetCore3
{
            //Use this Main method to test your code.
            /*to run this project, follow these steps:
             1. Got to the View -> Terminal
             2. In the terminal window, type "dotnet run"
             3. You will see the output of your program
             */

    public class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Learner program");

            // Testing Merge
            int[] A = {1, 2 ,3};
            int[] B = {4, 5};
            int[] R = DataCollectionSolution.Merge(A, B);

            foreach(int e in R){
               System.Console.Write($"{e} ");
            }

            // Testing 2D Array diagonal Summation 
            int[,] C = { { 1, 2 }, { 3, 8 } };
            int[,] D = { { 1, 2, 3, 4 }, { 4, 5, 6, 4 }, { 7, 8, 9, 4 } };
            int result = DataCollectionSolution.SumDiagonal(C);
            System.Console.WriteLine();
            Console.WriteLine(result);
            int result2 = DataCollectionSolution.SumDiagonal(D);
            Console.WriteLine(result2);

            // Testing Stack to Queue conversion method
            Stack<int> s = null;
            Console.WriteLine(DataCollectionSolution.StackToQueue(s) == null ? "null" : "not null");
            Stack<int> s2 = new Stack<int>();
            Queue<int> q = DataCollectionSolution.StackToQueue(s2);
            foreach (int e in q)
            {
               Console.WriteLine(e); // nothing should be printed
            }
            s2.Push(1);
            s2.Push(2);
            s2.Push(3);
            Console.WriteLine(s2.Peek());
            foreach (int e in s2)
            {
               Console.Write(e); // 3 2 1 should be printed
            }
            Console.WriteLine();
            Queue<int> q2 = DataCollectionSolution.StackToQueue(s2);
            foreach (int e in q2)
            {
               Console.Write(e); // 3 2 1 should be printed
            }
            System.Console.WriteLine();
            Console.WriteLine(q2.Peek());

            // Testing Dictionary Count
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "Hi");
            d.Add(2, "Hello");
            int numOfElements = DataCollectionSolution.DictionaryCount(d);
            Console.WriteLine(numOfElements);

            // Testing max num in jagged array
            int[][] JArr = new int[2][] { 
               new int[] { 5 }, 
               new int[] { 3, 2 } 
            };
            Console.WriteLine(DataCollectionSolution.MaxJArr(JArr));

            // Testing check sorted dictionary method
            SortedDictionary<int, string> MySdict = new SortedDictionary<int, string>();
            MySdict.Add(1, "Hi");
            MySdict.Add(2, "Hello");
            MySdict.Add(3, "Hi");
            Console.WriteLine(DataCollectionSolution.CheckSortedDic(MySdict, "Hi"));

            // Testing list to string conversion method
            List<string> list = new List<string>();
            list.Add("A");
            list.Add("B");
            list.Add("C");
            list.Add("D");
            Console.WriteLine(DataCollectionSolution.ListToString(list));

            System.Console.WriteLine( );
            //test your program here
        }
    }
}
