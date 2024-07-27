using C__Coding_Demo;
using C__Coding_Demo.Basics.DataTypes.Arrays;
using C__Coding_Demo.CallMethods;
using static C__Coding_Demo.Basics.DataTypes.Strings.StringManipulation;

Console.WriteLine("C# ♡ Programs: ");

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

Transaction[] transactions = new Transaction[]
{
    new Transaction("769C", "Mr. George Dammer", "$5,000.00"),
    new Transaction("9D2Q", "Mrs. Pamela Stunner", "$15,700.00"),
    new Transaction("5C0Z", "Mr. Simon Park", "$11,235.00"),
    new Transaction("3V4M", "Miss. Kim Kardashian", "$7,025.00"),
};

//IndexOf() method
string message = "Find what is (inside the parentheses)";
string[] substrings = { "G", "w", "F" };

//CallStringManipulation stringManipulation = new CallStringManipulation("Hello", "Ganesh");
//CallStringManipulation stringManipulation = new CallStringManipulation(125.50m, 10);
//CallStringManipulation stringManipulation = new CallStringManipulation(values);
//CallStringManipulation stringManipulation = new CallStringManipulation(67.55m, 59.99m);
//CallStringManipulation stringManipulation = new CallStringManipulation(transactions);
CallStringManipulation stringManipulation = new CallStringManipulation(substrings, message);
stringManipulation.CallStringMethods();

//----------------------------------------------------------------------- */