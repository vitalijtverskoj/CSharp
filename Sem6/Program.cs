// str = "пример"
// Строка - массив символов, массив char-ов
// str[0] = "п"
// str[1] = "р"

// Задайте массив символов (тип char []). 
// Создайте строку из символов этого массива
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

// char - 1 символ, массив char-ов -
// массив, в котором элементы представлены 1 символом

// string GetStringFromCharArray (char[] array)
// {
//     string result = string.Empty; // ""
//     foreach (char symbol in array)
//     // symbol='a', symbol='b', symbol='c', symbol='d'
//     {
//         result += symbol; // result = result + symbol;
//     }
//     return result;
// }

// char[] chars = {'п', 'р', 'и', 'в', 'е', 'т'};
// string res = GetStringFromCharArray(chars);
// Console.WriteLine($"Result: {res}");

// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.

// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]
// "hi" => ['h', 'i']

// char [] ConvertStringToCharArray(string str)
// {
//     char[] chars = new char[str.Length];
//     for (int i = 0; i < str.Length; i++)
//     {
//         chars[i] = str[i];
//     }
//     return chars;
// }

// string inputString = "Hello world";
// char[] chars = ConvertStringToCharArray(inputString);
// Console.WriteLine($"Массив: [ {string.Join(", ", chars)}]");

// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

// int GetVovelsCount(string str)
// {
//     string vovels = "aoueyi"; // Гласные буквы в англ. алфавите
//     int countVovels = 0; // Количество гласных 
//     foreach (char symbol in str) // Берем каждый символ введенной стр
//     {
//         foreach (char vovel in vovels) // Получаем гласную букву
//         {
//             if (symbol == vovel) // Нашли гласную букву
//             {
//                 countVovels++;
//             }
//         }
//     }
//     return countVovels;
// }

// Console.Write("Введите строку: ");
// string inputString = Console.ReadLine();
// inputString = inputString.ToLower(); // перевели строчку в нижний регист
// int countVovels = GetVovelsCount(inputString);
// Console.WriteLine($"В строчке: {inputString}(в нижнем регистре) : {countVovels} гласных");