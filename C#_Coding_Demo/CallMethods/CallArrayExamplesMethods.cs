using C__Coding_Demo.Basics.DataTypes.Arrays;
namespace C__Coding_Demo;

public class CallArrayExamplesMethods
{
    public string[] pallets;

    //! Constructor
    [System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    public CallArrayExamplesMethods(string[] pallet)
    {
        this.pallets = pallet;
    }

    internal void ArrayExamplesMethods()
    {
        ArrayExamples examples = new ArrayExamples();
        // examples.ArraySortExample(pallets);
        // examples.ArrayReverseExample(pallets);
        // examples.ArrayClearExmple(pallets, 0, 2);
        examples.ArrayResizeExample(pallets, 6);
    }
}