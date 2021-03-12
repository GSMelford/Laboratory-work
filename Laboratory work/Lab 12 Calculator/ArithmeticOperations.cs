using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12_Calculator
{
    static class ArithmeticOperations
    {
        private static string Operation;
        private static List<double> Operands = new List<double>();
        public static string GetResult(string operation, double operand)
        {
            string result = null;
            Operands.Add(operand);
            if(!string.IsNullOrEmpty(Operation))
            {
                switch (Operation)
                {
                    case "+":
                        Operands[0] += Operands[1];
                        result = Operands[0].ToString();
                        Operands.RemoveAt(1);
                        break;
                    case "-":
                        Operands[0] -= Operands[1];
                        result = Operands[0].ToString();
                        Operands.RemoveAt(1);
                        break;
                    case "*":
                        Operands[0] *= Operands[1];
                        result = Operands[0].ToString();
                        Operands.RemoveAt(1);
                        break;
                    case "/":
                        Operands[0] /= Operands[1];
                        result = Operands[0].ToString();
                        Operands.RemoveAt(1);
                        break;
                    default:
                        break;
                }
            }
            else
                Operation = operation;

            if (operation != "=")
                Operation = operation;
            else
                Reset();

            return result;
        }
        public static void Reset()
        {
            Operation = null;
            Operands.Clear();
        }
    }
}
