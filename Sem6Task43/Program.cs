//==========================================================
// # 43 Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//=========================================================
double ReadData(string line)
{   
    Console.Write(line);   
    //Считываем число и преобразуем из строки в double
    double x1= double.Parse(Console.ReadLine() ?? "0"); 
    //Возвращаем значение
    return x1;  
}
//Расчет координат точки пересечения
double[] Point(double k1, double b1, double k2, double b2)
{
    double[] outArr = new double[2];
    outArr[0] = (b1 - b2) / (k2 - k1);
    outArr[1] = outArr[0]*k1+b1;
    return outArr;
}
//Печатаем одномерный массив
void Print1DArray( string line, double[] array)
{
    Console.WriteLine(line);
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write(array[i]+",");
    }
    Console.WriteLine(array[array.Length-1]);
}

double k1 = ReadData("Введите коэффициент k1: ");
double b1 = ReadData("Введите коэффициент b1: ");
double k2 = ReadData("Введите коэффициент k2: ");
double b2 = ReadData("Введите коэффициент b2: ");
Print1DArray("Координаты точки пересечения: ", Point(k1, b1, k2, b2));