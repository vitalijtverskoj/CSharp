// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void ShowIntervalNum(int M, int N)
{
    if (M == N)
    {
        Console.Write(M);
        return;
    }
    if (M > N)
    {
        Console.Write("Неверный интервал!");
    }
    Console.Write(M + "  ");
    ShowIntervalNum(M + 1, N);
}

Console.Write("Задайте начало интервала: ");
int start = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте конец интервала: ");
int end = Convert.ToInt32(Console.ReadLine());

ShowIntervalNum(start, end);