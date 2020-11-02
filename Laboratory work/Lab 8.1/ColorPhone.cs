using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8._2
{
    class ColorPhone : BlackWhitePhone
    {
        private int QuantityColor { get; set; }
        private bool TwoSIMCards { get; set; } = false;
        private string PhoneNumber2 { get; set; }

        public void SendMMS(string message, string PhoneNumber) => Console.WriteLine($"=> Вы отправили это ММС: {message}, на этот номер: {PhoneNumber}");
        public void ReceiveMMS(string receveMessage, string OtherPhoneNumber) => Console.WriteLine($"=> Вам прпишла эта ММС: {receveMessage}, от этого номера {OtherPhoneNumber}");
        public override void Call(string PhoneNumber) => Console.WriteLine($"=> Вызов с этого номера {PhoneNumber} на этот номер: {EnterPhoneNumber()}.");
        private void CallTwoSim()
        {
            //если у пользователя две симки то у него запросят с кой позвонить
            if (TwoSIMCards)
            {
                int select = 0;

                Console.WriteLine("С какой сим-карты Вы будите звонить?");
                while (true)
                {
                    Console.Write("[1] Первая. \n[2] Вторая. \nВаш выбор: ");
                    if (!int.TryParse(Console.ReadLine(), out select) || select < 1 || select > 2)
                        Console.WriteLine("\nВы ввели неправильное значение. Попробуйте ещё раз.\n");
                    else
                        break;
                }

                switch (select)
                {
                    case 1:
                        Call(PhoneNumber);
                        break;
                    case 2:
                        Call(PhoneNumber2);
                        break;
                    default:
                        break;
                }

            }
            else //если нету, то позвонит с первой
                Call(PhoneNumber);
        }
        public override void EnterData()
        {
            base.EnterData();
            while (true)
            {
                int temp;
                Console.Write("Ввидите количество цветов экрана: ");
                if (!int.TryParse(Console.ReadLine(), out temp) || temp < 0)
                    Console.WriteLine("\nВы ввели неправильное значение. Попробуйте ещё раз.\n");
                else
                {
                    QuantityColor = temp;
                    break;
                }
            }
            while (true)
            {
                int temp;
                Console.Write("Введите сколько у вас сим-карт: ");
                if (!int.TryParse(Console.ReadLine(), out temp) || temp < 1 || temp > 2)
                    Console.WriteLine("\nВы ввели неправильное значение. Попробуйте ещё раз.\n");
                else
                {
                    if (temp == 2)
                    {
                        TwoSIMCards = true;
                        Console.WriteLine("Нам нужен второй номер телефона.");
                        PhoneNumber2 = EnterPhoneNumber();
                    }
                    break;
                }
            }
        }
        public override void PrintFunctions()
        {
            base.PrintFunctions();
            Console.WriteLine("[5] Отправить ММС.");
            Console.WriteLine("[6] Принять ММС.");
            Console.WriteLine("[7] Выбор сим-карты для звонка.");
        }
        public override void SelectFunction(int funcNumber)
        {
            base.SelectFunction(funcNumber);
            if (funcNumber == 5)
            {
                Console.WriteLine("Ввидите название ММС: ");
                SendMMS(Console.ReadLine(), EnterPhoneNumber());
            }
            else if (funcNumber == 6)
            {
                Console.WriteLine("Ввидите чужое название ММС: ");
                ReceiveMMS(Console.ReadLine(), EnterPhoneNumber());
            }
            else if (funcNumber == 7)
                CallTwoSim();
        }
    }
}