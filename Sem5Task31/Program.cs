//====================================================
// # 31 Задайте массив из 12 элементов, зполненный
// случайными числами из промежутка [-9,9]. Найдите сумму
// отрицательных и положительных элементов массива.
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
// Универсальный метод генерации и заполнения массива
int[] FillArray(int num, int downBorder, int topBorder)
{
    //Генератор случайных чисел
    Random numSintesator = new Random();
    // Создаём массив
    int[] arr = new int[num];

    if (downBorder < topBorder)
    {

        // Заполняем массив
        for (int i = 0; i < arr.Length - 1; i++)
        {
            arr[i] = numSintesator.Next(downBorder, topBorder + 1);
        }
    }
    //Возвращаем рузультат
    return arr;
}
//Печатаем одномерный массив
void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

int[] NegotivPosittivSums(int[] arr)
{
    int[] sums = new int[2];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sums[0] += arr[1];
        }
        else
        {
            sums[1] += arr[i];
        }
    }
    return sums;
}

// Метод вывода результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}


int arrayLength = ReadData("Введите длину массива: ");
int downBorder = ReadData("Введите нижнюю границу заполнения массива: ");
int topBorder = ReadData("Введите верхнюю границу заполнения массива: ");
int[] imputArray = FillArray(arrayLength, downBorder, topBorder);
PrintArr(imputArray);
int[] sumArr = NegotivPosittivSums(imputArray);
PrintResult("Сумма > 0:  " + sumArr[0] +  "Сумма < 0: " + sumArr[1]);
PrintArr(sumArr);


