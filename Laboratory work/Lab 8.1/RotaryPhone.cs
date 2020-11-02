using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8._2
{
    class RotaryPhone
    {
        protected string PhoneNumber { get; set; }
        private char[] Symbols { get; } = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        protected virtual string EnterPhoneNumber()
        {
            while (true)
            {
                Console.Write("\nВведите номер: ");
                bool invalid = false;
                string PhoneNumber = Console.ReadLine();
                foreach (char symbol in PhoneNumber)
                    if (!Symbols.Contains(symbol))
                    {
                        invalid = true;
                        break;
                    }
                if (invalid)
                {
                    Console.Write("Некорректный ввод. Попробуйте снова. ");
                    continue;
                }
                return PhoneNumber;
            }
        }
        public virtual void Call(string PhoneNumber) => Console.WriteLine($"=> Вы звоните на этот номер: {EnterPhoneNumber()}.");
        public virtual void TakeCall(string PhoneNumber) => Console.WriteLine("=> Входной звонок.");
        public virtual void EnterData()
        {
            Console.WriteLine("\nНам нужен ваш номер телефона.\n");
            PhoneNumber = EnterPhoneNumber();
        }
        public virtual void PrintFunctions()
        {
            Console.WriteLine("\nФункции телефона: ");
            Console.WriteLine("[1] Позвонить. (Основной номер)");
            Console.WriteLine("[2] Принять вызов.");
        }
        public virtual void SelectFunction(int funcNumber)
        {
            if (funcNumber == 1)
                Call(PhoneNumber);
            else if(funcNumber == 2)
                TakeCall(PhoneNumber);
        }
    }
}