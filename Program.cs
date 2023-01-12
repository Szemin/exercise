namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Human human1 = new Human();

            human1.name = "Rick";


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
