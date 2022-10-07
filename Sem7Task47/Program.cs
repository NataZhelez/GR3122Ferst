//==========================================================
// # 47 Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
//=========================================================
// Считывание данных с консоли.
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Возращает цвет для консоли.
ConsoleColor GetColor(int colorNumb)
{
    colorNumb = colorNumb % 16;
    return ((ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor)))[colorNumb];
}

// Печать 2D массива.
void Print2DArr(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = GetColor(i * arr.GetLength(0) + j);
            Console.Write($"{Math.Round(arr[i, j], 2)}\t");
        }
        Console.WriteLine();
    }
    Console.ForegroundColor = ConsoleColor.White;
}


// Генерация случайного 2D массива.
double[,] Gen2DArr(int rows, int columns, int arrMin, int arrMax)
{
    double[,] arr = new double[rows, columns];
    Random rnd = new Random();
    if (arrMin > arrMax)
    {
        int temp = arrMax;
        arrMax = arrMin;
        arrMin = temp;
    }
    int range = arrMax - arrMin;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = arrMin + rnd.NextDouble() * range;
        }
    }
    return arr;
}

int rows = ReadData("Введите количество строк: ");
int columns = ReadData("Введите количество столбцов: ");
Print2DArr(Gen2DArr(rows, columns, 10, 100));