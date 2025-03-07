using MultipleInheritence.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritence
{
    class Person
    {
        protected string Name { get; set; }
        protected int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name : {Name}, Age : {Age}");
        }
    }
    internal class Student(int id, string domain)
    {
        public int StudentId { get; } = id;
        public string Domain { get; } = domain;
        public virtual void DisplayStudentInfo()
        {
            Console.WriteLine($"Student Id : {StudentId} , Domain : {Domain}");
        }
    }

    class Developer : IWork
    {
        public Developer(string name, int age)
        {

        }
        public void Dowork()
        {
            Console.WriteLine("Developer is writing the code ");
        }
    }

    class Tester : IWork
    {
        public void Dowork()
        {
            Console.WriteLine("Tester is testing the code ");
        }
    }

    class Manager : Person, IWork, IManage
    {
        public Manager(string name, int age) : base(name, age)
        {
        }

        public void Dowork()
        {
            Console.WriteLine("Manager is working with clients ");
        }

        public void Manage()
        {
            Console.WriteLine("Manager is managing the team ");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
        }
    }
}
