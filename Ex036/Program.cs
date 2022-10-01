// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


void fillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 10);
}

int releaseArr(int[] array)
{
    int counter = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        counter +=array[i];
    }
    return counter;
}


Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
fillArray(array);
Console.WriteLine("Массив: [" + string.Join(", ", array) + "]");
Console.WriteLine($"Сумма элементов массива с нечетными индексами: {releaseArr(array)}");
