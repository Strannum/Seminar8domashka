int[,,] GetThirdArray(int x, int y, int z, int minValue, int maxValue) //создание трехмерного массива
{
    int[,,] result = new int[x, y, z];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            {
                result[i, j, k] = new Random().Next(minValue, maxValue);
            }
        }
    }
    return result;
}

void PrintArrayThird(int[,,] inArray) //Отображение трехмерного массива
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]} ({i}, {j}, {k}) ");
            }
            Console.WriteLine();

        }
        Console.WriteLine();
    }
}
Console.WriteLine("-----------------------\nЗадача №60\nТрехмерные массивы\n");
int[,,] arrayThird = GetThirdArray(4, 4, 4, 10, 100); //Трехмерный массив
PrintArrayThird(arrayThird);                          //Отображение трехмерного массива