namespace KESHA.Classes
{
    class Animal
    {
      public int Age {get; set; }    
      public string Name {get; set;} 
      public int AgeDifference { get; set; }

      public Animal()
      {
        Name = "No name";
        Age = 0;
        AgeDifference = 0;
      }

      public Animal (
        string name,
        int userAge, 
        int animalAge)
      {
        Name = name;
        Age = animalAge;
        //AgeDifference = userAge - animalAge;
        //AgeDifference = CalculateAgeDiffernce(userAge, animalAge);
        CalculateAgeDiffernceWithNoReturn(userAge, animalAge);
      }

      public void PrintAgeDifference()
      {
      Console.WriteLine($"The Difference between your and {Name}'s age is {AgeDifference}");
      }

      public void CompareAges(int userAge)
      {
            if (userAge > Age)
          {
            Console.WriteLine($"You are older than me!"); 
          }
          else if (userAge == Age)
          {
            Console.WriteLine($"Your age is equal to kesha's age!");
          }
          else 
          {
            Console.WriteLine($"You are younger than me!");  
          }
      }
public void TellAboutFriends(string userName, int userAge )
{
          Console.WriteLine("Let me tell you about my friends.");

        string[] friendsName = new string [3];
        friendsName[0] = "Valya";
        friendsName[1] = "Shahnoza";
        friendsName[2] = userName ;

        int [] friendsAge = {12 , 45, userAge};

        for ( int i = 0; i < friendsName.Length ; i++ )
        {
          Console.WriteLine($"{friendsName[i]} is {friendsAge[i]} year old");
        }
}
    
      private int CalculateAgeDiffernce (int userAge, int animalAge)
      {
        return userAge - animalAge;
      } 

    
    private void CalculateAgeDiffernceWithNoReturn (int userAge, int animalAge)
    {
      AgeDifference = userAge - animalAge;
    }
    }
}
