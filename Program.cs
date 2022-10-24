Console.WriteLine("Enter the number 1:");
int number_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the number 2:");
int number_2 = int.Parse(Console.ReadLine()!);

if (number_1 > number_2)
{
    Console.WriteLine(number_1);
}
else {
    if (number_2 > number_1) {
        Console.WriteLine(number_2);
    }
    }
