﻿// See https://aka.ms/new-console-template for more information

using System;
Console.WriteLine("CONGRATULATIONS !, Now you have a chanece to win 1ooo$");
Console.WriteLine("To get a gift \"You have to SIGN IN and answer for 5 questions ready?\"");
Console.WriteLine("To confirm click \"Yes\" to ignore click \"No\"");
string pr = System.Console.ReadLine();
System.Console.WriteLine($"You entered \"{pr}\"");
Console.WriteLine("Loading...");
Console.WriteLine("To SIGN IN enter your email...");
string email = Console.ReadLine();
Console.WriteLine("Enter you password:");
string password = Console.ReadLine();
Console.WriteLine("Enter your Full name:");
Console.WriteLine("Caution! be carefull in entering your name and email to win!");
string name = Console.ReadLine();
Console.WriteLine("Loading...");
Console.WriteLine($"Hello {name} ");
Console.WriteLine("To find you, We must know your phone number! Please Enter:");
string phoneNumber = Console.ReadLine();
int phone = Convert.ToInt32(phoneNumber);
Console.WriteLine("Enter you age to confirm that you are over 18+ ");
string age = Console.ReadLine();
int yourAge = Convert.ToInt32(age);
Console.WriteLine("Loading...");
Console.WriteLine("Congratulations! It was trick and we have all information about you ha ha ha ...");
Console.WriteLine($"Your Full name is {name}");
Console.WriteLine($"Your email is {email} your password is {password}");
Console.WriteLine($"Your phone number is {phoneNumber} and age is {age}");
Console.WriteLine("In order to quit click \"0\" to continue click \"1\"");
string button = Console.ReadLine();
Console.WriteLine($"You entered {button}");
Console.WriteLine("Loading....");
Console.WriteLine("It was a my first project on C# to make you a little bit happy");
Console.WriteLine("Main idea of this program to find age difference between us");
int myAge = 27;
Console.WriteLine("To know age Difference click \"Yes\" to quit \"No\"");
Console.WriteLine("Loading...");
string press = System.Console.ReadLine();
System.Console.WriteLine($"You entered {press}");
int ageDifference = myAge-yourAge;
Console.WriteLine($"Our age difference is {ageDifference}");
Console.WriteLine("Thank you for participating in my first project");
// < <= > >= == !=
Console.WriteLine($"You are younger than me {myAge>yourAge}");
Console.WriteLine($"You are older than me {myAge<yourAge}");
Console.WriteLine($"You are older or equal me {myAge<=yourAge}");
Console.WriteLine($"You are younger or equal {myAge>=yourAge}");
Console.WriteLine($"Your age is equal to mine {myAge==yourAge}");
Console.WriteLine($"Your age is not equal to mine {myAge!=yourAge}");

