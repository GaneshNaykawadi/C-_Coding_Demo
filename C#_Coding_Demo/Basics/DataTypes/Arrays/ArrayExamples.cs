namespace C__Coding_Demo.Basics.DataTypes.Arrays;

public class ArrayExamples
{
    //? Details: used to print the array.
    private void printArray(string[] pallets)
    {
        //? printing array elements
        Console.Write("--");
        foreach (string item in pallets)
            Console.Write($" {item} --");

        Console.WriteLine();
    }

    //? Details: used to sort the array.
    protected void ArraySortExample(string[] pallets)
    {
        Console.WriteLine($"Array After sorting: ");

        //? for sorting arrays sort() method i used.
        Array.Sort(pallets);

        printArray(pallets);
    }

    //? Details: used to reverse the array content
    protected void ArrayReverseExample(string[] pallets)
    {
        Console.WriteLine($"Array After Reverse method: ");

        //? for sorting arrays sort() method is used.
        Array.Reverse(pallets);

        printArray(pallets);
    }

    //? Details: The clear() method of Array class used to clear content of array at specific position.
    protected void ArrayClearExmple(string[] pallets, int index, int length)
    {
        Array.Clear(pallets, index, length);

        Console.WriteLine($"After Clearing Array from index: {index} to {(index + length)}, but length is: {pallets.Length}");
        printArray(pallets);
    }

    //? Details: The resize() method of Array class is used resize the length of an array.
    protected void ArrayResizeExample(string[] pallets, int size)
    {
        Console.WriteLine($"Before Resize method size is: {pallets.Length}");
        printArray(pallets);

        Array.Resize(ref pallets, size);

        Console.WriteLine($"After Resize method size is: {pallets.Length} ");
        printArray(pallets);

        //! We can remove elements of an array using resize method also.
        Array.Resize(ref pallets, 2);
        Console.WriteLine($"After shrinking array using Resize() method size is: {pallets.Length} ");
        printArray(pallets);
    }

    //? Details: function to reverse string character
    protected void ReverseString(string str)
    {
        Console.WriteLine($"The String Before reverse: {str}");
        char[] stringArray = str.ToCharArray();
        Array.Reverse(stringArray);
        string result = new string(stringArray);
        Console.WriteLine($"The String After reverse: {result}");
    }

    //? Details: The Join() method of String class is used.
    protected void ArrayJoinExample(string str)
    {
        char[] value = str.ToCharArray();
        Array.Reverse(value);
        string result = String.Join(",", value);
        Console.WriteLine($"The Join() Example output: {result}");
    }

    //? Details: The Join() method of String class is used.
    protected void ArraySplitExample(string str)
    {
        char[] value = str.ToCharArray();
        Array.Reverse(value);

        Console.WriteLine("The Split() Example output: ");

        // convert into string
        string? result = String.Join(",", value);
        string[] items = result.Split(',');
        foreach (string item in items)
            Console.Write(item + " ");
    }

    //? challenge 1: We have to reverse words in a sentence given by user.
    protected void ReverseSentenceChar(string sentence)
    {
        // Step 1
        string[] message = sentence.Split(' ');

        //Step 2
        string[] newMessage = new string[message.Length];

        // Step 3
        for (int i = 0; i < message.Length; i++)
        {
            char[] letters = message[i].ToCharArray();
            Array.Reverse(letters);
            newMessage[i] = new string(letters);
        }

        //Step 4
        string result = String.Join(" ", newMessage);
        Console.WriteLine("The Reverse Sentence Character Output: ");
        Console.WriteLine(result);
    }

    //? Challenge 2: challenge to parse a string of orders, sort the orders and tag possible errors.
    protected void CheckOrderIDs(string ordersIDs)
    {
        string[] items = ordersIDs.Split(',');

        Array.Sort(items);
        Console.WriteLine("The Order ID Details given below: ");

        foreach (var item in items)
        {
            if (item.Length == 4)
                Console.WriteLine(item);
            else
                Console.WriteLine(item + "\t- Error");
        }
    }

}
