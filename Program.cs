namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
              //obiekt to instancja klasy, a klasa może być używana przez plan(blueprint) do tworzenia obiektów
            // obiekty mogą mieć pola i metody - pola(fields) to to co obiekt zawiera, metoda to to co obiekt może zrobić
            
            Human human1 = new Human();
            Human human2 = new Human();

            human1.name = "Rick";
            human1.age = 69;

            human1.name = "Morty";
            human1.age = 16;

            human1.Eat();
            human1.Sleep();

            Console.ReadKey();
        }
    }
   public class Human
    {
       public String name;
       public int age;

       public void Eat()
        {
            Console.WriteLine(name + "is eating");    

            
        }
      public void Sleep()
        {
            Console.WriteLine(name + "is sleeping");


        }

    }
}
