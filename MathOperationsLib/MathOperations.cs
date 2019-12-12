using System;

namespace MathOperationsLib
{
    public class MathOperations:IMathOperations
    {
        public int Addition(int a, int b)
        {
            return a+b;
        }
        public int Substraction(int a, int b)
        {
            return a-b;
        }
    }
}
