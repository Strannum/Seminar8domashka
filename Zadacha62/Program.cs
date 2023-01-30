int[,] SpiralArray(int rows, int columns, int startNumberSpiral)
{
    int[,] returnSpiral = new int[rows, columns];
    int numberOfSpiral = startNumberSpiral;
    int count = 1; //Счетчик 
    int minRow = 0; // Индекс первой строки
    int maxRow = returnSpiral.GetLength(0) - 1; // Индекс последней строки
    int minColumn = 0;// Индекс первого столба
    int maxColumn = returnSpiral.GetLength(1) - 1;// Индекс последнего столба
    //-1 чтобы не выходить за пределы массива, отсчет же с 0.

    //Цикл, пока счетчик не будет равен длине массива
    while (
        count <= returnSpiral.Length)
    {
        //верхняя строка
        for (int i = minColumn; i <= maxColumn; i++)
        {
            returnSpiral[minRow, i] = numberOfSpiral++;
            count++;
        }
        minRow++;
        /* плюсуем потому что когда пойдем в обратном напрлении 
        minRow по сути станет maxRow то есть числом до которого пойдет отсчет
 */
        //Правый столбец
        for (int i = minRow; i <= maxRow; i++)
        {
            returnSpiral[i, maxColumn] = numberOfSpiral++;
            count++;
        }
        maxColumn--;
        //Нижняя строка
        for (int i = maxColumn; i >= minColumn; i--)
        {
            returnSpiral[maxRow, i] = numberOfSpiral++;
            count++;
        }
        maxRow--;
        //Левый столбик
        for (int i = maxRow; i >= minRow; i--)
        {
            returnSpiral[i, minColumn] = numberOfSpiral++;
            count++;
        }
        minColumn++;

    }
    return returnSpiral;

}

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

Console.Clear();
int[,] spiral = SpiralArray(8, 7, 10);
PrintArray(spiral); //spiral создалвал с помощью GetArray()
Console.WriteLine();
