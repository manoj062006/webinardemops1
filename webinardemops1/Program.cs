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
             e.EmpID = 102;
             e.DisplayEmployeeDetails();
             Console.WriteLine(e.EmpID);
             Console.WriteLine(e.EmpName);
             e.DisplayEmployeeDetails();
            


            /* BaseA objBaseA = new BaseA();
            BaseB objBaseB = new BaseB();
            BaseC objBaseC = new BaseC();
            objBaseC.DisplayMessage();
            objBaseB.publicVariable = 10;*/


            /*
            Watch objWatch = new Watch();
            Console.WriteLine($"current time{Convert.ToString( objWatch.getTime())}");
            DateTime a= objWatch.setTime(DateTime.UtcNow);
            Console.WriteLine(a);
            */

            /* AbstractClassImplementation objAbs = new AbstractClassImplementation();
             int k= objAbs.AddTwoNumbers(10, 20);
             Console.WriteLine(k);
             int l = objAbs.Sum(30, 50);
             Console.WriteLine(l);
            */
            /*

            Console.WriteLine("the sum " + StaticClass.AddNumbers(30));
            Console.ReadKey();
            */
        }
    }
}
