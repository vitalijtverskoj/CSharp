// // Рекурсия - вызов метода внутри метода
// // Факториал - про-е чисел от 1 до N включительно
// // 3! = 3 * 2 * 1= 6: n! = 1 * 2 ... * n
// // n -> 1, 1 -> n?
// int FindFactorial(int start)
// {
//     int n = 4;
//     // Базовый случай - случай остановки рекурсии
//     if (start == n) return n; // 1 * 2  * 3 * 4
//     // Рекурсивный случай - вызов функции внутри функции 
//     return start * FindFactorial(start + 1); // j--
//     // FindFactorial(4) 
//     // 4 * 3  * 2 * 1  =24
//     // FindFactorial(3)  = 3  * 2 * FindFactorial(1)
//     // FindFactorial(1) = 1
// }
// Console.WriteLine(FindFactorial(1));

// // Напишите программу, которая будет принимать на вход число и
// // возвращать сумму его цифр.
// // Указание
// // Использовать рекурсию.
// // Пример
// // 123 => 6
// // 63 => 9

// int SumOfDigits (int number)
// {
//     if (number == 0)
//     {
//         return 0;
//     }
//     int result = number % 10 + SumOfDigits(number / 10);
//     return result;
// }

// Console.Write(SumOfDigits(123));

// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// N = 5 => 1 2 3 4 5

void ShowNumbers(int start, int end)
{
    if (start == end) // 1 2 3 4 5 , start = 1, end = 5
    {
        Console.Write(start);
        return;
    }
    // "1" + "2" + "3" + "4" + 5
    // ShowNumbers(2, 5) => 2 + 3 + ShowNumbers(4, 5)
    Console.Write(start + "  "); // 1
    ShowNumbers(start + 1, end);  // 2
}
ShowNumbers(1, 10);