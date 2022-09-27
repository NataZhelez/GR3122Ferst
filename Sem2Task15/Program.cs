//=================================================================
// # 15 Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
//=================================================================

string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputDayOfWeek = int.Parse(inputLine);

    if (inputDayOfWeek == 6 || inputDayOfWeek == 7)
    {
        Console.WriteLine("Выходной день");
    }
    else
    {
        Console.WriteLine("Будний день");
    }

}


