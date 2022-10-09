using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CourseraGraderNetCore3
{
    /*
     Dear Learner,

     Welcome to your first Coursera programming lab!

     In this programming lab, you will learn how to implement a class with specific requirements.
     Kindly pay attention to all requirements and implement them all to get full grade.
     */

    /*In this programming assignment, you are asked to implement a public C# class named Product with the following requirements:

    1. The class has 2 private instance variables: _Name of the type (string), and _Price of the type (double)

    2. The class has 2 public properties named Name and Price. 
        The Name property sets the value of the _Name instance variable and 
        the get method of the Name property returns the name of the product in square brackets, i.e., [_Name].
        The Price property sets the value of the _Price instance variable in USD and
        the get method of the Price property returns the price in Jordan dinnar (JOD)
        using this exchage rate (1 USD = 0.71 JOD).

    3. The class has a custom constructor with 2 parameters, the first parameter is for the product name
         and the second parameter is for the product price in US dollars.               

    4. The class has a parameter-less constructor which invokes the custom-constructor 
        using the chaining constructor technique with 0 price and "Empty" name as default values.

    5. The class must override the ToString method that returns a string exactly in this format:
        "[_Name] costs _Price JOD". For example, for a Product object with "Phone" as a name and 100 USD as a price, 
        the ToString method returns this string => [Phone] costs 71 JOD 

    6. The class must override the Equals method in which two Product objects are equal
        only if they have the same _Name and _Price values.
    
    7. The class has a public method named SalePrice that retuns the sale price of the product in US dollars as double using this formula:
        - if the _Price >= 200, it has 25% discount, i.e., if the _Price is 200 the sale price is 200*0.75=150
        - if the _Price >=100 and less than 200, it has 15% discount, i.e., if the _Price is 100 the sale price is 100*0.85=85
        - otherwise, the sale price is 10%, i.e., if the _Price is 50 the sale price is 50*0.9=45
    
    8. The class has a public method named PrintPriceNTimes which prints the US dollrs price N times in one line with a comma seperated.
        For example, if the _Price is 100, PrintPriceNTime(3) would return this string "100,100,100". Note that there is no comma at the end.
    */
    public class Product
    {

        // 1. Define the private instance variables here
        private string _Name;
        private double _Price;

        // 2. Define the public properties here
        public string Name
        {
            set { _Name = value; }
            get { return $"[{_Name}]"; }
        }

        public double Price
        {
            get 
            { 
                return Math.Round(_Price * 0.71, 2); 
            }
            set
            {
                if (value < 0)
                    Console.WriteLine("Price should be greater than 0");
                else
                    _Price = Math.Round(value / 0.71, 2);
            }
        }

        //3. Define the custom constructor here
        public Product(string _Name, double _Price)
        {
            this._Name = _Name;
            this._Price = _Price;
        }

        //4. Define the parameter-less constructor here
        public Product() : this("Empty", 0.0) { }

        //5. Override the ToString here
        public override string ToString()
        {
            return $"[{_Name}] costs {_Price * 0.71} JOD";
        }

        //6. Override the Equals method
        public override bool Equals(Object obj)
        {
            Product P = obj as Product;
            if (P == null)
            {
                return false;
            }
            //compare between this and P objects
            if (this._Name == P._Name && this._Price == P._Price)
                return true;
            else
                return false;
        }

        //7. Define the SalePrice method here
        public double SalePrice()
        {
            double Value = 0;

            if (_Price >= 200)
                Value = Math.Round(_Price * 0.75, 2);
            else if (_Price >= 100 && _Price < 200)
                Value = Math.Round(_Price * 0.85, 2);
            else
                Value = Math.Round(_Price * 0.9, 2);

            return Value;
        }

        //8. Define the  PrintPriceNTimes here
        public string PrintPriceNTimes(int N)
        {
            string Result = "";

            for (int i = 0; i < N; i++)
            {
                if (i != N - 1)
                    Result += $"{_Price},";
                else
                    Result += $"{_Price}";
            }

            return Result;
        }
    }
}