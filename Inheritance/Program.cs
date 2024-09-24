internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("This is an Example of Inheritance..");

        // Creating an instance of the base class
        Animal myAnimal = new Animal();
        myAnimal.Eat();   // Output: Animal is eating
        myAnimal.Sleep(); // Output: Animal is sleeping

        Console.WriteLine();

        // Creating an instance of the derived class
        Dog myDog = new Dog();
        myDog.Eat();      // Output: Animal is eating (inherited from base class)
        myDog.Sleep();    // Output: Animal is sleeping (inherited from base class)
        myDog.Bark();     // Output: Dog is barking (specific to Dog class)

        Console.ReadLine();
    }
}

class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }

    public void Sleep()
    {
        Console.WriteLine("Animal is sleeping");
    }
}

// Derived class (inherits from Animal)
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}