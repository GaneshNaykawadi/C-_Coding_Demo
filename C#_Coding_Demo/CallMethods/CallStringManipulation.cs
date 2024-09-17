using C__Coding_Demo.Basics.DataTypes.Strings;

namespace C__Coding_Demo.CallMethods;

public class CallStringManipulation : StringManipulation
{
    private readonly string string1;
    private readonly string string2;

    private readonly int Discount;
    private readonly decimal Price;
    private readonly decimal SalePrice;
    private readonly Transaction[] UserTransaction;

    private readonly decimal[] Values;

    private readonly String Message;
    private readonly string[] Substrings;

    private readonly int OpeningPosition;
    private readonly int Length;
    private readonly string findPattern;
    private readonly string replacePattern;
    private readonly string InputString;

    //! Parameterized Constructor
    public CallStringManipulation(string inputString)
    {
        this.InputString = inputString;
    }

    //! Parameterized Constructor overloading-1
    public CallStringManipulation(string str1, string str2)
    {
        this.string1 = str1;
        this.string2 = str2;
    }

    //! Parameterized Constructor overloading-2
    public CallStringManipulation(decimal price, int discount)
    {
        this.Price = price;
        this.Discount = discount;
    }

    //! Parameterized Constructor overloading-3
    public CallStringManipulation(decimal[] values)
    {
        this.Values = values;
    }

    //! Parameterized Constructor overloading-4
    public CallStringManipulation(decimal price, decimal salePrice)
    {
        this.Price = price;
        this.SalePrice = salePrice;
    }

    //! Parameterized Constructor overloading-5
    public CallStringManipulation(Transaction[] userTransaction)
    {
        this.UserTransaction = userTransaction;
    }

    //! Parameterized Constructor overloading-6
    public CallStringManipulation(string[] substrings, String message)
    {
        this.Message = message;
        this.Substrings = substrings;
    }

    //! Parameterized Constructor overloading-7
    public CallStringManipulation(String message, int openingPosition, int length)
    {
        this.Message = message;
        this.OpeningPosition = openingPosition;
        this.Length = length;
    }

    //! Parameterized Constructor overloading-8
    public CallStringManipulation(String message, string pattern, string replace)
    {
        this.Message = message;
        this.findPattern = pattern;
        this.replacePattern = replace;
    }

    internal void CallStringMethods()
    {
        Console.WriteLine("\n____________________ String Manipulation Demo's: ____________________\n\n");

        //CompositeFormatting(string1, string2);
        //StringInterpolation(string1, string2);
        //FormatCurrency(Price, Discount);
        //FormatNumbers(Values);
        //CalculateDiscount(Price, SalePrice);
        //UserTransactionDetails(UserTransaction);
        //findIndex(Substrings, Message);
        //PrintSubstring(Message, OpeningPosition, Length);
        //findIndexOfAny();
        //findAllOccurences();
        //RemoveStringPart(Message, OpeningPosition, Length);
        //ReplaceStringData(Message, findPattern, replacePattern);
        //ModifyStringData(InputString);
        checkImmutableOrNot();
    }
}
