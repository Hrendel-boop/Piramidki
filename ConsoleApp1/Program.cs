//
//
//
Console.WriteLine("Сколько раз выполнить цикл");
int length = int.Parse(Console.ReadLine());

for (int i = 1; i <= length; i++)
{
    for (int b = 0; b < i ; b++)
    {
        Console.Write("#");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine();

for (int i = length; i > 0; i--)
{
    for (int ii = i; ii > 0; ii--)
    {
        Console.Write("#");
    }
    
    Console.WriteLine();
}


Console.WriteLine("Конец цикла");
Console.ReadLine();