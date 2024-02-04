// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

// string GetStringFromCharArray (char[,] array)
// {
//     string result = string.Empty;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             result += array[i,j];
//         }
//     }
//     return result;
// }

// void PrintArray(char[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// char [,] charsMatrix = {
//     {'a', 'b', 'c', 'd'},
//     {'e', 'f', 'g', 'h'},
//     {'i', 'j', 'k', 'o'},
// };
// Console.WriteLine($"Из этого массива: ");
// PrintArray(charsMatrix);
// Console.WriteLine($"Получили строку: {GetStringFromCharArray (charsMatrix)}");


// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, 
// в которой все заглавные буквы заменены на строчные.

// string GetStringToLower (string str)
// {
//     return str.ToLower();
// }

// string stringUpLow = "aBcDeFgH";
// string stringLow = GetStringToLower(stringUpLow);
// Console.WriteLine(stringLow);

// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

// bool IsPalindrome(string str)
// {
//     for (int i = 0, j = str.Length - 1; i < str.Length; i++, j--)
//     {
//         if (str[i] != str[j])
//         {
//             return false;
//         }
//     }
//     return true;
// }

// string str = "мама";
// Console.Write(IsPalindrome(str));

// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.
// "Hello my world" => "world my Hello"

string GetReversSent(string str)
{
    string result = string.Empty;
    int i = str.Length - 1;
        
    while (i >= 0)
    {
        string oneWord = string.Empty;
        
        for (; i >= 0; i--)
        {
            if (str[i] != ' ')
            {
                oneWord += str[i];
            }
            else
            {
                i--;
                break;
            };
        }
        for (int j = oneWord.Length - 1; j >= 0; j--)
        {
            result += oneWord[j];
        }
        if (str.Length != result.Length)
        {
            result += ' ';
        }
    }
    return result;
}

string str = "Hello my world";
Console.WriteLine(str);
Console.WriteLine(GetReversSent(str));