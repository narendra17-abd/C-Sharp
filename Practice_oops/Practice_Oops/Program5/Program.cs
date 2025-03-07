
//Create an interface `IMovable` with a method `Move()`. Implement this interface in a `Robot` 
//    class. Also, create a base class `Machine` with a method `Start()`. Have `Robot` inherit from 
//    `Machine` and implement `IMovable`.

class Program
{
    static void Main(string[] args)
    {
        Robots robot = new Robots();
        robot.Start();
        robot.Move();
    }
}

interface IMovale
{
    public abstract void Move();
}

class Machine
{
    public virtual void Start()
    {
        Console.WriteLine("The machine started moving");
    }
}

class Robots : Machine, IMovale
{
    public override void Start()
    {
        Console.WriteLine("The Robot started..........");
    }
    
    public void Move()
    {
        Console.WriteLine("The Robot is moving");
    }
}