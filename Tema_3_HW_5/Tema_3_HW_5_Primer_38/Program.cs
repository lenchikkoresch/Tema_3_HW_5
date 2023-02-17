/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и 
минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

/*
1. Инициализируем массив
2. Заполняем массив случайными вещественными числами
3. Находим максимальный элемент
4. Находим минимальный элемент
5. Находим разницу между максимальным и минимальным элементами массива
6. Выводим на экран
*/
int GetLength (string message)
{
    int resultLength =0;
    while(true)
    {
       Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out resultLength) && 1<resultLength)
        {
            break;
        }
        else
        {
            Console.WriteLine("Число ввели некорректно");
        }
      }
    return resultLength; 
}


double [] InitArray ( int dimension)
{
double [] arr = new double [dimension];
Random rnd = new Random();
for (int i=0; i<dimension; i++)
{
arr[i] = rnd.Next(-99,100);
}
return arr;
}

(double, double) GetMinMaxFromArray(double[] array)
{
    double max = array [0];
    double min = array [0];;

    for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }
}
    return (max, min);
}
int n = GetLength ("Введите размер массива");
double[] arra = InitArray(n);
Console.WriteLine(string.Join(",", arra));
(double max, double min) = GetMinMaxFromArray(arra);


Console.WriteLine($"всего {arra.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");