using System;
using System.Collections.Generic;
using System.Text;

namespace webinardemops1
{
    public abstract class AbstractClass
    {
        public abstract int AddTwoNumbers(int a, int b);

        public int Sum(int x,int y)
        {
            return x + y;
        }
         
    }
    public class AbstractClassImplementation    : AbstractClass
    {
        public override int AddTwoNumbers(int a, int b)
        {
            return a + b;
        }
    }
}
