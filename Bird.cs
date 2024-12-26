public class Bird : Animal
{
    public bool inCage;
    public Bird(string Name, int Health,bool inCage) : base(Name, Health)
    {
        
    }
     public override void makeSound(){
        Console.WriteLine("The bird chirps melodiously!");
    }
    
}