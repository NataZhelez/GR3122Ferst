//===============================================
// # 26 Напишите программу, которая принимает на вход
// число  и выдаёт количество цифр в числе.
//===============================================

/*
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


int CalculateDigits(int num)
{
    return (int)(Math.Log10(num) + 1);

}

int number = ReadData("Введите число : ");
int numberOfDigits = CalculateDigits(number);
PrintResult("Количество цифр в числе " + numberOfDigits);
*/



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


int DigitCount(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += 1;
        num = num / 10;
    }
    return sum;
}

int number = ReadData("Введите число : ");
int numberOfDigits = DigitCount(number);
PrintResult("Количество цифр в числе " + numberOfDigits);
