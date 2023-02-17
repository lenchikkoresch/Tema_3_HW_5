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

int dimension = GetLength ("Введите размер массива");
double[] array = InitArray(dimension);
Console.WriteLine(string.Join(",", array));


double min = Int32.MaxValue;
double max = Int32.MinValue;

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
Console.WriteLine($"всего {array.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");