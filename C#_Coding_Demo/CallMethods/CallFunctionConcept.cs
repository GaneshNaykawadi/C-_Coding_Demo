using C__Coding_Demo.Basics.Functions;

namespace C__Coding_Demo.CallMethods;

public class CallFunctionConcepts : ValidateIPAddress
{
    private readonly string[] ipv4Address;

    public CallFunctionConcepts(string[] IpV4Address)
    {
        ipv4Address = IpV4Address;
    }
    internal void CallMedicineAlertFunctions()
    {
        //GiveMedicineTimeAlert();
        isValidIPAddress(ipv4Address);
    }
}
