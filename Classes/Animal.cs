public  class Animals : IAnimals
 {
    public int Age { get; set; }
    public string Name { get; set; }
    public int AgeDifference { get; set; }
    public DateTimeOffset CreatedTime { get; set; }

   public Animals(string name, int age)
   {
      Name = name;
      Age = age;
      CreatedTime = DateTimeOffset.Now;
   }

       public void CalculateAgeDifferenceWithNoReturn(int userAge)
   {
      AgeDifference = userAge - Age;
   }
   
   public void PrintAgeDifference()
   {
      Console.WriteLine($"The Difference between your and {Name}'s age is {AgeDifference}");
   }
  
   public void CompareAges(int userAge)
   {
      if (userAge > Age)
      {
       Console.WriteLine($"You are older than KESHA!"); 
      }
      else if (userAge == Age)
      {
       Console.WriteLine($"Your age is equal to KESHA's age!");
      }
      else 
      {
       Console.WriteLine($"You are younger than KESHA!");  
      }
   }

   public void TellAboutFriends(string userName, int userAge)
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
// virtual(polymorfism) boshqa inheretence klasslarda bu Greeting uzgartirilishi mumkin
   public virtual void Greeting(string userName)
   {
      if(userName == "")
      {
         userName = "Unknown Person";
      }
     Console.WriteLine($"Hello {userName}. It`s Kesha!");
   }

 }
