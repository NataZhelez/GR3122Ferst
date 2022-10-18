//==================================================
// # 66  Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в
//  промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
//==================================================
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void PrintResult(int res)
{
    Console.WriteLine(res);
}

int SumRec(int numM, int numN)
{
    if (numM >= numN) return numN;
    int outLine = numM + SumRec(numM + 1, numN);
    return outLine;
}

int numM = ReadData("Введите число M: ");
int numN = ReadData("Введите число N: ");
int result = 0;
if (numM < numN) result = SumRec(numM, numN);
else result = SumRec(numN, numM);
PrintResult(result);