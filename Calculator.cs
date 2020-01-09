using System;
using Operations;

namespace MainCalc
{
    public class Calculator
    {
        public int solution;
        public int Add(int a, int b)
        {
            solution = Addition.Add(a, b);
            return solution;
        }
        public int Minus(int a, int b)
        {
            solution = Subtraction.Minus(a, b);
            return solution;
        }
        public int Square(int a)
        {
            solution = Squared.Square(a);
            return solution;
        }
        public int Multiply(int a, int b)
        {
            solution = a * b;
            return solution;
        }
        public int Cube(int a)
        {
            solution = a * a * a;
            return solution;
        }
    }
}
