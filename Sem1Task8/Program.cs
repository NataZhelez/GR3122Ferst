//=================================================================
// # 8 Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
//=================================================================

string? inputLineN = Console.ReadLine();
// на вход принимаем число N

if (inputLineN != null)
{
    int inputNumberN = int.Parse(inputLineN);
    // Превращаем в целое число

    int startNumber = 1;
    //Вводим дополнительную переменную 

    while (startNumber <= inputNumberN)
    // Теперь цикл
    {
        if (startNumber % 2 == 0)
        {
            Console.Write(startNumber + ", ");
            startNumber = startNumber + 1;
            // Между числами расстояние и пробел
        }
        else
        {
            startNumber = startNumber + 1;
            // 
        }

    }
}

