using System.Dynamic;

public class Animal{
    public String Name;
    private int Health {set; get;}
    public static int TotalAnimals;
    public Animal(String Name,int Health){
        this.Name = "Animal";
        this.Health = 100;
        TotalAnimals++;
    }

    

    public virtual void makeSound(){
        Console.WriteLine("Animal make sound!");
    }
    public virtual void takeDamage(Animal a ,int DamageAmount){
     int remining = a.Health - DamageAmount;
     Console.WriteLine(remining);
    }
    public int getHealth(){
        return this.Health;
    }
     public void setHealth(int Health){
         this.Health = Health;
    }
}