Console.Write("What day is it?");
string day = Console.ReadLine();

switch(day.Trim().ToLower())
{
    case "monday":
        Console.WriteLine("Oh dear, 4 days till the weekend");
        break;
    case "tuesday":
        Console.WriteLine("Oh dear, 3 days till the weekend");
        break;
    case "wednesday":
        Console.WriteLine("Only 2 more days till the weekend");
        break;
    case "thursday":
        Console.WriteLine("Just one last day till the weekend");
        break;
    case "friday":
        Console.WriteLine("Its almost the weekend");
        break;
    case "saturday":
    case "sunday":
        Console.WriteLine("Its the weekend!");
        break;
    default;
        Console.WriteLine("I don't recognise that");
}
/*
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