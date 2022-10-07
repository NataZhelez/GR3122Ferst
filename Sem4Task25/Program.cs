//====================================================
// # 25 Напишите цикл, который принимает на вход
// два числа ( А и В) и возводит число А в 
// натуральную степерь В.
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

long Pow(int A, int B)
{
    long res = 1;

    for (int i = 1; i <= B; i++)
    {
        res = res * A;
    }
    return res;
}

// Метод вывода результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}


int num1 = ReadData("Введите число А : ");
int num2 = ReadData("Введите число В : ");

PrintResult(num1 + " в степени " + num2 + " = " + Pow(num1,num2));


