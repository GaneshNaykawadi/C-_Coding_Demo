// See https://aka.ms/new-console-template for more information
using C__Coding_Demo.Basics.DataTypes;
using System;

Console.WriteLine("C# Program Demo's");

/// Basics => DataTypes => TypeCasting => getResult(int, string/int) ///
///
/*  -------------------------------------------------------------
int first = 10;
string second = "20";
// int second = 20;

try
{
    string Result = TypeCasting.getResult(first, second);
    // int Result = TypeCasting.getResult(first, second);
    Console.WriteLine($"Result is: {Result}");
}

catch (Exception ex)
{
    System.Console.WriteLine($"Error Occured: {ex.Message}");
}

*/

/// Basics => DataTypes => TypeCasting => ExplicitCasting() ///

TypeCasting.ExplicitCasting();


/// Basics => DataTypes => TypeCasting => useToStringMethod() ///

TypeCasting.useToStringMethod();

/// Basics => DataTypes => TypeCasting => useParseMethod() ///

TypeCasting.useParseMethod();