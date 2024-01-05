// Задача 1: Напишите программу, которая принимает на вход число и 
// проверяет, кратно ли оно одновременно 7 и 23.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 7 == 0 && number % 23 == 0 )
{
    Console.WriteLine($"Число: {number} кратно 7 и 23");
}
else
{
    Console.WriteLine($"Число: {number} не кратно 7 и 23");
}

// Задача 2: Напишите программу, которая принимает на вход координаты 
// точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти 
// плоскости, в которой находится эта точка.

Console.Write("Введите координату X: ");
int numberX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int numberY = Convert.ToInt32(Console.ReadLine());

if (numberX == 0 && numberY == 0)
{
    Console.WriteLine("Введите корректные координаты!");
}
else if (numberX > 0 && numberY > 0)
{
    Console.WriteLine($"Для координат({numberX},{numberY})Номер координатной четверти 1");
}
else if (numberX < 0 && numberY > 0)
{
    Console.WriteLine($"Для координат({numberX},{numberY})Номер координатной четверти 2");
}
else if (numberX < 0 && numberY < 0)
{
    Console.WriteLine($"Для координат({numberX},{numberY})Номер координатной четверти 3");
}
else if (numberX > 0 && numberY < 0)
{
    Console.WriteLine($"Для координат({numberX},{numberY})Номер координатной четверти 4");
}
else
{
    Console.WriteLine("Точка лежит на оси координат");
}

// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

Console.Write("Введите число от 10 до 99: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 99 && number >= 10)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    if (firstDigit > secondDigit)
    {
        Console.WriteLine($"{firstDigit} наибольшая цифра числа");
    }
    else 
    {
        Console.WriteLine($"{secondDigit} наибольшая цифра числа");
    }
}
else
{
    Console.WriteLine("Введите двухзначное число");
}

// Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.

Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int digit = 0;
if (N >= 10)
{
    while (N > 0)
    {
        digit = N % 10;
        N = N / 10;
        if (N > 0)
        {
            Console.Write(digit + ",");
        }
        else
        {
            Console.Write(digit);
        }
    }
}
else
{
    Console.WriteLine(N);
}