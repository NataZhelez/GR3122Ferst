//=================================================================
// # 9 Напишите программу, которая выводит случайное число из отрезка [10,99]
// и показывает наибольшую цифру числа. 
//=================================================================

void MyVariant()
{
    Console.WriteLine("Метод 1");
    System.Random numberGenerator = new System.Random();
    // создали переменную и в оперативной памяти выбрали ей место

    int number = numberGenerator.Next(10, 100);
    // теперь создаём число

    Console.WriteLine(number);

    int ferstDigit = number / 10;
    int secondDigit = number % 10;

    // ввели еще переменные

    if (ferstDigit > secondDigit)
    {
        Console.WriteLine(ferstDigit);
    }
    else
    {
        Console.WriteLine(secondDigit);
    }
}

void CharVariant()

{
    // Вариант char
    Console.WriteLine("Метод 2");
    System.Random numberGenerator = new System.Random();
    // создали переменную и в оперативной памяти выбрали ей место

    int number = numberGenerator.Next(10, 100);
    // теперь создаём число

    Console.WriteLine(number);
    char[] charArray = number.ToString().ToCharArray();
    Console.WriteLine(((int)charArray[0] > (int)charArray[1]) ? charArray[0] : charArray[1]);
}


MyVariant();

CharVariant();