internal class Program
{
    private static void Main(string[] args)
    {
        for (int i = 1; i <=256;  i++)
        {
            Console.WriteLine(i + " = " + (char)i);
            if (i  == 0)
            {
                Console.WriteLine("Please press ket to turn page");
                Console.ReadKey();
            }
        }

    }
}