
int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

if (weekDay == 0)
{
    Console.WriteLine("It is sunday, my dudes!");
}
else if (weekDay == 1)
{
    Console.WriteLine("It is monday, my dudes!");
}
else if (weekDay == 2)
{
    Console.WriteLine("It is tuesday, my dudes!");
}
else if (weekDay == 3)
{
    Console.WriteLine("It is wednesday, my dudes!");
}
else if (weekDay == 4)
{
    Console.WriteLine("It is Thursday, my dudes!");
}
else if (weekDay == 5)
{
    Console.WriteLine("It is friday, my dudes!");
}
else
{
    Console.WriteLine("It is saturday, my dudes!");
}
Console.WriteLine("Go and eat a breakfast");