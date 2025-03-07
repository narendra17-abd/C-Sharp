//Create two interfaces `IFlyable` and `ISwimmable` with methods `Fly()` and `Swim()`, 
//respectively. Implement these interfaces in a class `Duck` to exhibit both behaviors.

interface IFlyable
{
    public abstract void Fly();
}

interface ISwimmable
{
    public abstract void Swim();
}

class Duck : IFlyable, ISwimmable
{
    public virtual void Fly()
    {
        Console.WriteLine("The duck can fly");
    }

    public virtual void Swim()
    {
        Console.WriteLine("The duck can swim");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Duck duck = new Duck();
        duck.Fly();
        duck.Swim();
    }
}