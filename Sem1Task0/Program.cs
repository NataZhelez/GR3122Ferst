//=================================================================
// # 0 Напишите программу, которая на вход принимает число и
// выдаёт его квадрат ( чис ло умноженное на само себя).
//=================================================================
string? inputLine = Console.ReadLine();
if(inputLine != null)
{
  int inputNumber = int.Parse(inputLine);
  int outNumber = inputNumber*inputNumber;
  Console.WriteLine(outNumber);
}