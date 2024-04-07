public class Bird : Animals
{
    public Bird(string name, int age) : base(name, age)
    {
            
    }

    public override void Greeting(string userName)
  {
    Console.WriteLine($"Kasew: Nice to meet you {userName}");
  }
}
