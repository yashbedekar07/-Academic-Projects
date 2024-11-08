using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        //StringBuilder Example
        StringBuilder sb = new StringBuilder();
        sb.Append("Welcome Yash!!");
        sb.AppendLine("to C# !!");
        sb.AppendLine("My .Net Framework!!");
        Console.WriteLine(sb.ToString());
        Console.ReadKey();
    }
}