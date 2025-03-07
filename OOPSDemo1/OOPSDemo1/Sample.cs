using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo1
{
    class Sample
    {
        string name = "";
        public Sample()
        {
            Console.WriteLine("I am a default constructor");
        }
        public Sample(string companyName)
        {
            Console.WriteLine("Parameterised Constructor");
            name = companyName;
            Console.WriteLine(companyName);
        }
        public Sample(Sample sanpleobj)
        {
            Console.WriteLine("Copy Constructor");
            Console.WriteLine(sanpleobj.name);
        }
        static void Demo()
        {
            Console.WriteLine("I am static");
        }
    }
}
