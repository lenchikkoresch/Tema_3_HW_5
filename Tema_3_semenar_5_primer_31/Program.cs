/*
Задача 31: Задайте массив из 12 элементов, заполненный случайными числами 
из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
сумма отрицательных равна -20.
*/

/*
1. Задать массив
2. Вывести массив на экран
3. Ввывести сумму положительных 
4. Вывести cумму отрицательных
*/
//Задать массив
int [] GreatArray(int array)
{
    int [] Array = new int [array];
    Random number = new Random ();
    for (int i = 0; i< Array.Length; i++)
    {
        Array [i] =number.Next(-9,10);
    }
return Array;
}
//Вывести массив на экран
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]},  ");
    }
}

//Ввывести сумму положительных 
int GetPozitiveSumm(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

//Вывести cумму отрицательных
int GetNegativeSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sum += array[i];
        }
    }
    return sum;
}
// Для простых функций можно задать кортеж из нескольких переменных, но выводть строго
// в заданном порядке
(int, int) GetSummsFromArray(int[] array)
{
    int posSum=0;
    int negSum=0;
    for (int i = 0; i < array.Length; i++)
    {
    if (array[i] > 0)
        {
            posSum += array[i];
        }
        else
        {
negSum += array[i];
        }

    
    }
    return (posSum, negSum);
}

int[] array = GreatArray(12);
PrintArray (array);
int posSum = GetPozitiveSumm (array);
int negSum = GetNegativeSum(array);
Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел равна {posSum}.");
Console.WriteLine($"Сумма отрицательных чисел равна {negSum}");
(int pos, int neg) = GetSummsFromArray(array);
Console.WriteLine($"Сумма положительных чисел равна {pos}.");
Console.WriteLine($"Сумма отрицательных чисел равна {neg}");
