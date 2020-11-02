using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8._2
{
    class SmartPhone : ColorPhone
    {
        private const bool TouchControl = true;
        private int MaxTouch { get; set; }
        private int QuantityCamera { get; set; }

        private int ChoiceCamera()
        {
            Console.WriteLine($"У Вас {QuantityCamera} камер. Какую камеру использовать?");
            int select = 0;
            while (true)
            {
                Console.Write("Введите номер камеры: ");
                if (!int.TryParse(Console.ReadLine(), out select) || select < 0 || select > QuantityCamera)
                    Console.WriteLine("\nВы ввели неправильное значение. Попробуйте ещё раз.\n");
                else
                    break;
            }
            return select;
        }
        private void CreatePhoto() => Console.WriteLine($"=> Вы сделали фото используя {ChoiceCamera()} камеру.");
        private void CreateVideo() => Console.WriteLine($"=> Вы записали видео используя {ChoiceCamera()} камеру.");
        public override void EnterData()
        {
            base.EnterData();
            while (true)
            {
                int temp;
                Console.Write("Введите количество одновременых нажатий на экран: ");
                if (!int.TryParse(Console.ReadLine(), out temp) || temp < 0)
                    Console.WriteLine("\nВы ввели неправильное значение. Попробуйте ещё раз.\n");
                else
                {
                    MaxTouch = temp;
                    break;
                }
            }
            while (true)
            {
                int temp;
                Console.Write("Ввидите количество камер: ");
                if (!int.TryParse(Console.ReadLine(), out temp) || temp < 0)
                    Console.WriteLine("\nВы ввели неправильное значение. Попробуйте ещё раз.\n");
                else
                {
                    QuantityCamera = temp;
                    break;
                }
            }
        }
        public override void PrintFunctions()
        {
            base.PrintFunctions();
            Console.WriteLine("[8] Сделать фото.");
            Console.WriteLine("[9] Снять видео.");
        }
        public override void SelectFunction(int funcNumber)
        {
            base.SelectFunction(funcNumber);
            if (funcNumber == 8)
                CreatePhoto();
            else if (funcNumber == 9)
                CreateVideo();
        }
    }
}