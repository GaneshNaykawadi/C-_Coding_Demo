using System;

namespace C__Coding_Demo.Basics.DataTypes.Strings;

public class StringManipulation
{
    // Bank User Object
    public class Transaction
    {
        internal readonly string PaymentID;
        internal readonly string PayeeName;
        internal readonly string Amount;

        public Transaction(string id, string name, string amount)
        {
            PaymentID = id;
            PayeeName = name;
            Amount = amount;
        }
    }

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

        // String Formatting Demo
        StringFormatting();

    }

    private void StringFormatting()
    {
        string input = "Pad this";
        Console.WriteLine(input.PadRight(12));
        Console.WriteLine(input.PadLeft(12, '-'));

    }

    //? String Manipulation: use of IndexOf() method.
    protected internal void findIndex(string[] substrings, string message)
    {
        int[] positions = new int[(substrings.Length)];

        for (int i = 0; i < substrings.Length; i++)
            positions[i] = message.IndexOf(substrings[i]);

        for (int item = 0; item < substrings.Length; item++)
        {
            if (positions[item] == -1)
                Console.WriteLine($"The substring {substrings[item]} is not found in \'{message}\'");
            else
                Console.WriteLine($"The substring \'{substrings[item]}\' is found at location {positions[item]} from the main string \'{message}\'. ");
        }
    }

    //? String Manipulation: use of SubString(StartPosition, length)
    protected void PrintSubstring(String message, int OpeningPosition, int length)
    {
        Console.WriteLine($"The substring you requested is: {message.Substring(OpeningPosition, length)}");
    }

    //? String Manipulation: use the string LastIndexOf() method.
    protected void findIndexOfAny()
    {
        string message = "(What if) I am (only interested) in the last (set of parentheses)?";
        int openingPosition = message.LastIndexOf('(');

        openingPosition += 1;
        int closingPosition = message.LastIndexOf(')');
        int length = closingPosition - openingPosition;
        Console.WriteLine(message.Substring(openingPosition, length));
    }

    //? String Manipulation: use the string IndexOf() method.
    protected void findAllOccurences()
    {
        string message = "(What if) there are (more than) one (set of parentheses)?";
        while (true)
        {
            int openingPosition = message.IndexOf('(');
            if (openingPosition == -1) break;

            openingPosition += 1;
            int closingPosition = message.IndexOf(')');
            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));

            // Note the overload of the Substring to return only the remaining 
            // unprocessed message:
            message = message.Substring(closingPosition + 1);
        }
    }

    //? String Manipulation: use the string Remove() method.
    protected void RemoveStringPart(string Data, int startPoint, int count)
    {
        Console.WriteLine($"The String Data Before Manipluation is: {Data}");
        Console.WriteLine($"The String Data After Manipluation is: {Data.Remove(startPoint, count)}");
    }

    //? String Manipulation: use the string Replace() method.
    protected void ReplaceStringData(string message, string findPattern, string replaceData)
    {
        Console.WriteLine($"The Original Data is: {message}");
        Console.WriteLine($"The Replaced Data is: {message.Replace(findPattern, replaceData)}");
    }

    //* Challenge 1: Show the bank users Transaction Details in proper formating
    protected void UserTransactionDetails(Transaction[] userTransactions)
    {
        foreach (var entry in userTransactions)
        {
            var formattedLine = entry.PaymentID.PadRight(10);
            formattedLine += entry.PayeeName.PadRight(24);
            formattedLine += entry.Amount.PadLeft(10);

            Console.WriteLine(formattedLine);
        }
    }

    //* Challenge 2: Complete a challenge to extract, replace, and remove data from an input string.
    protected void ModifyStringData(string input)
    {
        string output = "";

        //Task 1: Extract the Quantity from string
        const string openSpan = "<span>";
        const string closeSpan = "</span>";

        //get the index of quantity
        int QuantityStartPosition = input.IndexOf(openSpan) + openSpan.Length;
        int QuantityEndPosition = input.IndexOf(closeSpan);
        int QuantityLength = QuantityEndPosition - QuantityStartPosition;
        string Quantity = $"Quantity: {input.Substring(QuantityStartPosition, QuantityLength)}";

        //Task 2: replacing the trademark symbol with the registered trademark symbol
        const string trademarkSymbol = "&trade";
        const string registeredTrademarkSymbol = "&reg";
        output = input.Replace(trademarkSymbol, registeredTrademarkSymbol);

        //Task 3: remove the opening <div> and closing </div> tags.
        const string OpeningDivTag = "<div>";
        const string closingDivTag = "</div>";

        //first we remove oepening Div Tag
        int openingDivPosition = output.IndexOf(OpeningDivTag);
        output = output.Remove(openingDivPosition, OpeningDivTag.Length);

        //second we remove closing Div tag
        int closingDivPosition = output.IndexOf(closingDivTag);
        output = output.Remove(closingDivPosition, closingDivTag.Length);

        // print the output
        Console.WriteLine(Quantity);
        Console.WriteLine(output);

        
    }

}