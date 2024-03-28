using System;
namespace KESHA
{
    class Program
    {
     static void Main(string[] args)
    {
        Animals kesha = new Animals( "KESHA", age: 7);

        Console.WriteLine("Enter your name:");
        string userName = Console.ReadLine();

        kesha.Greeting(userName);

        Console.WriteLine("Enter your age ... ");
        int userAge = int.Parse(Console.ReadLine());

        kesha.CalculateAgeDifferenceWithNoReturn(userAge);
        kesha.PrintAgeDifference();
        kesha.CompareAges(userAge);
        kesha.TellAboutFriends(userName, userAge);
    }
    }
}