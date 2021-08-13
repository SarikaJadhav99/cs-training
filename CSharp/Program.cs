using System;

namespace CSharpAssign1
{
    class Arithmetic

    {
        int TwoNumbersAddition(int firstTerm, int secondTerm)
        {
            return firstTerm + secondTerm;
        }

        int TwoNumbersSubstraction(int firstTerm, int secondTerm)
        {
            return firstTerm - secondTerm;
        }

        int TwoNumbersMultiplication(int firstTerm, int secondTerm)
        {
            return firstTerm * secondTerm;
        }

        double TwoNumbersDivision(int firstTerm, int secondTerm)
        {
            return firstTerm / secondTerm;
        }
        static void Main(string[] args)
        {
          Arithmetic operation = new Arithmetic();

          Console.WriteLine("addition is " +operation.TwoNumbersAddition(11, 10));
          Console.WriteLine("substraction is " + operation.TwoNumbersSubstraction(11, 10));
          Console.WriteLine("multiplication is " + operation.TwoNumbersMultiplication(11, 10));
          Console.WriteLine("division is " + operation.TwoNumbersDivision(11, 10));
          Console.ReadLine();
        }
    }
}
