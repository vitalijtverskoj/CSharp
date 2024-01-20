// Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе 
// символа ‘q’ или при вводе числа, сумма цифр которого чётная.

// while (true) // true == true
// {
//     Console.Write("Введите текст: ");
//     string text = Console.ReadLine();
//     if (text == "q")
//     {
//         break;
//     }
//     // 11 => 1+1 = 2
//     int number; // n = 0, в text присутствуют не только цифры
//     // Проверка, что строчка text состоит ТОЛЬКО из цифр
//     if (int.TryParse(text, out number)) // == true
//     {
//         int sum = 0; // 56=> 5+6 = 11
//         while (number > 0)
//         {
//             sum = sum... ; // sum = 6
//             number /= 10;
//         }
//         if (sum % 2 == 0)
//         {
//             break;
//         }
//     }
// }

void IntRequest()
{
    while (true)
    {
        Console.Write("Введите целое число: ");
        string reqString = Console.ReadLine();
        if (reqString == "q")
        {
            Console.Write("Программа завершена (Выход q)");
            return;
        }
        int reqNum;
        if (int.TryParse(reqString, out reqNum))
        {
            int sum = 0;            
            while (reqNum > 0)
            {
                sum = sum + (reqNum % 10);
                reqNum = reqNum / 10;
            }
            if (sum % 2 == 0)
            {
                Console.Write("Cумма чисел чётная!");
                return;
            } 
        }
        else
        {
            Console.Write("Вы ввели не число! ");
        }
    }
}

IntRequest();
