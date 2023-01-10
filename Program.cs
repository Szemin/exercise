Console.WriteLine("insert number");

int number = int.Parse(Console.ReadLine());

int zero = 0;

int sum = 0;

while (number != zero)
{
    sum += number;
    number++;
    number = int.Parse(Console.ReadLine());
}
Console.WriteLine(sum);


/*Napisać program, który pobiera od użytkownika liczbę całkowitą dodatnią,
a następnie wyświetla na ekranie kolejno wszystkie liczby niepatrzyste nie większe od
podanej liczby. Przykład, dla 15 program powinien wyświetlić 1, 3, 5, 7, 9, 11, 13,
15.
*/

Console.WriteLine("Insert number");

int number = int.Parse(Console.ReadLine());

for (int i = 0; i < number; i++)
{
    if (i % 2 == 1)
    {
        Console.WriteLine(i);
    }
}



/*for
przedział 0 - 99
    n = 5;
oblicza średnią wszystkich liczb
*/


for (int i = 0; i < n; i++)
{
    int rand_num = random.Next(0, 99);
   liczba = rand_num;
   Console.WriteLine(rand_num);
  sr += rand_num/n;


Console.WriteLine("\n " + sr);
Console.WriteLine(liczba);
}



//przedział 1 do 100 czyli maksymalnie 10x10 
//podwójna pętla for



