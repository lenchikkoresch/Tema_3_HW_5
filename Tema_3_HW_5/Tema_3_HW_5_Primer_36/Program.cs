/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0

*/

/*
1. Инициализируем массив
2. Заполняем массив случайными числами
3. Считаем сумму элементов, стоящих на нечётных позициях
4. Выводим на экран
*/

int [] InitArray ( int dimension)
{
int [] arr = new int [dimension];
Random rnd = new Random();
for (int i=0; i<dimension; i++)
{
arr[i] = rnd.Next(-99,100);
}
return arr;
}

int SumEvenPosizion (int[] arr)
{
    int sum = 0;
        for (int i = 0; i < arr.Length; i++)
    { int c = i % 2;
       if (c == 1)
       sum += arr[i];
        }
        return sum;
}
Console.WriteLine();
int[] array = InitArray(15);
int sum = SumEvenPosizion (array);

Console.WriteLine(string.Join(",", array));
Console.WriteLine($"-> Cуммa элементов {sum}, стоящих на нечётных позициях");
