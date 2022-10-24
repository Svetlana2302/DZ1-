Console.WriteLine("Enter the number 1:");
int number_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the number 2:");
int number_2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the number 3:");
int number_3 = int.Parse(Console.ReadLine()!);
int max = number_1;

if (number_2 > number_1)
{
     max = number_2;
}
if (number_3 > max) 
{
    max = number_3; 
}

Console.WriteLine(max);