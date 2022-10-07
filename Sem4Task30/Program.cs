//====================================================
// # 30 Напишите программу, которая выводит массив 
// из 8 элементов заполненный нулями и единицами 
// в случайном порядке
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

int[] GenArray(int arrayleng)
{
    int[] array = new int[arrayleng];
    Random ren = new Random();
    for (int i = 0; i < array.Length - 1; i++)
    {
        array[i] = ren.Next(0, 2);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }

Console.WriteLine(array[array.Length - 1]+", ");
}

int arrayleng = ReadData("Введите длину массива: ");
int [] array= GenArray(arrayleng);
PrintArray(array);
//либо
PrintArray(GenArray(ReadData("Введите длину массива: ")));
