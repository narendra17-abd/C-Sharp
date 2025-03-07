
    class Vehicle
    {
        public string Type { get; set; }
        public decimal Speed { get; set; }
        
        public Vehicle(string type, decimal speed)
        {
            Type = type;
            Speed = speed;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"The {Type} has a speed of {Speed} ");
        }
    }

    class Car : Vehicle
    {
        public string Model { get; set; }
        public string Brand { get; set; }

        public Car(string type, decimal speed, string model, string brand) : base(type, speed)
        {
            Model = model;
            Brand = brand;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"The model is {Model} and brand is {Brand}");
        }
    }

    class Bike : Vehicle
    {
        public string Model { get; set; }
        public string Brand { get; set; }

        public Bike(string type, decimal speed, string model, string brand) : base(type, speed)
    {
            Model = model;
            Brand = brand;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"The model is {Model} and brand is {Brand}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Car", 1200, "Volvo", "12-VR");
            car.DisplayInfo();

            Bike bike = new Bike("Bike", 700, "Honda", "Shine");
            bike.DisplayInfo();
        }
    }
