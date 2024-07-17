using C__Coding_Demo;
using C__Coding_Demo.Basics.DataTypes.Arrays;
using C__Coding_Demo.CallMethods;

Console.WriteLine("C# Programs: ");

//! TypeCasting Class
/* -------------------------------------------------------------------

Console.WriteLine("DataTypes Functionalities Demo's: ");
CallDataTypesMethods dataTypes = new CallDataTypesMethods();
dataTypes.TypeCastingFunctionality();

--------------------------------------------------------------------- */

//! Array Class

/* --------------------------------------------------------------------

string[] pallets = { "B14", "A11", "B12", "A13" };
string orderIDs = "B123,C234,A345,C15,B177,G3003,C235,B179";

CallArrayExamplesMethods ArrayMethods = new CallArrayExamplesMethods(pallets, orderIDs);
ArrayMethods.ArrayExamplesMethods();

----------------------------------------------------------------------- */

//! StringManipulation Class

//* --------------------------------------------------------------------

decimal[] values = { 123456.78912m, 0.36785m };

//CallStringManipulation stringManipulation = new CallStringManipulation("Hello", "Ganesh");
//CallStringManipulation stringManipulation = new CallStringManipulation(125.50m, 10);
//CallStringManipulation stringManipulation = new CallStringManipulation(values);
CallStringManipulation stringManipulation = new CallStringManipulation(67.55m, 59.99m);
stringManipulation.CallStringMethods();

//----------------------------------------------------------------------- */