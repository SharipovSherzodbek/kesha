using System;
//pets
public class Pet : Animals

{
  public PetType Pets { get; set; }
  public Pet(string name, int age) : base (name, age)
  {        
  }

   /* public override void Great(string userName)
    {
        System.Console.WriteLine("Abstracted Method from " + userName);
    } */

    public override void Greeting(string userName)
  {
    Console.WriteLine($"Hello {userName} my name is Lida");
  }
}