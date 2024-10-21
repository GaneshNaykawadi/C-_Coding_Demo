using C__Coding_Demo.Basics.Functions;

namespace C__Coding_Demo.CallMethods;

public class CallFunctionConcepts : ValidateIPAddress
{
    private readonly string[] ipv4Address;

    public CallFunctionConcepts()
    {

    }
    public CallFunctionConcepts(string[] IpV4Address)
    {
        ipv4Address = IpV4Address;
    }
    internal void CallMedicineAlertFunctions()
    {
        //GiveMedicineTimeAlert();
        //isValidIPAddress(ipv4Address);


        /*
        RSVP_App app = new RSVP_App();
        app.rsvp("Rebecca");
        app.rsvp("Nadia", 2, "Nuts");
        app.rsvp("Linh", 2, "none", false);
        app.rsvp("Tony", allergies: "Jackfruit", inviteOnly: true);
        app.rsvp("Noor", 4, inviteOnly: false);
        app.rsvp("Jonte", 2, "Stone fruit", false);
        app.rsvp("Tony", inviteOnly: true, allergies: "Jackfruit", partySize: 1);
        app.showRsvps();
        */

        DisplayEmailAddress displayEmail = new DisplayEmailAddress();
        displayEmail.checkEmployeeType();
    }
}
