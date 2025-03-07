////**Encapsulation Challenge**

////Create a `BankAccount` class where `balance` is a private field.Implement methods
////for `Deposit()` and `Withdraw()`, ensuring that withdrawal is only allowed if there 
////is a sufficient balance.Prevent direct modification of `balance` from outside the class.

//class BankAccount
//{
//    private decimal _balance;

//    public BankAccount(decimal balance=0)
//    {
//        if (balance < 0)
//        {
//            Console.WriteLine("Balance cannot be negative");
//        }
//        _balance = balance;
//    }

//    public void Withdraw(decimal amount)
//    {
//        if (amount > _balance)
//        {
//            Console.WriteLine("Insufficient Balance");
//        }
//        else if (amount <= 0)
//        {
//            Console.WriteLine("Please enter valid amount");
//        }
//        else
//        {
//            _balance = _balance - amount;
//            Console.WriteLine($"Reamining Balance {_balance}");
//        }
//    }

//    public void Deposit(decimal amount)
//    {
//        if (amount <= 0)
//        {
//            Console.WriteLine("Please enter valid amount");
//        }
//        else
//        {
//            _balance = _balance + amount;
//            Console.WriteLine($"Reamining Balance {_balance}");
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        BankAccount bankAccount = new BankAccount(15000);
//        bankAccount.Deposit(2000);
//        bankAccount.Withdraw(5000);
//        bankAccount.Withdraw(15000);
//    }
//}


//**Data Hiding with Properties**
//Create a `Student` class where `Name` and `RollNo` are private fields.
//Use properties to enforce validation (e.g., `RollNo` cannot be negative, `Name` cannot be empty).

//public class Student
//{
//    private string name;
//    private int rollNo;

//    public string Name
//    {
//        get { return name; }
//        set
//        {
//            if (string.IsNullOrWhiteSpace(value))
//                throw new ArgumentException("Name cannot be empty");
//            name = value;
//        }
//    }

//    public int RollNo
//    {
//        get { return rollNo; }
//        set
//        {
//            if (value < 0)
//                throw new ArgumentException("RollNo cannot be negative");
//            rollNo = value;
//        }
//    }
//    public Student(string name, int rollNo)
//    {
//        Name = name;
//        RollNo = rollNo;
//    }
//    public static void Main()
//    {
//        try
//        {
//            Student student = new Student("Naren", 6728);
//            Console.WriteLine($"Name: {student.Name}, RollNo: {student.RollNo}");
//            student.Name = "";
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//    }
//}



//**Constructor Overloading in a Library System**
//Implement a `Book` class with three different constructors: (1) Default constructor, 
//(2) Constructor with `Title` and `Author`, (3) Constructor with `Title`, `Author`, and `ISBN`. 
//Ensure each constructor initializes properties correctly.

//class Book
//{
//    public string Title { get; set; }
//    public string Author { get; set; }
//    public string ISBN { get; set; }

//    public Book()
//    {
//        Title = "N/A";
//        Author = "N/A";
//        ISBN = "N/A";
//    }
//    public Book(string title, string author)
//    {
//        Title = title;
//        Author = author;
//        ISBN = "N/A";
//    }
//    public Book(string title, string author, string iSBN)
//    {
//        Title = title;
//        Author = author;
//        ISBN = iSBN;
//    }
//    public void DisplayBookInfo()
//    {
//        Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}");
//    }

//    static void Main(string[] args)
//    {
//        Book book1 = new Book();
//        book1.DisplayBookInfo();

//        Book book2 = new Book("Harry Potter","JK Rowling");
//        book2.DisplayBookInfo();

//        Book book3 = new Book("Harry Potter", "JK Rowling","HP-101");
//        book3.DisplayBookInfo();

//    }
//}


// **Abstraction with Abstract Classes**

//Design an abstract class `Shape` with an abstract method `CalculateArea()`.
//    Create derived classes `Circle` and `Rectangle` that implement this method. 
//    Demonstrate abstraction by instantiating these classes.

//abstract class Shape
//{
//    public abstract void CalculateArea();
//}

//class Circle : Shape
//{
//    public double Radius { get; set; }
//    public Circle(double radius)
//    {
//        Radius = radius;
//    }

//    public override void CalculateArea()
//    {
//        double area = 3.14 * Radius * Radius;
//        Console.WriteLine($"The area of Circle is {area}");
//    }
//}

//class Rectangle : Shape
//{
//    public double Length { get; set; }
//    public double Breadth { get; set; }
//    public Rectangle(double length, double breadth)
//    {
//        Length = length;
//        Breadth = breadth;
//    }

//    public override void CalculateArea()
//    {
//        double area = Length * Breadth;
//        Console.WriteLine($"The area of Rectangle is {area}");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Circle circle = new Circle(4);
//        circle.CalculateArea();

//        Rectangle rectangle = new Rectangle(10, 20);
//        rectangle.CalculateArea();
//    }
//}

//**Method Overriding for a Vehicle System**

//Create a base class `Vehicle` with a method `Start()`. Override it in `Car`
//and `Bike` classes to provide specific implementations. Use the `override` 
//keyword and demonstrate polymorphism.

//class Vehicle
//{
//    public virtual void Start()
//    {
//        Console.WriteLine("The vehicle is about to start");
//    }
//}

//class Car : Vehicle
//{
//    public override void Start()
//    {
//        Console.WriteLine("The Car is about to start");
//    }
//}

//class Bike : Vehicle
//{
//    public override void Start()
//    {
//        Console.WriteLine("The Bike is about to start");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Car car = new Car();
//        car.Start();

//        Bike bike = new Bike();
//        bike.Start();
//    }
//}


//**Using Virtual Methods in Inheritance**
//Create a `Person` base class with a `GetDetails()` method. 
//Derive `Student` and `Teacher` classes that override `GetDetails()` to display 
//their respective properties. Call `GetDetails()` using a base class reference.

//class Person
//{
//    public string Name { get; set; }
//    public string RollNo { get; set; }

//    public Person(string name, string rollNo)
//    {
//        Name = name;
//        RollNo = rollNo;
//    }

//    public virtual void GetDetails()
//    {
//        Console.WriteLine($"Name : {Name}\nRollNo : {RollNo}");
//    }
//}

//class Student : Person
//{
//    public string Grade { get; set; }
//    public Student(string name, string rollNo, string grade) : base(name, rollNo)
//    {
//        Grade = grade;
//    }

//    public virtual void GetDetails()
//    {
//        Console.WriteLine($"Name : {Name}\nRollNo : {RollNo}\nGrade : {Grade}");
//    }
//}

//class Teacher : Person
//{
//    public string Subject { get; set; }
//    public Teacher(string name, string rollNo, string subject) : base(name, rollNo)
//    {
//        Subject = subject;
//    }

//    public virtual void GetDetails()
//    {
//        Console.WriteLine($"Name : {Name}\nRollNo : {RollNo}\nSubject : {Subject}");
//    }
//}


//class Program
//{
//    static void Main(string[] args)
//    {
//        Person student = new Student("Naren", "21h51a6728", "A");
//        student.GetDetails();

//        Person teacher = new Teacher("Naren", "21h51a6728", "Oops");
//        teacher.GetDetails();
//    }
//}


//class Calculator
//{
//    public void Add(int x, int y)
//    {
//        Console.WriteLine(x + y);
//    }
//    public void Add(int x, int y, int z)
//    {
//        Console.WriteLine(x + y + z);
//    }
//    public void Add(double x, double y)
//    {
//        Console.WriteLine(x + y);
//    }

//    static void Main(string[] args)
//    {
//        Calculator calculator = new Calculator();
//        calculator.Add(8, 7);
//        calculator.Add(8, 7, 6);
//        calculator.Add(8.7, 9.9);
//    }
//}

//interface IPlayable
//{
//    public abstract void Play();
//}

//class MusicPlayer : IPlayable
//{
//    public void Play()
//    {
//        Console.WriteLine("Music Player");
//    }
//}

//class VideoPlayer : IPlayable
//{
//    public void Play()
//    {
//        Console.WriteLine("Video Player");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        MusicPlayer musicPlayer = new MusicPlayer();
//        musicPlayer.Play();

//        VideoPlayer videoPlayer = new VideoPlayer();
//        videoPlayer.Play();
//    }
//}

//public interface IPrintable
//{
//    void Print();
//}
//public interface ISerializable
//{
//    void SaveToFile(string fileName);
//}


//public class Report : IPrintable, ISerializable
//{
//    public string Title { get; set; }
//    public string Content { get; set; }

//    public Report(string title, string content)
//    {
//        Title = title;
//        Content = content;
//    }

//    public void Print()
//    {
//        Console.WriteLine($"Printing Report: {Title}");
//        Console.WriteLine(Content);
//    }

//    public void SaveToFile(string fileName)
//    {
//        Console.WriteLine($"Saving report '{Title}' to file: {fileName}");
//    }
//}

//public class Program
// {
//     public static void Main()
//     {
//         Report report = new Report("  Report", "This is the content of the  report.");

//         report.Print();
//         report.SaveToFile("annual_report.txt");


//     }
// }


//public class User
//{
//    public string Username { get; set; }
//    public string Role { get; set; }

//    public User(string username, string role)
//    {
//        Username = username;
//        Role = role;
//    }
//    public virtual void AccessControl()
//    {
//        Console.WriteLine("Access control is not defined for this user.");
//    }
//}

//public class Admin : User
//{
//    public Admin(string username) : base(username, "Admin")
//    {
//    }

//    public override void AccessControl()
//    {
//        Console.WriteLine($"{Username} ({Role}) has access to all features.");
//    }
//}

//public class Customer : User
//{
//    public Customer(string username) : base(username, "Customer")
//    {
//    }

//    public override void AccessControl()
//    {
//        Console.WriteLine($"{Username} ({Role}) has limited access.");
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        // Creating users
//        User admin = new Admin("Alice");
//        User customer = new Customer("Bob");

//        // Access control demonstration
//        admin.AccessControl();
//        customer.AccessControl();
//    }
//}


class ComplexNumber
{
    public double real;
    public double imaginary;
    public ComplexNumber(double realNumber, double imaginaryNumber)
    {
        real = realNumber;
        imaginary = imaginaryNumber;
    }

    public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
    {
        double realnew = c1.real + c2.real;
        double imagiraynew = c1.imaginary + c2.imaginary;
        return new ComplexNumber(realnew, imagiraynew);

    }
    public override string ToString()
    {
        return $"{real}+j{imaginary}";
    }
}

public class Program
{
    public static void Main()
    {
        ComplexNumber c1 = new ComplexNumber(1, 2);
        ComplexNumber c2 = new ComplexNumber(2, 3);
        ComplexNumber c3 = c1 + c2;
        Console.WriteLine(c3);

    }
}