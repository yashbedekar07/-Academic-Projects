internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Addition of Two Numbers...");

        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        
        int result = AddNumbers(num1, num2);

        // Display the result
        Console.WriteLine($"The sum of {num1} and {num2} is: {result}");

        // Keep the console window open
        Console.ReadLine();

    }

    static int AddNumbers(int x, int y)
    {
        return x + y;

    }
}

