//=============================================================
//# 22 Напишите программу, которая принимает на вход
//число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//=============================================================
// Метод, который введет координаты точек
int ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Формируем верх таблицы
string LineNumbers(int numberN, int pow)
{
    int i = 1;
    string outLine = string.Empty;
    while (i < numberN)
    {
        outLine = outLine + Math.Pow(i, pow) + "\t";
        ++i;
    }
    outLine = outLine + Math.Pow(numberN, pow);
    return outLine;
}

// Метод, который выведет данные
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Соберём данные
int num = ReadData("Введите число N: ");


// Выводим результат
PrintResult(LineNumbers(num, 1));
PrintResult(LineNumbers(num, 2));