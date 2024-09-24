using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello Yash!!");
        Console.WriteLine(WeekDays.Monday); // Monday
        Console.WriteLine(WeekDays.Tuesday); // Tuesday
        Console.WriteLine(WeekDays.Wednesday); // Wednesday
        Console.WriteLine(WeekDays.Thursday); // Thursday
        Console.WriteLine(WeekDays.Friday); // Friday
        Console.WriteLine(WeekDays.Saturday); // Saturday
        Console.WriteLine(WeekDays.Sunday); // Sunday
    }
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}