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
string orderIDs = "B123,C234,A345,C15,B177,G3003,C235,B179";

CallArrayExamplesMethods ArrayMethods = new CallArrayExamplesMethods(pallets, orderIDs);
ArrayMethods.ArrayExamplesMethods();