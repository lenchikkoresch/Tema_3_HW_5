/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

/*
1. Инициализируем массив
2. Заполняем массив случайными числами
3. Считаем количество четных элементов в массиве
4. Выводим на экран
*/

int[] InitArray(int dimension)
{
    int[] arr = new int[dimension];
    Random rnd = new Random();
    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}

int EvenCount(int[] arr)
{
    var count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        int c = arr[i] % 2;
        if (c == 0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine();
int[] array = InitArray(15);
int count = EvenCount(array);

Console.WriteLine(string.Join(",", array));
Console.WriteLine($"-> В указанном массиве находтся {count} четных чисел.");

