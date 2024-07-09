using C__Coding_Demo.Basics.DataTypes;

namespace C__Coding_Demo;

public class CallDataTypesMethods
{

    /*------------------------///  TypeCasting  ///---------------------------------*/


    /// Basics => DataTypes => TypeCasting => getResult(int, string/int) ///

    internal void TypeCastingFunctionality()
    {
        //? create instance of Typecasting class
        TypeCasting typeCasting = new TypeCasting();


        //? Calling Methods of TypeCasting Class
        void getResult()
        {
            int first = 10;
            string second = "20";
            // int second = 20;

            try
            {
                string Result = typeCasting.getResult(first, second);
                // int Result = typeCasting.getResult(first, second);
                Console.WriteLine($"Result is: {Result}");
            }

            catch (Exception ex)
            {
                System.Console.WriteLine($"Error Occured: {ex.Message}");
            }
        }

        /// Basics => DataTypes => TypeCasting => ExplicitCasting() ///
        typeCasting.ExplicitCasting();

        /// Basics => DataTypes => TypeCasting => useToStringMethod() ///
        typeCasting.useToStringMethod();

        /// Basics => DataTypes => TypeCasting => useParseMethod() ///
        typeCasting.useParseMethod();

        /// Basics => DataTypes => TypeCasting => useTryParseMethod() ///
        typeCasting.useTryParseMethod();

        /// Basics => DataTypes => TypeCasting => exampleTryParse() ///
        typeCasting.exampleTryParse();

        /// Basics => DataTypes => TypeCasting => ExerciseCast() ///
        typeCasting.ExerciseCast();
    }


    /*------------------------///  ArrayExamples  ///---------------------------------*/
}
