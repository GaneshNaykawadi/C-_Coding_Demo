using C__Coding_Demo.Basics.DataTypes;

namespace C__Coding_Demo;

public class CallDataTypesMethods : TypeCasting
{

    /*------------------------///  TypeCasting  ///---------------------------------*/


    /// Basics => DataTypes => TypeCasting => getResult(int, string/int) ///

    internal void TypeCastingFunctionality()
    {
        //? create instance of Typecasting class
        TypeCasting typeCasting = new TypeCasting();

        //? Create instance of PetAdoption_Guided_Project Class
        PetAdoption_Guided_Project PetAdoption = new PetAdoption_Guided_Project();

        /*
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
        ExplicitCasting();

        /// Basics => DataTypes => TypeCasting => useToStringMethod() ///
        useToStringMethod();

        /// Basics => DataTypes => TypeCasting => useParseMethod() ///
        useParseMethod();

        /// Basics => DataTypes => TypeCasting => useTryParseMethod() ///
        useTryParseMethod();

        /// Basics => DataTypes => TypeCasting => exampleTryParse() ///
        exampleTryParse();

        /// Basics => DataTypes => TypeCasting => ExerciseCast() ///
        ExerciseCast();
        */

        //PetAdoption Guided Project
        Console.WriteLine("||  PetAdoption Guided Project || ");
        PetAdoption.PetAdoptionFunc();
    }

}
