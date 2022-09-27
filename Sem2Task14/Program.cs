//=================================================================
// #14  Напишите программу, которая  на вход принимает число
//  и проверяет, кратно ли оно одновременно 7 и 23.  
//=================================================================


string? inputLineA = Console.ReadLine();

if (inputLineA != null)
{
    int inputNumberA = int.Parse(inputLineA);


    if (inputNumberA % 7 == 0 && inputNumberA % 23 == 0)
    {
        Console.WriteLine("число кратно 7 и 23");
    }

    else
    {
        Console.WriteLine("Не кратно ");
    }

}
