int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek); //0-6

switch (weekDay) //väärtus, mida kontrollitakse
{
    case 0:  // case 0: == if(weekday == 0)
        Console.WriteLine("It is sunday!");
        break;
        case 1:
        Console.WriteLine("It is monday!");
        break;
        case 2:
        Console.WriteLine("it is tuesday!");
        break;
        case 3:
        Console.WriteLine("It is wednesday!");
        break;
        case 4:
        Console.WriteLine("It is thursday!");
        break;
        case 5:
        Console.WriteLine("It is friday!");
        break;
        case 6:
        Console.WriteLine("it is saturday!");
        break;
    default:
        Console.WriteLine("Oops. Your calender must be broken.");
        break;
}

Console.WriteLine("Have a nice day");