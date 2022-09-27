//=================================================================
// #12  Напишите программу, которая  на вход принимает два числа и выводит
// является ли второе число кратным первому, если второе 
// число некратно первому, то программа выводит остаток от деления. 
//=================================================================

int inputNumberA = 0;
int inputNumberB = 0;
bool result = false;

ReadData();
ConculateData();
PrintData();


// Получаем два числа от пользователя
void ReadData()
{
    Console.Write("Введите первое число: ");
    string? inputLineA = Console.ReadLine();
    Console.Write("Введите второе число: ");
    string? inputLineB = Console.ReadLine();

    if (inputLineA != null && inputLineB != null)
    {
        inputNumberA = int.Parse(inputLineA);
        inputNumberB = int.Parse(inputLineB);
    }

}

//Определяем кратность чисел
void ConculateData()
{
    result = (inputNumberB % inputNumberA == 0);
}

//Выводим данные вычисления
void PrintData()
{
    if (result)
    {
        Console.WriteLine("Второе число кратно первому");
    }
    else
    {
        Console.WriteLine("Остаток от деления: " + inputNumberB % inputNumberA);
    }
}













//string? inputLineA = Console.ReadLine();
//string? inputLineB = Console.ReadLine();


//if (inputLineA != null && inputLineB != null)
//{
//  int inputNumberA = int.Parse(inputLineA);
//int inputNumberB = int.Parse(inputLineB);

// Превращаем в целое число
// Получение данных
//bool inputNumberR = (inputNumberB % inputNumberA == 0);
//Вычисление
//if (inputNumberR)
// {
//   Console.WriteLine("inputNumberB кратно inputNumberA");
//}
//else
//{
//  Console.WriteLine("не кратно, " + (inputNumberB % inputNumberA));
//}
//Вывод результата
//}



