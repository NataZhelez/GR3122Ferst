//=================================================================
// # 13 Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
//=================================================================

string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    if (inputLine.Length >= 3)
    {
        char[] Array = inputLine.ToCharArray();
        Console.WriteLine(Array[2]);
    }

    else

    {
        Console.WriteLine("Такого числа нет ");
    }
}
