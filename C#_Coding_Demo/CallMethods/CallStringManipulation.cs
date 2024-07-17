using C__Coding_Demo.Basics.DataTypes.Strings;

namespace C__Coding_Demo.CallMethods;

public class CallStringManipulation : StringManipulation
{
    private readonly string string1;
    private readonly string string2;

    private readonly int Discount;
    private readonly decimal Price;
    private readonly decimal SalePrice;

    private readonly decimal[] Values;

    //! Parameterized Constructor
    public CallStringManipulation(string str1, string str2)
    {
        this.string1 = str1;
        this.string2 = str2;
    }

    //! Parameterized Constructor overloading-1
    public CallStringManipulation(decimal price, int discount)
    {
        this.Price = price;
        this.Discount = discount;
    }

    //! Parameterized Constructor overloading-2
    public CallStringManipulation(decimal[] values)
    {
        this.Values = values;
    }

    //! Parameterized Constructor overloading-3
    public CallStringManipulation(decimal price, decimal salePrice)
    {
        this.Price = price;
        this.SalePrice = salePrice;
    }

    internal void CallStringMethods()
    {
        Console.WriteLine("\n____________________ String Manipulation Demo's: ____________________\n\n");

        //CompositeFormatting(string1, string2);
        //StringInterpolation(string1, string2);
        //FormatCurrency(Price, Discount);
        //FormatNumbers(Values);
        CalculateDiscount(Price, SalePrice);
    }
}
