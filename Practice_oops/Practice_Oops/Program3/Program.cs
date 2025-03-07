class Program
{
    static void Main(string[] args)
    {
        Manager manager = new Manager("Narendra", 12000, 2000);
        manager.ShowDetails();
    }
}

class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public Employee(string name, decimal salary)
    {
        Name = name;
        Salary = salary;
    }
}

class Manager : Employee
{
    public decimal Bonus { get; set; }

    public Manager(string name, decimal salary, decimal bonus) : base(name, salary)
    {
        Bonus = bonus;
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Name : {Name}");
        Console.WriteLine($"Salary : {Salary}");
        Console.WriteLine($"Bonus : {Bonus}");
    }
}