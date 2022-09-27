//=================================================================
// # 10 Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.
//=================================================================

string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    if (inputLine.Length == 3)
    {
        char[] Array = inputLine.ToCharArray();
        Console.WriteLine(Array[1]);
    }

    else

    {
        Console.WriteLine("Число не трёхзначное");
    }
}
