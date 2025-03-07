
class Vehicle
{
    public string Brand { get; set; }
    public decimal Speed { get; set; }

    public Vehicle(string brand, decimal speed)
    {
        Brand = brand;
        Speed = speed;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"The brand is {Brand}");
        Console.WriteLine($"The speed is {Speed}");
    }
}

class Car : Vehicle
{
    public string Model { get; set; }
    public Car(string brand, decimal speed, string model) : base(brand, speed)
    {
        Model = model;
    }
    public void Display()
    {
        base.DisplayInfo();
        Console.WriteLine($"The model is {Model}");
    }
}

class Bike : Vehicle
{
    public string Model { get; set; }
    public Bike(string brand, decimal speed, string model) : base(brand, speed)
    {
        Model = model;
    }
    public void Display()
    {
        base.DisplayInfo();
        Console.WriteLine($"The model is {Model}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("Volov", 1200,"12-v8");
        car.DisplayInfo();
        car.Display();

        Bike bike = new Bike("Suzuki", 900, "FZ");
        bike.DisplayInfo();
        bike.Display();
    }
}