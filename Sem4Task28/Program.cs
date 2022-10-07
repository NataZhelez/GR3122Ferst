//====================================================
// # 28 Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.
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

// Метод вывода результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

long MultA(int numA)
{
    int i = 1;
    long sum = 1;
    while (i <= numA)
    {
        sum = sum * i;
        i++;
    }
    return sum;
}

int number = ReadData("Введите число : ");
long sum = MultA(number);
PrintResult("Произведение цифр от 1 до N  " + sum);