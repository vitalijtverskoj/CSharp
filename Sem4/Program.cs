// // тип_метода ИмяМетода (пар1, пар2...парN)
// // a, b - числа; char ('+', '-')
// // строчка - массив символов (char-ов)
// int Calculate(int a, int b, char sign)
// {
//     if (sign == '+') // "hello", '+' (char)
//     {
//         return a + b; // +
//     }
//     else if (sign == '-')
//     {
//         return a - b; // -
//     }
//     else if (sign == '*')
//     {
//         return a * b; // *
//     }
//     else if (sign == '/')
//     {
//         return a / b; // /
//     }
//     else
//     {
//         Console.WriteLine("Такого знака наш калькулятор НЕ знает");
//         return 0;
//     }
// }
// // Вызов метода
// // int Calculate(int a, int b, char sign)
// // PascalCase: GetCount
// Console.WriteLine(Calculate(10, 20, '+'));
// Console.WriteLine(Calculate(10, 20, '-'));
// Console.WriteLine(Calculate(300, 20, '/'));
// Console.WriteLine(Calculate(300, 20, '*'));
// Console.WriteLine(Calculate(300, 20, '.'));

// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2
// minRange - минимум для рандома
// maxRange - максимум для рандом

// int[] CreateArray(int size, int minRange, int maxRange)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(minRange, maxRange + 1);
//         // Next(0,3): [0,3+1) => 0,1,2,3
//     }
//     return array;
// }

// int GetCountOfInterestingElems(int[] arr)
// {
//     int count = 0;
//     foreach (int number in arr) // arr=[10,20,30,40]
//     // number = 10, 20, 30, 40
//     {
//         if (number % 7 == 0 && number % 10 == 1)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// Console.Write("Введите размер массива: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int min , int max ....
// int[] res = CreateArray(N, min, max);
// // CreateArray(N, 10, 100) создает массив на 10 элементов
// // Элемент: [10,100]
// Console.WriteLine($"Массив: [ {string.Join("; ", res)} ]");
// Console.WriteLine($"Total: {GetCountOfInterestingElems(res)}");

// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
        // Next(0,10): 0,1,2,3,4,5,6,7,8,9
    }
    return array;
}
int ConvertArrayToInteger(int[] arr)
{
    int result = 0;
    // [2,9,5] = 295
    // 2 * 10^2 => 200
    // 200 + 9 * 10^1 = 290
    // 290 + 5 * 1 = 295
    for (int i = 0, j = arr.Length - 1; i < arr.Length; i++, j--)
    {
        result += arr[i] * (int)Math.Pow(10, j);
        // double -> int (из вещ. ЧИСЕЛ перевел в целые ЧИСЛА)
    }
    return result;
}


Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] res = CreateArray(N); // Массив
if (res[0] == 0) // Размер > 8 ИЛИ первая цифра - 0
{
    return; // Ост-м программу, если размер > 8
}
// CreateArray(N, 10, 100) создает массив на 10 элементов
// Элемент: [10,100]
Console.WriteLine($"Массив: [ {string.Join("; ", res)} ]");
Console.WriteLine($"Number: {ConvertArrayToInteger(res)}");

while (true) // true == true
{
    Console.Write("Введите текст: ");
    string text = Console.ReadLine();
    if (text == "q")
    {
        break;
    }
    // 11 => 1+1 = 2
    int number; // n = 0, в text присутствуют не только цифры
    // Проверка, что строчка text состоит ТОЛЬКО из цифр
    if (int.TryParse(text, out number))// == true
    {
        int sum = 0; // 56=>5+6 = 11
        while (number > 0)
        {
            sum = sum ... ; // sum = 6
            number /= 10;
        }
        if (sum % 2 == 0)
        {
            break;
        }
    }
}