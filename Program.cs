namespace ConsoleApp10
{
    internal class Program
    {
        
        public string tytul;
        public string autor;
        public double strony;
        
        static void Main()
        {
          
              //obiekt to instancja klasy, a klasa może być używana przez plan(blueprint) do tworzenia obiektów
            // obiekty mogą mieć pola i metody - pola(fields) to to co obiekt zawiera, metoda to to co obiekt może zrobić
            
           Human human1 = new Human();
            Human human2 = new Human();

            human1.name = "Rick";
            human1.age = 69;

            human2.name = "Morty";
            human2.age = 16;

            human1.Eat();
            human1.Sleep();

            human2.Eat();
            human2.Sleep();

            Console.ReadKey();
        }
    }
   public class Human
    {
       public String name;  //obiekt string
       public int age;     // obiekt int

       public void Eat()
        {
            Console.WriteLine($"{name} is eating");    

            
        }
      public void Sleep()
        {
            Console.WriteLine($"{name} is sleeping");


        }

    }
}
