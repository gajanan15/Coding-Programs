using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCodingQuestions
{
    internal class ConstructorChaining
    {
        public string Name;
        public int Salary;

        public ConstructorChaining() : this("Unknown", 0)
        {
            Console.WriteLine("Default Constructor");
        }

        public ConstructorChaining(string name) : this(name, 0)
        {
            Console.WriteLine("Constructor with Name");
        }   

        public ConstructorChaining(string name, int salary)
        {
            Name = name;
            Salary = salary;
            Console.WriteLine("Constructor with Name and Salary");
        }
    }
}
