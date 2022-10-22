using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CourseraGraderNetCore3
{
    public class LearnerProgram{
    /*
    TODO:
        (1D array)
        Write a C# method named Merge that takes two one-dimentional arrays (A and B) and merges them into a one-dimentional array and returns it.
        if A is null, return array with all elements from B.
        if B is null, return array with all elements from A.
    Input: 2 1D arrays
    Output:1D Array
    Example:A = [1, 2], B = [3]. Merge(A, B) would return a 1D array [1, 2, 3]
    */
    public static int[] Merge(int[] A, int[] B){    
        int totalArrayLength = A.Length + B.Length;
        int[] mergedArray = new int[totalArrayLength];
        
        for(int i = 0; i < A.Length; i++)
        {
            mergedArray[i] = A[i];
        }
        int startPos = A.Length;
        for(int i = 0; i < B.Length; i++)
        {
            mergedArray[startPos] = B[i];
            startPos++;
        }
        return mergedArray;

    }

    /*
    TODO:
        (2D array)
        Write a C# method named SumDiagonal that takes a 2-dimentional array (A) of integers and returns the sum of its main-diagonal.
        If the given array, A, is not square, then the method should return -5555.
        If the given array, A, is null, then return -6666.
    Input: a one 2D array
    Output:int value - the sum of the integers in the main diagonal of array A
    Example: A = {{1,2}, {3,8}}. SumDiagonal(A) would return an int value of 1 + 8 = 9.
    */
    public static int SumDiagonal(int[,] A){
            if (A.GetLength(0) != A.GetLength(1))
                return -5555;

            int sum = 0;
            for(int R = 0; R < A.GetLength(0); R++)
            {
                for(int C = 0; C < A.GetLength(1); C++)
                {
                    if (R == C)
                    {
                        sum += A[R, C];
                        break;
                    }
                }
            }
                
            return sum;
    }

    /*
    TODO:
        (Stack and Queue)
        Write a C# method named StackToQueue that takes a Stack of integers and returns a Queue of integers.
        The top of the stack should be the front element of the queue. 
        If S is null, return null. If S is empty return an empty Queue.    
    Input: Stack<int> S
    Output:Queue<int> that has the elements of the stack in the same order from the top to the bottom of the stack.
    Example: S = [1, 2, 3] where 3 in the top. StackToQueue(S) should return a Queue [1, 2, 3] where 3 in the front of the queue.
    */
        public static Queue<int> StackToQueue(Stack<int> S)
        { 
            if (S == null)
                return null;
            else if (S.Count == 0)
                return new Queue<int>();

            Queue<int> q = new Queue<int>();
            while (S.Count > 0)
                q.Enqueue(S.Pop());

            return q;
        }

    /*
    TODO:
        (Dictionary)
        Write a C# method named DictionaryCount that takes a dictionary and returns the number of elements in that dictionary.
        If the dictionary is empty, return 0.
        If the dictionary is null, return -1.
    Input: Dictionary<int, string> myDictionary
    Output:number of elements in the dictionary
    Example: myDictionary = { <1, "Hi">, <2, "Hello">} DictionaryCount(myDictionary) should return 2.
    */
        public static int DictionaryCount(Dictionary<int, string> myDictionary)
        {
        
            if (myDictionary == null)
                return -1;
            else if (myDictionary.Count == 0)
                return 0;
        
            return myDictionary.Count;
        }

    /*
    TODO:
        (Jagged array)
        Write a C# method named MaxJArr that takes a jagged array of integers and returns the maximum number in the jagged array.
        If the jagged array is empty, return 0.
        If the jagged array is null, return -5555.
    Input: jagged array JArr
    Output:maximum integer number in the given jagged array
    Example: JArr = { [5], [3, 2]} MaxJArr(JArr) should return 5.
    */
        public static int MaxJArr(int [][] JArr)
        {
            if (JArr.Length == 0)
                return 0;
            else if (JArr == null)
                return -5555;

            int max = -999;
                
            for(int i = 0; i < JArr.Length; i++)
            {
                for(int j = 0; j < JArr[i].Length; j++)
                {
                    if(JArr[i][j] > max)
                        max = JArr[i][j];
                }
            }

            return max;
        } 

    /*
    TODO:
        (SortedDictionary)
        Write a C# method named CheckSortedDic that takes a sorted dictionary MySdict and a string value Val. The method return an integer number.
        The method returns the number of times Val appeared in the values of the sorted dictionary MySdict.
        If the sorted dictionary is empty or null, return 0.
    Input: sorted dictionary<int, string> MySdict and string Val
    Output:return the number of times Val appeared in the values of the MySdict.
    Example: MySdict = { <1, "Hi">, <2, "Hello">, <3, "Hi">} CheckSortedDic(MySdict, "Hi") should return 2.
    */
        public static int CheckSortedDic(SortedDictionary<int, string> MySdict, string Val)
        {
            if (MySdict.Count == 0 || MySdict == null)
                return 0;

            int valNum = 0;
            foreach(KeyValuePair<int, string> KVP in MySdict)
            {
                if (KVP.Value == Val)
                    valNum++;
            }

            return valNum;
        }
       
    /*
    TODO:
        (List)
        Write a C# method named ListToString that takes a List of strings (list) and returns a string containing the elements  of the list in one line seperated by spaces.
        if the list is empty or null, return an empty string (not a null).
    Input: List<string> list
    Output: String containing the content of the given list seperated by spaces
    Example:
    List<string> list = ["A", "B", "C","D" ]; 
    ListToString(list) would return "A B C D".
    */
        public static string ListToString(List<string> list)
        {
            if (list == null || list.Count == 0)
                return "";

            string str = "";
            foreach(string s in list)
            {
                if (s != list[list.Count - 1])
                    str += s + " ";
                else
                    str += s;
            }
            return str;
        }
  }
}