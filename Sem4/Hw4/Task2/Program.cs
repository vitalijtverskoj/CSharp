// Задайте массив заполненный случайными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

int arrSize = 6;
int [] array = new int [arrSize];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
}
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");

int GetEvenCount(int [] arr)
{
    int count = 0;
    foreach (int e in arr)
    {
        if (e % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine(GetEvenCount(array));