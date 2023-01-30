Console.Clear();
void PrintArray(int[,] inArray) //Отображение массива
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetArray(int m, int n, int minValue, int maxValue) //Создание массива
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

int[,] ArrayStringReduction(int[,] array) //Элементы в строке по порядку
{

    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int coll = 0; coll < array.GetLength(1); coll++)
        {
            for (int k = coll + 1; k < array.GetLength(1); k++)
            {
                if (array[row, k] > array[row, coll])
                {
                    int n = array[row, coll];
                    array[row, coll] = array[row, k];
                    array[row, k] = n;
                }
            }
        }
    }
    return array;
}

int[,] array = GetArray(5, 4, 1, 9);
PrintArray(array); 

Console.WriteLine("\nОт наибольшего к наименьшему в строке");
ArrayStringReduction(array);
PrintArray(array);