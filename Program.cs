// See https://aka.ms/new-console-template for more information

using System;
using KESHA.Classes;
Console.WriteLine("CONGRATULATIONS ! You have entered to my first project in C#");
Console.WriteLine("Enter your name:");
string name = Console.ReadLine();
Console.WriteLine("Loading...");
Console.WriteLine($"Hello {name} ");
Console.WriteLine("Enter your age ... ");
string age = Console.ReadLine();
int yourAge = Convert.ToInt32(age);

Console.WriteLine("To know age Difference between you and Kesha click \"Yes\" to quit \"No\"");
string press = System.Console.ReadLine();


Animal kesha = new Animal(name : "Kesha ", userAge : yourAge, animalAge: 11 );

// System.Console.WriteLine(kesha.Name);
// System.Console.WriteLine(kesha.Age);

//Console.WriteLine($"Our age difference is {kesha.AgeDifference}");
kesha.PrintAgeDifference();


kesha.CompareAges(userAge: yourAge);

// <  <=  >  >=  ==  !=
//Console.WriteLine($"You are older than me {keshaAge<yourAge}"); 
//Console.WriteLine($"Your age is equal to kesha's age {keshaAge==yourAge}");


kesha.TellAboutFriends(userName: name, userAge: yourAge);

// Console.WriteLine("Let me tell you about my friends.");

// string[] friendsName = new string [3];
// friendsName[0] = "Valya";
// friendsName[1] = "Shahnoza";
// friendsName[2] = name ;

// int [] friendsAge = {12 , 45, yourAge};

// for ( int i = 0; i < friendsName.Length ; i++ )
// {
//   Console.WriteLine($"{friendsName[i]} is {friendsAge[i]} year old");
// }
