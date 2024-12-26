public class Program{
    public static void Main(String [] args){

        Cat C = new Cat("Cat",50);
        Dog D = new Dog("Dog",100,true);
        Bird B = new Bird("Bird",10,true);
        Animal [] A = [C,D,B];

        for(int i = 0;  i <= 2;i++ ){
          Animal Ani = A[i];

        Ani.makeSound();
            
        }
        for(int i = 0;  i <= 2;i++ ){
          Animal Ani = A[i];

       Console.WriteLine( Ani.Name+"Health is :"+Ani.getHealth());
            
        }
       Console.WriteLine(Animal.TotalAnimals);
    }
}