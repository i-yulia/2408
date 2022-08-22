// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int current = 2;
while (current <= number)
    if (number < 1)
    {
    Console.Write($"Неверно введено число");
    }

{
    if (number % 2 == 0)
    { 
Console.Write($"{current}");
        current = current + 2;
    }
else
{
    current++;
}
}

