using System;
using System.Collections.Generic;
using System.Text;

namespace webinardemops1
{
    public class BaseA
    {
        int privateVariable { get; set; }
        protected int protectedVariable { get; set; }
        public int publicVariable { get; set; }
        

        public BaseA()
        {
            privateVariable = 20;
            publicVariable = 5;
            protectedVariable = 10;

            Console.WriteLine("constructor of BaseA");
            Console.WriteLine(publicVariable + " " + protectedVariable);

        }
        public void DisplayMessage()
        {
            Console.WriteLine("Welcome");
        }
    }

    public class BaseB : BaseA
    {
        

       // protectedVariable =10;
        public BaseB()
        {
            protectedVariable = 20;
            publicVariable = 22;

            Console.WriteLine("constructor of BaseB");
            Console.WriteLine(publicVariable + " " + protectedVariable);
        }
    }
    public class BaseC  : BaseB
    {
        public BaseC()
        {
            protectedVariable = 30;
            publicVariable = 33;
            Console.WriteLine("constructor of BaseC");
            Console.WriteLine(publicVariable+ " " + protectedVariable);

        }

    }


     
    /*

    public class Inheritance
    {


    }*/
}
