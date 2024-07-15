using C__Coding_Demo.Basics.DataTypes.Arrays;
namespace C__Coding_Demo;

public class CallArrayExamplesMethods : ArrayExamples
{
    private readonly string[] pallets;
    private readonly string OrderIDs;

    //! Constructor
    public CallArrayExamplesMethods(string[] pallet, string orderIDs)
    {
        this.pallets = pallet;
        this.OrderIDs = orderIDs;
    }

    internal void ArrayExamplesMethods()
    {
        Console.WriteLine("\n____________________ Array Functionalities Demo's: ____________________\n\n");

        // ArraySortExample(pallets);
        // ArrayReverseExample(pallets);
        // ArrayClearExmple(pallets, 0, 2);
        // ArrayResizeExample(pallets, 6);
        // ReverseString("hsenaG");
        // ArrayJoinExample("hsenaG");
        // ArraySplitExample("MadaM");
        // ReverseSentenceChar("sihT si looC");
        CheckOrderIDs(OrderIDs);
    }
}