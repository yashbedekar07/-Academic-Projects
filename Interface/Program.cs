internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("This is an Interface Example..");
        //Single Interface obj
        Family f = new Father();
        f.family();

        Family f1 = new Son();
        f1.family();

        Family f3 = new Mother();
        f3.family();

        //Multiple-Interface Obj
        Demo d = new Demo();
        d.family();
        d.relations();


    }
}
//Interface Defination

public interface Family
{
    void family();
}

public interface Relations
{
    void relations();
}
public class Father : Family
{
    public void family()
    {
        Console.WriteLine("My Father Name is :David S Bedekar");
    }
}

public class Son : Family
{
    public void family()
    {
        Console.WriteLine("My Son Name is :Yash D Bedekar");
    }
}

public class Mother : Family
{
    public void family()
    {
        Console.WriteLine("My Mother Name is :Ashwini D Bedekar");
    }
}


//multiple interface
public class Demo : Family, Relations
{
    public void family()
    {
        Console.WriteLine("\nYash is my Son");
    }
    public void relations()
    {
        Console.WriteLine("David is my Father");
        Console.ReadKey();
    }

}