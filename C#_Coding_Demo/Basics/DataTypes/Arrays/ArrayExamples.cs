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

        //? for sorting arrays sort() method is used.
        Array.Reverse(pallets);

        printArray(pallets);
    }

    //? Details: The clear() method of Array class used to clear content of array at specific position.
    internal void ArrayClearExmple(string[] pallets, int index, int length)
    {
        Array.Clear(pallets, index, length);

        Console.WriteLine($"After Clearing Array from index: {index} to {(index + length)}, but length is: {pallets.Length}");
        printArray(pallets);
    }

    //? Details: The resize() method of Array class is used resize the length of an array.
    internal void ArrayResizeExample(string[] pallets, int size)
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

}
