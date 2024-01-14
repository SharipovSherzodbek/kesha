using System;
string parol = "";

do
{
    System.Console.WriteLine("Enter password to run \"123\"");
    parol = Console.ReadLine();
}
while (parol != "123");

Console.WriteLine("CONGRATULATIONS !, Now you have a chanece to win 1ooo$");
// Console.WriteLine("To get a gift \"You have to SIGN IN and answer for 5 questions ready?\"");
// Console.WriteLine("To confirm click \"Yes\" to ignore click \"No\"");
// string pr = System.Console.ReadLine();
// System.Console.WriteLine($"You entered \"{pr}\"");
// Console.WriteLine("Loading...");
// Console.WriteLine("To SIGN IN enter your email...");
// string email = Console.ReadLine();
// Console.WriteLine("Enter you password:");
// string password = Console.ReadLine();
Console.WriteLine("Enter your Full name:");
// Console.WriteLine("Caution! be carefull in entering your name and email to win!");
string name = Console.ReadLine();
Console.WriteLine($"Hello {name} ");
// Console.WriteLine("To find you, We must know your phone number! Please Enter:");
// string phoneNumber = Console.ReadLine();
Console.WriteLine("Enter your age to confirm that you are over 18+ ");
string age = Console.ReadLine();
int yourAge = Convert.ToInt32(age);
Console.WriteLine("Loading...");
// Console.WriteLine("Congratulations! It was trick and we have all information about you ha ha ha ...");
// Console.WriteLine($"Your Full name is {name}");
// Console.WriteLine($"Your email is {email} your password is {password}");
// Console.WriteLine($"Your phone number is {phoneNumber} and age is {age}");
// Console.WriteLine("In order to quit click \"0\" to continue click \"1\"");
// string button = Console.ReadLine();
// Console.WriteLine($"You entered {button}");
// Console.WriteLine("It was a my first project on C# to make you a little bit happy");
Console.ReadLine();
Console.WriteLine("Main idea of this program to find age difference between us");
int myAge = 27;
// Console.WriteLine("To know age Difference click \"Yes\" to quit \"No\"");
// string press = System.Console.ReadLine();
// System.Console.WriteLine($"You entered {press}");
int ageDifference = myAge-yourAge;
Console.WriteLine($"Our age difference is {ageDifference}");
Console.WriteLine("Thank you for participating in my first project");

if(myAge > yourAge)
{
 System.Console.WriteLine("You are younger!");   
}
else if (myAge == yourAge)
{
    System.Console.WriteLine("We are equal!");
}
else
{
    System.Console.WriteLine("You are older!");
}

if (myAge<yourAge)
{
    System.Console.WriteLine("You are older!");
}
else if (myAge == yourAge)
{
    System.Console.WriteLine("You are equal to me");
}
else
{
    System.Console.WriteLine("You are yonger");
}

// <  <=  >  >=  ==  !=

System.Console.ReadLine();
System.Console.WriteLine("Let me introduce you my friends!");

//string [] friendsName = { "Vasya", "Ilya", name }; yoki yana bitta usuli 
string [] friendsName = new string [3];  
friendsName[0] = "Vasya";
friendsName[1] = "Ilya";
friendsName[2] = name;
int [] friendsAge = {45, 14, yourAge };
string[] address = {"Chust", "Samarqand", "Tashkent"};
System.Console.WriteLine($"{friendsName[0]} is {friendsAge[1]} years old" );
System.Console.WriteLine($"{friendsName[2]} is {friendsAge[2]} years old" );
System.Console.WriteLine($"{friendsName[1]} is from {address[1]}");
System.Console.WriteLine("Enter age...");
friendsAge[2] = int.Parse(Console.ReadLine());
System.Console.WriteLine($"{friendsName[1]} is {friendsAge[2]} years old" );

               // FOR EACH 
// demak buni kamchilgi faqat bitta Array bilan ishlaydi
foreach (string ism in friendsName)
{
    System.Console.WriteLine(ism);
}

               // FOR
// ichida uchtA bulim buladi, malum bir sondan ikkinchi songacha yurib chiqasan 
// degani va cheksiz ishlatsak buladi,
for(int i=0 ; i<friendsName.Length; i++  ) 
{
   System.Console.WriteLine($"{friendsName[i]} is {friendsAge[i]} years old" ); 
}
//    misol
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(i);
}
