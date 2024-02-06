// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

// int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// int count = array.Length - 1;

// void ShowArrayReverse(int[] array, int count)
// {
//     if (count == 0)
//     {
//         Console.Write(array[0]);
//         return;
//     }
//     Console.Write($"{array[count]} ");
//     ShowArrayReverse(array, count - 1);  
// }

// ShowArrayReverse(array, count);

// Вариант 2. Вывод элементов массива при раскручивании рекурсии

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int count = 0;

void ShowArrayReverse(int[] array, int count)
{
    if (count == array.Length - 1)
    {
        Console.Write($"{array[array.Length - 1]} ");
        return;
    }
    ShowArrayReverse(array, count + 1);  
    Console.Write($"{array[count]} ");
}

ShowArrayReverse(array, count);