//=============================================================
//# 21 Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними 
// в 3D пространстве.
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
double CalkData(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
}

// Метод, который выведет данные
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Соберём данные
int x1 = ReadData("Введите x1: ");
int y1 = ReadData("Введите y1: ");
int z1 = ReadData("Введите z1: ");
int x2 = ReadData("Введите x2: ");
int y2 = ReadData("Введите y2: ");
int z2 = ReadData("Введите z2: ");


// Выводим результат
PrintResult(Math.Round(CalkData(x1, y1, z1,  x2, y2, z2), 2).ToString());


