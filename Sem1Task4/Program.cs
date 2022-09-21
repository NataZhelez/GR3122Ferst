//=================================================================
// # 4 Напишите программу, которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел.
//=================================================================

string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
string? inputLineC = Console.ReadLine();

if (inputLineA != null && inputLineB != null && inputLineC != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);
    int inputNumberC = int.Parse(inputLineC);

    if (inputNumberA > inputNumberB && inputNumberA > inputNumberC)
        {
            Console.Write("max = ");
            Console.Write(inputNumberA);
        }
    else
    if (inputNumberB > inputNumberA && inputNumberB > inputNumberC)
        {
            Console.Write("max = ");
            Console.Write(inputNumberB);
        }
    else
    if (inputNumberC > inputNumberA && inputNumberC > inputNumberB)
        {
            Console.Write("max = ");
            Console.Write(inputNumberC);
        }
}
