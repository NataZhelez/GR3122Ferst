//=============================================================
//# 20 Напишите программу, которая на вход принимает
// координаты двух точек  и находит расстояние между 
// ними в 2D пространстве.
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

// Метод, который посчитает расстояние между двумя точками
double CalkData(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
}

// Метод, который выведет данные
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Соберём данные
int x1 = ReadData("Введите x1: ");
int y1 = ReadData("Введите y1: ");
int x2 = ReadData("Введите x2: ");
int y2 = ReadData("Введите y2: ");


// Выводим результат
PrintResult(Math.Round(CalkData(x1, y1, x2, y2), 2).ToString());

