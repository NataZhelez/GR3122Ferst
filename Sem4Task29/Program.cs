//====================================================
// # 29 Напишите программу, которая задаёт  массив 
// из 8 элементов и выводит их на экран
//====================================================

int ReadData(string line)
{
    // Выводим сообщение 
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

int[] GenArray(int arrayLength, int start, int stop)
{
    Random ren = new Random();
    int[] array = new int[arrayLength];

    for (int i = 0; i < arrayLength; i++)
    {
        array[i] = ren.Next(start, stop + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }

    Console.WriteLine(array[array.Length - 1]);
}

int arrayLength = ReadData("Введите длину массива: ");
int start = ReadData("Введите минимальное значение: ");
int stop = ReadData("Введите максимальное значение: ");

int [] array= GenArray(arrayLength, start, stop);
PrintArray(array);
