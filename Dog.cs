public class Dog : Animal
{
    public bool hasleash;
    
    public Dog(string Name, int Health , bool hasleash) : base(Name, Health)
    {
        
        
    }

    public override void makeSound(){
        Console.WriteLine("The dog bark loudly!");
    }
    
}