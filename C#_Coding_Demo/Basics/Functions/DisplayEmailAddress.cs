namespace C__Coding_Demo.Basics.Functions;

public class DisplayEmailAddress
{
    // internal employees list
    string[,] corporateEmployees =
    {
       {"Robert", "Bavin"}, {"Simon", "Bright"},
       {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
       {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
    };

    // external employees list
    string[,] externalEmployees =
    {
       {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
       {"Shay", "Lawrence"}, {"Daren", "Valdes"}
    };

    string externalDomain = "hayworth.com";

    internal void checkEmployeeType()
    {
        // display internal email addresses
        for (int i = 0; i < corporateEmployees.GetLength(0); i++)
        {
            DisplayEmail(first: corporateEmployees[i, 0], last: corporateEmployees[i, 1]);
        }

        // display external email addresses
        for (int i = 0; i < externalEmployees.GetLength(0); i++)
        {
            DisplayEmail(first: externalEmployees[i, 0], last: externalEmployees[i, 1], domain: externalDomain);
        }
    }

    private void DisplayEmail(string first, string last, string domain = "contoso.com")
    {
        string email = first.Substring(0, 2) + last;
        email = email.ToLower();
        Console.WriteLine($"{email}@{domain}");
    }

}
