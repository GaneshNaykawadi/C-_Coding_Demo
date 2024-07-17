using System;
namespace C__Coding_Demo.Basics.DataTypes;

public class TypeCasting
{
    public string getResult(int first, string second)
    {
        return first + second;
    }

    public int getResult(int first, int second)
    {
        return first + second;
    }

    protected void ExplicitCasting()
    {
        decimal myDecimal = 3.14m;
        Console.WriteLine($"decimal: {myDecimal}");

        /// The term widening conversion means that you're attempting to convert a value from a data type that could hold less information to a data type that can hold more information. In this case, a value stored in a variable of type int converted to a variable of type decimal, doesn't lose information. When you know you're performing a widening conversion, you can rely on implicit conversion. The compiler handles implicit conversions.
        /// 

        int myInt = (int)myDecimal;
        Console.WriteLine($"int: {myInt}");

        // -----------------------------------------------------------------------------------------------

        decimal myDecimal1 = 3.14m;
        Console.WriteLine($"decimal: {myDecimal1}");

        /// explicit conversion => Loss of Data. () is a Cast-Operator.
        int myInt1 = (int)myDecimal;
        Console.WriteLine($"int: {myInt1}");
    }

    //? Info: Example to demonstrate use of ToString() method.
    protected void useToStringMethod()
    {
        int first = 5;
        int second = 7;
        string message = first.ToString() + second.ToString();
        Console.WriteLine(message);
    }

    //? Info: Example to demonstrate use of Parse() method.
    protected void useParseMethod()
    {
        string first = "5";
        string second = "7";
        int sum = int.Parse(first) + int.Parse(second);
        Console.WriteLine(sum);
    }

    //? Info: Example to demonstrate use of TryParse() method.
    protected void useTryParseMethod()
    {
        string value = "Sammer";
        int result = 0;

        if (int.TryParse(value, out result))
            Console.WriteLine($"Measurement: {result}");
        else
            Console.WriteLine(value: "Input Error: Unable to Calculate the measurement.");
    }

    //? Info: Example of TryParse() with array.
    protected void exampleTryParse()
    {
        string[] values = { "12.3", "45", "ABC", "11", "DEF" };
        string message = "";
        decimal result = 0m;

        foreach (string value in values)
        {
            decimal number;
            if (decimal.TryParse(value, out number))
                result += number;
            else
                message += value;
        }

        Console.WriteLine($"Message: {message}");
        Console.WriteLine($"Total: {result}");
    }

    //? Info: challenge 2: 
    /*  solve the challenge with following criteria:

        1. Solve for result1: Divide value1 by value2, display the result as an int.
        2. Solve for result2: Divide value2 by value3, display the result as a decimal.
        3. Solve for result3: Divide value3 by value1, display the result as a float.
    */

    protected void ExerciseCast()
    {
        int value1 = 11;
        decimal value2 = 6.2m;
        float value3 = 4.3f;

        // The Convert class is best for converting the fractional decimal numbers into whole integer numbers
        // Convert.ToInt32() rounds up the way you would expect.
        int result1 = Convert.ToInt32(value1 / value2);
        Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

        decimal result2 = value2 / (decimal)value3;
        Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

        float result3 = value3 / value1;
        Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
    }
}