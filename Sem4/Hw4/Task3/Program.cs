// Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, 
// второй – предпоследним и т.д.)

void ArrayReverse(int[] arr)
{
    int num = 0;
    for (int i = 0, j = arr.Length - 1; i < arr.Length / 2; i++, j--)
    {
        num = arr[i];
        arr[i] = arr[j];
        arr[j] = num;
    }
}

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
Console.WriteLine($"Массив ДО: [{string.Join(", ", array)}]");
ArrayReverse(array);
Console.WriteLine($"Массив ПОСЛЕ: [{string.Join(", ", array)}]");