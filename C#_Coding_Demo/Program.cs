using C__Coding_Demo;
using C__Coding_Demo.Basics.DataTypes.Arrays;

Console.WriteLine("C# Programs: ");

//! TypeCasting Class
/*

Console.WriteLine("DataTypes Functionalities Demo's: ");
CallDataTypesMethods dataTypes = new CallDataTypesMethods();
dataTypes.TypeCastingFunctionality();

*/

//! Array Class

string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("Arrays Functionalities Demo's: ");
CallArrayExamplesMethods ArrayMethods = new CallArrayExamplesMethods(pallets);
ArrayMethods.ArrayExamplesMethods();