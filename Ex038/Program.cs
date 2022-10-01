// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

void fillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().NextDouble() * 10;
}

double findMin(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
     if (array[i] < min) min = array[i];
    return min;
}

double findMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
     if (array[i] > max) max = array[i];
    return max;
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
fillArray(array);
Console.WriteLine("Массив: [" + string.Join(", ", array) + "]");
Console.WriteLine("Максимальное значение: " + findMax(array));
Console.WriteLine("Минимальное значение: " + findMin(array));
Console.WriteLine("Разница: "+ (findMax(array) - findMin(array)));
