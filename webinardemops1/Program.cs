using System;

namespace webinardemops1
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Hello World!");

            Employee e = new Employee(101, "kedar");
            e.DisplayEmployeeDetails();
            Console.ReadLine();
        }
    }
}
