Console.Write("What day is it?");
string day = Console.ReadLine();


if (day.ToUpper().Trim() == "MONDAY")
{
    Console.WriteLine("Oh dear, 4 days till the weekend");
}
else if(day.ToUpper().Trim() == "TUESDAY")
{
    Console.WriteLine("Oh dear, 3 days till the weekend");
}
else if (day.ToUpper().Trim() == "WEDNESDAY")
{
    Console.WriteLine("Only 2 more days till the weekend");
}
else if (day.ToUpper().Trim() == "THURSDAY")
{
    Console.WriteLine("Just one last day till the weekend");
}
else if (day.ToUpper().Trim() == "FRIDAY")
{
    Console.WriteLine("Its the weekend!");
}
else if (day.ToUpper().Trim() == "SATURDAY")
{
    Console.WriteLine("Oh well, it will be soon enough");
}