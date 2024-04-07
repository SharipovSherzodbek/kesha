using System;

namespace KESHA
{
    class Program
    {
     static void Main(string[] args)
    {   
        try{
        Animals kesha = new Animals ("KESHA", age: 7);
        Animals kasew = new Bird("Kasew" , age: 7);
        Pet lida =  new Pet("Lidaa" , 9);

        Console.WriteLine("Enter your name:");
        string userName = Console.ReadLine();
        
        lida.Pets = PetType.parrot;
        Console.WriteLine($"Let me introduce me {lida.Pets}'s ");
        Console.WriteLine("Kesha was created: " + kesha.CreatedTime);
        kesha.Greeting(userName);
        kasew.Greeting(userName);
        lida.Greeting(userName);
       // pet.Great(userName);
        

        Console.WriteLine("Enter your age ... ");
        int userAge = int.Parse(Console.ReadLine());

        kesha.CalculateAgeDifferenceWithNoReturn(userAge);
        kesha.PrintAgeDifference();
        kesha.CompareAges(userAge);
        kesha.TellAboutFriends(userName, userAge);
        }
        catch(FormatException formatException)
        {
            Console.WriteLine("Eror was thrown... Messege:" + formatException.Message);
        }
        catch(Exception exception)
        {
            System.Console.WriteLine("Eror" + exception.Message);
        }
        Console.WriteLine("Program ended...");
    }
    }
}