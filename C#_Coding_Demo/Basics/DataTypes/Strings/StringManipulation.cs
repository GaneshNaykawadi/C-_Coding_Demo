using Microsoft.VisualBasic;

namespace C__Coding_Demo.Basics.DataTypes.Strings;

public class StringManipulation
{
    //? Composite formatting
    protected void CompositeFormatting(string first, string second)
    {
        string result = string.Format("Example 1: {0} {1}.", first, second);
        //string result = string.Format("Example 2: {0} {0}.", first, second);
        //string result = string.Format("Example 3: {1} {0}.", first, second);
        //string result = string.Format("Example 4: {1} {1} {1} {1}.", first, second);
        Console.WriteLine(result);
    }

    //? string interpolation
    protected void StringInterpolation(string string1, string string2)
    {
        Console.WriteLine($"{string1} {string2}");
    }

    //? Formatting currency
    protected void FormatCurrency(decimal price, int discount)
    {
        Console.WriteLine($"The shopkeeper give Price: {price:C} at discount: {discount:C}");
    }

    //? Format Numbers
    protected void FormatNumbers(decimal[] values)
    {
        Console.WriteLine($"Measurement: {values[0]:N} units");
        Console.WriteLine($"Measurement: {values[0]:N4} units");
        Console.WriteLine($"Tax rate: {values[1]:P2}");
    }

    protected void CalculateDiscount(decimal actualPrice, decimal salePrice)
    {
        string discount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (actualPrice - salePrice), actualPrice);

        discount += $"A discount of {((actualPrice - salePrice) / actualPrice):P2}!"; //inserted
        Console.WriteLine(discount);
    }
}
