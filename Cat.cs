public class Cat : Animal
{
    public Cat(string Name, int Health) : base(Name, Health)
    {
    }
    public override void makeSound(){
        Console.WriteLine("The cat meows softly!");
    }
     public override void takeDamage(Animal a ,int DamageAmount){
        DamageAmount = DamageAmount / 2;
     int remining = a.getHealth() - DamageAmount;
     Console.WriteLine(remining);
    }
    
}