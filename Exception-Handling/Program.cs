internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("This an Exception Handling Example...");

        CheckAge(12);

        try
        {
            int a = 7;
            int b = 34;
            int x = a + b;
            Console.WriteLine(x);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            Console.WriteLine("The Code is Finish..");
        }
        Console.WriteLine("Something Went Wrong....");
    }

    public static void CheckAge(int age)
    {
        if (age < 18)
        {
            throw new ArithmeticException("Access not granted because Your not old enough");
        }
        else
        {
            Console.WriteLine("Acess granted..");
        }
        Console.ReadKey();
    }
}