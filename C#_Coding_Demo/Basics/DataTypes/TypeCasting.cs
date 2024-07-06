namespace C__Coding_Demo.Basics.DataTypes;

public static class TypeCasting
{
    public static string getResult(int first, string second)
    {
        return first + second;
    }

    public static int getResult(int first, int second)
    {
        return first + second;
    }

    public static void ExplicitCasting()
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

    public static void useToStringMethod()
    {
        int first = 5;
        int second = 7;
        string message = first.ToString() + second.ToString();
        Console.WriteLine(message);
    }

    public static void useParseMethod()
    {
        string first = "5";
        string second = "7";
        int sum = int.Parse(first) + int.Parse(second);
        Console.WriteLine(sum);
    }
}