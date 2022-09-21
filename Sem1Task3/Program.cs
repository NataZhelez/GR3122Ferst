//=================================================================
// # 3 Напишите программу, которая будет выдавать название дня недели по заданному номеру
//=================================================================

string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputDayOfWeek = int.Parse(inputLine);


    //     string[] dayOfWeerk = new string[7];
    //     dayOfWeerk[0] = "Понедельник";
    //     dayOfWeerk[1] = "Вторник";
    //     dayOfWeerk[2] = "Среда";
    //     dayOfWeerk[3] = "Четверг";
    //     dayOfWeerk[4] = "Пятница";
    //     dayOfWeerk[5] = "Суббота";
    //     dayOfWeerk[6] = "Воскресенье";

    //     if (inputDayOfWeek > 7 || inputDayOfWeek < 1)
    //     {
    //         Console.WriteLine("Такого дня нет");
    //     }
    //     else
    //     {
    //         Console.WriteLine(dayOfWeerk[inputDayOfWeek - 1]);
    //     }

    string outdayOfweek = string.Empty;//""

    // switch (inputDayOfWeek)
    // {
    //     case 1: outdayOfWeerk = "Понедельник"; break;
    //     case 2: outdayOfWeerk = "Вторник"; break;
    //     case 3: outdayOfWeerk = "Среда"; break;
    //     case 4: outdayOfWeerk = "Четверг"; break;
    //     case 5: outdayOfWeerk = "Пятница"; break;
    //     case 6: outdayOfWeerk = "Суббота"; break;
    //     case 7: outdayOfWeerk = "Воскресенье"; break;
    //     default: outdayOfWeerk = "Такого дня нет"; break;
    // }

    outdayOfweek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(inputDayOfWeek));

    Console.WriteLine(outdayOfweek);


}
