
static int[,] InputArray(int[,] arr, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Random rand = new Random();
            arr[i, j] = rand.Next(-100, 100);
        }
    }
    return arr;
}

static void printArray(int[,] arr, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

static int findMin(int[,] arr, int rows, int columns)
{
    int min = arr[0, 0];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (min < arr[i, j])
            {
                continue;
            }
            else
            {
                min = arr[i, j];
            }
        }
    }
    Console.WriteLine("Минимальное значение из массива равно : " + min);
    return min;
}

static int findMax(int[,] arr, int rows, int columns)
{
    int max = arr[0,0];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (max > arr[i, j])
            {
                continue;
            }
            else
            {
                max = arr[i, j];
            }
        }
    }
    Console.WriteLine("Максимальное значение из массива равно : " + max);
    return max;
}

static int Sum(int[,] arr, int rows, int columns)
{
    int value = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            value = value + arr[i, j];
        }
    }
    return value;
}

static double Average(int[,] arr, int rows, int columns)
{
    double a = Sum(arr, rows, columns);
    double itog = a / (rows * columns);
    Console.WriteLine("Среднее арифметическое массива равно: " + itog);
    return itog;
}

static void sortArrayTwoDimensional(int[,] arr, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int k = 0; k < columns - 1; k++)
        {
            for (int j = 0; j < columns - 1; j++)
            {
                if (arr[i, j] < arr[i, j + 1])
                {
                    int temp = arr[i, j];
                    arr[i, j] = arr[i, j + 1];
                    arr[i, j + 1] = temp;
                }
            }
        }
    }
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}




Console.Write("Введите размер массива (строки): ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите размер массива (колонки): ");
int columns = int.Parse(Console.ReadLine());
int[,] myArray = new int[rows,columns];
int [,] a = InputArray(myArray, rows, columns);
Console.WriteLine("Мой массив состоит из значений: ");
printArray(a, rows, columns);
findMin(myArray, rows, columns);
findMax(myArray, rows, columns);
Console.WriteLine("Сумма всех элементов массива равна: " + Sum(myArray, rows, columns));
Average(myArray, rows, columns);
Console.WriteLine("Нажмите любую клавишу для сортировки массива по убыванию");
Console.ReadLine();
sortArrayTwoDimensional(myArray, rows, columns);


