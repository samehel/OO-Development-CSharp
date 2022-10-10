# List of Assignments Solved

## Assignment 1 - Object Oriented Concepts Assignment

**Grade Achieved:** 91%
<br>
**Weight on Final Mark:** 7%

**Info:** Implementing an item inventory class capable of storing products and their prices and converting the input price in JOD (Jordanian Dinar) to USD (United States Dollar) and when retrieving the price vice vera, it is converted back to JOD. The project includes 2 files:

* Program.cs
* LearnerProgram.cs

**Program.cs:** Contains the main class used to test the class responsible for storing and retriving products. This file was not part of the final submission.
<br>
<br>
**LearnerProgram.cs:** Contains the main code responsible for handling the products and the exchange. The contents of the file include:

The Private instance variables responsible for holding the name and price of the product:
```csharp
private string _Name;
private double _Price;
```
The public properties responsible for getting and setting the name and price of the product:<br>
*As displayed, upon the price being set it is converted from JOD to USD. And upon retrieval, it is converted back to USD*
```csharp
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
```

The overloaded constructor responsible for creating an object instance along with the regular constructor which fills in the missing data of type string and double:

```csharp
public Product(string _Name, double _Price)
{
    this._Name = _Name;
    this._Price = _Price;
}

public Product() : this("Empty", 0.0) { }
```

The Overloaded ToString() method to display a different message whenever used and the overloaded Equals method to compare two different product objects based on their name and price:
```csharp
public override string ToString()
{
    return $"[{_Name}] costs {_Price * 0.71} JOD";
}

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
```

A Method responsible for providing discounts of the product price in different ranges:
```csharp
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
```

Finally, A Method responsible for printing the price an N amount of times:
```csharp
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
```




