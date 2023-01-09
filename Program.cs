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