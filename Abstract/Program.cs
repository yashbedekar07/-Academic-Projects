internal class Program
{
    private static void Main(string[] args)
    {
        // Creating objects of concrete classes
        Parent parent = new Parent("David", 40);
        Child child = new Child("Yash", 23);

        // Calling methods
        parent.DisplayRole();         
        parent.AttendParentMeeting(); 

        child.DisplayRole(); 
        child.Play();        
    }
}
// Abstract class definition
abstract class Person
{
    // Properties
    public string? Name { get; set; }
    public int Age { get; set; }

    // Abstract method (no implementation)
    public abstract void DisplayRole();
}

// Concrete class derived from the abstract class
class Parent : Person
{
    // Constructor
    public Parent(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Implementation of the abstract method
    public override void DisplayRole()
    {
        Console.WriteLine($"{Name} is a parent.");
    }

    // Additional method specific to parents
    public void AttendParentMeeting()
    {
        Console.WriteLine($"{Name} is attending a parent meeting.");
    }
}

// Concrete class derived from the abstract class
class Child : Person
{
    // Constructor
    public Child(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Implementation of the abstract method
    public override void DisplayRole()
    {
        Console.WriteLine($"{Name} is a child.");
    }

    // Additional method specific to children
    public void Play()
    {
        Console.WriteLine($"{Name} is playing with friends.");
    }
}
