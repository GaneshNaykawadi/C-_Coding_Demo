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
    protected void findIndex(string[] substrings, string message)
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


    // Challenge 1: Show the bank users Transaction Details in proper formating
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

}