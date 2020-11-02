using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8._2
{
    class BlackWhitePhone : KeyPhone
    {
        private char[] Symbols { get; } = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9','+', '*', '#','q','w','e','r','t','y','u','i','o','p','[',']','a','s','d','f','g',
        'h','j','k','l',';','\'','z','x','c','v','b','n','m',',','.','/' };
        private int Width { get; set; }
        private int Height { get; set; }
        private double PhysicalSize { get; set; }
        private string ColorDevise { get; set; }
        public void SendSMS(string message, string PhoneNumber) => Console.WriteLine($"=> Вы отправили это сообщение: {message}, на этот номер: {PhoneNumber}");
        public void ReceiveSMS(string receveMessage, string OtherPhoneNumber) => Console.WriteLine($"=> Вам прпишло это сообщение: {receveMessage}, от этого номера: {OtherPhoneNumber}");
        public override void EnterData()
        {
            base.EnterData();
            while (true)
            {
                int temp;
                Console.Write("Ввидите ширину экрана: ");
                if (!int.TryParse(Console.ReadLine(), out temp) || temp < 0)
                    Console.WriteLine("\nВы ввели неправильное значение. Попробуйте ещё раз.\n");
                else
                {
                    Width = temp;
                    break;
                }    
            }
            while (true)
            {
                int temp;
                Console.Write("Ввидите высоту экрана: ");
                if (!int.TryParse(Console.ReadLine(), out temp) || temp < 0)
                    Console.WriteLine("\nВы ввели неправильное значение. Попробуйте ещё раз.\n");
                else
                {
                    Height = temp;
                    break;
                }
            }
            while (true)
            {
                double temp;
                Console.Write("Ввидите физичиский размер экрана: ");
                if (!double.TryParse(Console.ReadLine(), out temp) || temp < 0)
                    Console.WriteLine("\nВы ввели неправильное значение. Попробуйте ещё раз.\n");
                else
                {
                    PhysicalSize = temp;
                    break;
                }
            }

            Console.Write("Ввидите цвет телефона: ");
            ColorDevise = Console.ReadLine();
        }
        public override void PrintFunctions()
        {
            base.PrintFunctions();
            Console.WriteLine("[3] Отправить СМС.");
            Console.WriteLine("[4] Принять СМС.");
        }
        public override void SelectFunction(int funcNumber)
        {
            base.SelectFunction(funcNumber);
            if (funcNumber == 3)
            {
                Console.Write("Ввидите сообщение: ");
                SendSMS(Console.ReadLine(), EnterPhoneNumber());
            }  
            else if(funcNumber == 4)
            {
                Console.Write("Ввидите чужое сообщение: ");
                ReceiveSMS(Console.ReadLine(), EnterPhoneNumber());
            }
        }
    }
}