//Create a base class `Person` and derive a class `Student`. 
// Create an object of `Student`, upcast it to `Person`, and then downcast 
// it back to `Student`. Demonstrate how type casting works.

class Person
{
    public string Name { get; set; }

    public void ShowDetails()
    {
        Console.WriteLine($"Person: {Name}");
    }
}

class Student : Person
{
    public int StudentID { get; set; }

    public void ShowStudentDetails()
    {
        Console.WriteLine($"Student: {Name}, ID: {StudentID}");
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        Student student = new Student { Name = "John", StudentID = 1234 };

        Person person = student; 
        person.ShowDetails();

        Student downcastedStudent = (Student)person; 
        downcastedStudent.ShowStudentDetails();

    }
}
