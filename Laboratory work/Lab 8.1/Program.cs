using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в мир телефонов!");

            bool WorkPhone = true;
            while(WorkPhone)
            {
                Console.WriteLine("\nВаши телефоны: \n[1] Дисковый телефон. \n[2] Кнопочный телефон. \n[3] Телефон с черно-белым экраном. " +
                    "\n[4] Телефон с цветным экраном. \n[5] Смартфон. \n[0] Выход.\n");

                int select = 0;
                int funcNumber = 1;

                select = InputCheckRangeInt(5);

                switch (select)
                {
                    case 1:

                        RotaryPhone rotaryPhone = new RotaryPhone();
                        rotaryPhone.EnterData();
                        while(funcNumber!=0)
                        {
                            rotaryPhone.PrintFunctions();
                            Console.WriteLine("[0] Выход с телефона.");
                            funcNumber = InputCheckRangeInt(2);
                            if (funcNumber != 0)
                                rotaryPhone.SelectFunction(funcNumber);
                        }

                        break;
                    case 2:

                        KeyPhone keyPhone = new KeyPhone();
                        keyPhone.EnterData();
                        while (funcNumber != 0)
                        {
                            keyPhone.PrintFunctions();
                            Console.WriteLine("[0] Выход с телефона.");
                            funcNumber = InputCheckRangeInt(2);
                            if(funcNumber != 0)
                                keyPhone.SelectFunction(funcNumber);
                        }
                        
                        break;
                    case 3:

                        BlackWhitePhone blackWhitePhone = new BlackWhitePhone();
                        blackWhitePhone.EnterData();
                        while (funcNumber != 0)
                        {
                            blackWhitePhone.PrintFunctions();
                            Console.WriteLine("[0] Выход с телефона.");
                            funcNumber = InputCheckRangeInt(4);
                            if (funcNumber != 0)
                                blackWhitePhone.SelectFunction(funcNumber);
                        }
                        
                        break;
                    case 4:

                        ColorPhone colorPhone = new ColorPhone();
                        colorPhone.EnterData();
                        while (funcNumber != 0)
                        {
                            colorPhone.PrintFunctions();
                            Console.WriteLine("[0] Выход с телефона.");
                            funcNumber = InputCheckRangeInt(7);
                            if (funcNumber != 0)
                                colorPhone.SelectFunction(funcNumber);
                        }
                       
                        

                        break;
                    case 5:

                        SmartPhone smartPhone = new SmartPhone();
                        smartPhone.EnterData();
                        while (funcNumber != 0)
                        {
                            smartPhone.PrintFunctions();
                            Console.WriteLine("[0] Выход с телефона.");
                            funcNumber = InputCheckRangeInt(9);
                            if (funcNumber != 0)
                                smartPhone.SelectFunction(funcNumber);
                        }
                        
                        break;
                    case 0:
                        WorkPhone = false;
                        break;
                    default:
                        break;
                }
            }
        }
        static public int InputCheckRangeInt(int a)
        {
            int funcNumber;
            while (true)
            {
                Console.Write("\nВаш выбор: ");
                if (!int.TryParse(Console.ReadLine(), out funcNumber) || funcNumber < 0 || funcNumber > a)
                    Console.WriteLine("\nВы ввели неправильное значение. Попробуйте ещё раз.\n");
                else
                    break;
            }
            return funcNumber;
        }
    }
}