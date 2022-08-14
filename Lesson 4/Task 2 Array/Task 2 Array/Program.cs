static int[] inputArrayRandomData(int[] arr)
{
    Random rand = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(-100, 100);
    }
    return arr;
}

static void printArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }    
    Console.WriteLine();
}

static int findMin(int[] arr)
{
    int min = arr[0];
    foreach (var i in arr)
    {
        if (i < min)
        {
            min = i;
        }
    }
    Console.WriteLine("Значение минимального элемента в массиве равно: " + min);
    return min;
}

static int findMax(int[] arr)
{
    int max = arr[0];
    foreach (var i in arr)
    {
        if (i > max)
        {
            max = i;
        }
    }
    Console.WriteLine("Значение максимального элемента в массиве равно: " + max);
    return max;
}

static int Sum(int[] arr)
{
    int value = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        value = value + arr[i];
    }
 
    return value;
}

static double Average(int[] arr)
{
    double a = Sum(arr);
    a = a / arr.Length;
    Console.WriteLine("Среднее арифметическое значений массива равно " + a);
    return a;
}

static Array sortArray(int[] arr)
{
    Console.Write("Отсортированный массив по убыванию: ");
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] < arr[j])
            {
                int temp = arr[j];
                arr[j] = arr[i];
                arr[i] = temp;
            }
        }
    }
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
   
    return arr;
}


Console.Write("Введите размер массива: ");
int sizeArray = int.Parse(Console.ReadLine());
int[] myArray = new int[sizeArray];
inputArrayRandomData(myArray);
findMax(myArray);
findMin(myArray);
Console.WriteLine("Сумма элементов массива равна " + Sum(myArray));
Average(myArray);
sortArray(myArray);
Console.ReadLine();

