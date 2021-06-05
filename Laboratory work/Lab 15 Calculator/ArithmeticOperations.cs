using System.Collections.Generic;
using System.Globalization;
using System.Windows;

namespace Lab_15_Calculator
{
    internal static class ArithmeticOperations
    {
        private static string _operation;
        private static readonly List<double> Operands = new List<double>();
        public static string GetResult(string operation, double operand)
        {
            string result = null;
            
            Operands.Add(operand);
            
            if(!string.IsNullOrEmpty(_operation))
            {
                switch (_operation)
                {
                    case "+":
                        Operands[0] += Operands[1];
                        result = Operands[0].ToString(CultureInfo.InvariantCulture);
                        Operands.RemoveAt(1);
                        break;
                    case "-":
                        Operands[0] -= Operands[1];
                        result = Operands[0].ToString(CultureInfo.InvariantCulture);
                        Operands.RemoveAt(1);
                        break;
                    case "*":
                        Operands[0] *= Operands[1];
                        result = Operands[0].ToString(CultureInfo.InvariantCulture);
                        Operands.RemoveAt(1);
                        break;
                    case "/":
                        if (Operands[1] == 0)
                        {
                            string temp = Operands[0].ToString(CultureInfo.InvariantCulture);
                            MessageBox.Show("Cannot be divisible by 0");
                            Reset();
                            return temp;
                        }
                        
                        Operands[0] /= Operands[1];
                        result = Operands[0].ToString(CultureInfo.InvariantCulture);
                        Operands.RemoveAt(1);
                        break;
                }
            }
            else
            {
                _operation = operation;
            }
              
            if (operation != "=")
            {
                _operation = operation;
            }
            else
            {
                Reset();
            }
              
            return result;
        }

        public static void Reset()
        {
            _operation = null;
            Operands.Clear();
        }
    }
}