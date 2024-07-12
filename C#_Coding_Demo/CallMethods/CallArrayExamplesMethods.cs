using System.Security.Cryptography.X509Certificates;
using C__Coding_Demo.Basics.DataTypes.Arrays;
namespace C__Coding_Demo;

public class CallArrayExamplesMethods
{
    public required string[] pallets;

    //! Constructor
    [System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    public CallArrayExamplesMethods(string[] pallet)
    {
        this.pallets = pallet;
    }


    internal void ArrayExamplesMethods()
    {
        ArrayExamples examples = new ArrayExamples();
        examples.ArraySortExample(pallets);
        examples.ArrayReverseExample(pallets);
    }
}