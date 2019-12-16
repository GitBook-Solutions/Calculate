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
        public int Multiplication(int a, int b)
        {
            return a*b;
        }
        public int Division(int a, int b)
        {
            return a/b;
        }
    }
}
