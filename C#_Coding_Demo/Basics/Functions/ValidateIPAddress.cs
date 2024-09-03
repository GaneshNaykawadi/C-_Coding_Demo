using System.Net.Sockets;

namespace C__Coding_Demo.Basics.Functions;

public class ValidateIPAddress
{
    private string[] address;
    private bool validLength = false;
    private bool validZeroes = false;
    private bool validRange = false;

    //? Method to check the given ip addresses are valid or not ?
    protected internal void isValidIPAddress(string[] IPv4Address)
    {


        foreach (string ip in IPv4Address)
        {
            address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

            //* Validate the ip address according to standards
            ValidateLength();
            ValidateZeroes();
            ValidateRange();

            if (validLength && validZeroes && validRange)
                System.Console.WriteLine($"{ip} is a valid IPv4 address");
            else
                System.Console.WriteLine($"{ip} is an invalid IPv4 address");
        }
    }

    //? Supported methods for repetative Tasks

    private void ValidateLength()
    {
        validLength = address.Length == 4;
    }

    private void ValidateZeroes()
    {
        foreach (string number in address)
        {
            if (number.Length > 1 && number.StartsWith("0"))
            {
                validZeroes = false;
                return;
            }
        }
        validZeroes = true;
    }

    private void ValidateRange()
    {
        foreach (string number in address)
        {
            int value = int.Parse(number);
            if (value < 0 && value > 255)
            {
                validRange = false;
                return;
            }
            validRange = true;
        }
    }
}
