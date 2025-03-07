// See https://aka.ms/new-console-template for more information
using MultipleInheritence;

Console.WriteLine("Hello, World!");
Developer developer = new Developer("John", 22);
developer.Dowork();

Tester tester = new Tester();
tester.Dowork();

Manager manager = new Manager("John Snow", 22);
manager.Dowork();
manager.Manage();
manager.DisplayInfo();