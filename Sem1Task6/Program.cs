//=================================================================
// # 6 Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
//=================================================================
string? inputLineA = Console.ReadLine();

if (inputLineA != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberR = inputNumberA % 2;

    if (inputNumberR == 0)
    {
        Console.WriteLine("чётное");
    }
    else
    if (inputNumberR == 1)
    {
        Console.WriteLine("нечётное");
    }
}