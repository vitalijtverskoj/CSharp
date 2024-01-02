// Коментарий
/*
    Это
    многострочный
    комментарий
*/

// Ctrl + /
// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

// тип_данных имяПеременной = значение;
// camelCase: firstNumber, secondNumber
// Convert.ToInt32("123") => 123 + 200 = 323
// Ctrl + /
// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

// тип_данных имяПеременной = значение;
// camelCase: firstNumber, secondNumber
// Convert.ToInt32("123") => 123 + 200 = 323
// Console.Write("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// // "==" - проверка условий, "=": int а = 5;
// if (firstNumber == secondNumber * secondNumber)
// // Является ли первое число квадратом второго?
// // firstNumber = 25, secondNumber = 5
// {
//     Console.WriteLine("Да, " + firstNumber + " является квадратом от " + secondNumber);
//     // Да, 25 является квадратом от 5
// }
// else // Первое число НЕ является квадратом от второго
// {
//     Console.WriteLine("НЕТ, " + firstNumber + " НЕ является квадратом от " + secondNumber);
// }



// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());

// if (N < 0)
// {
//     N *= -1; // N = N * -1
//     // a = a / 500: a /= 500
// }

// int negativeN = -N; // N = 5, negativeN = -5

// while (negativeN <= N)
// {
//     Console.Write(negativeN + "\t"); // "\t" = tab
//     negativeN++; // negativeN = negativeN + 1
//     // "negativeN++" - инкремент 
//     // "negativeN--" - декремент (negativeN = negativeN - 1)
// }

// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// [100 , 999]
// "&&" - "И": яблоки И апельсины 
// if (number >= 100 && number <= 999)
// {
//     Console.WriteLine("Число трехзначное :)");
//     // 167 => 1 + 7
//     int thirdDigit = number % 10; // 167 % 10 = 7
//     int firstDigit = number / 100; // 167 / 100 = 1
//     int result = firstDigit + thirdDigit;
//     Console.WriteLine("Сумма 1 и 3 цифры от числа " + number + " = " + result);
// }   
// else
// {
//     Console.WriteLine("Число НЕ трехзначное :)");
// }

// int firstNumber = 5;
// int secondNumber = 6;

// if (firstNumber > secondNumber)
// {
//     Console.WriteLine("Число " + firstNumber + " больше числа " + secondNumber);
// }
// else if (firstNumber < secondNumber)
// {
//     Console.WriteLine("Число " + firstNumber + " меньше числа " + secondNumber);
// }
// else
// {
//     Console.WriteLine($"Числа `{firstNumber}` и `{secondNumber}` равны");
// }
// int a = 9;
// int b = 8;
// int c = 7;

// int max = a;
// if (b > max)
// {
//     max = b;
// }
// if (c > max)
// {
//     max = c;
// }
// Console.WriteLine(max);


// int number = 5;
// if (number % 2 == 0)
//     {
//       Console.WriteLine("четное");
//     }
//     else
//     {
//       Console.WriteLine("нечетное");
//     }

int number = 8;
int index = 1;
while (index <= number)
{
    if (index % 2 == 0)
    {
        Console.Write(index + " ");
    }
    index++;
}