//=================================================================
// #11 Напишите программу, которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа. 
//=================================================================


int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int ferstDigit = number / 100;
int secondDigit = number % 10;

Console.WriteLine(ferstDigit * 10 + secondDigit);

