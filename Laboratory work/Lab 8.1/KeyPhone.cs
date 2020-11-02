using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8._2
{
    class KeyPhone : RotaryPhone
    {
        private char[] Symbols { get; } = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9','+','*','#'};
        protected override string EnterPhoneNumber()
        {
            while (true)
            {
                Console.Write("\nВведите номер: ");
                bool incorrect = false;
                string PhoneNumber = Console.ReadLine();
                foreach (char symbol in PhoneNumber)
                    for (int i = 0; i < 11; i++)
                    {
                        incorrect = true;
                        if (symbol == Symbols[i])
                        {
                            incorrect = false;
                            break;
                        }
                    }
                if (incorrect)
                {
                    Console.Write("Вы ввели страный номер. Попробуйте ещё раз.");
                    continue;
                }
                return PhoneNumber;
            }
        }
        public override void TakeCall(string PhoneNumber)
        {
            Console.WriteLine($"=> Входной вызов. Вам звонит этот номер:{EnterPhoneNumber()}");
        }
    }
}