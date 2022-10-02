//=============================================================
//# 19 //Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
//=============================================================
// 
int ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// 
bool TestPalindrom(int number)
{
    if ((number / 10000 == number % 10) && (number / 1000) % 10 == (number / 10) % 10)
    {
        return true;
    }
    else
    {
        return false;
    }
}


// Метод, который выведет данные
void PrintResult(string line)

{
    Console.WriteLine(line);

}


int number = ReadData("Введите палиндром: ");

PrintResult(TestPalindrom(number) ? "да" : "нет");