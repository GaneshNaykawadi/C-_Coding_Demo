namespace C__Coding_Demo.Basics.DataTypes.Arrays;

public class ArrayExamples
{
    //? Details: used to print the array.
    private void printArray(string[] pallets)
    {
        //? printing array elements
        foreach (string item in pallets)
            Console.Write($" -- {item}");

        Console.WriteLine();
    }

    //? Details: used to sort the array.
    internal void ArraySortExample(string[] pallets)
    {
        Console.WriteLine($"Array After sorting: ");

        //? for sorting arrays sort() method i used.
        Array.Sort(pallets);

        printArray(pallets);
    }

    //? Details: used to reverse the array content
    internal void ArrayReverseExample(string[] pallets)
    {
        Console.WriteLine($"Array After Reverse method: ");

        //? for sorting arrays sort() method i used.
        Array.Reverse(pallets);

        printArray(pallets);
    }
}
