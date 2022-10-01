// Дополнительная задача
// https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=6&id_topic=116&id_problem=717

int[] convertStrArrToInt (string[] arr)
{   int[] result = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++) result[i] = Convert.ToInt32(arr[i]);
    return result;
}
bool IsPrime(int N)
{   for (int i = 2; i < N; i++)
        if (N % i == 0) return false;
    return true;
}
int primeSumm (int[] arr)
{   int summ = 0;    
    for (int i = 0; i < arr.Length; i++)
        if (IsPrime(arr[i])) summ+=arr[i];
    return summ;
}

 Console.Clear();
 var sr = new StreamReader("input.txt");                     // Открываем текстовый файл, используя StreamReader
 string initialString = sr.ReadLine();                       // Считываем входной массив
 int[] array = convertStrArrToInt(initialString.Split(' ')); // Преобразовываем его в int[]
 
 Console.WriteLine("Сумма простых чисел массива: [" + string.Join(", ", array)+"] равна " + primeSumm(array));
 Console.WriteLine(IsPrime(primeSumm(array)));

 using (StreamWriter writer = new StreamWriter("output.txt", false)) // Используя StreamWriter перезаписываем содержимое файла output.txt
 {  await writer.WriteLineAsync("Сумма простых чисел массива: [" + string.Join(", ", array)+"] равна " + primeSumm(array));
          writer.WriteAsync(Convert.ToString(IsPrime(primeSumm(array))));
 }          
