using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class Program
    {
        delegate void Operation(Computer computer);
        static void Main(string[] args)
        {
            ServiceCenter serviceCenter = new ServiceCenter();
            Computer computer = new Computer();
            Operation operation = null;

            Console.WriteLine("Сервисный центр.");
            while(true)
            {
                Console.Write("Переустановить Windows?\n[1] - Да\n[0] - Нет");
                if (CorrectInputIntRange(0, 1) == 1)
                    operation += serviceCenter.ReplaceWindows;

                Console.Write("Заменить материнскую плату?\n[1] - Да\n[0] - Нет");
                if (CorrectInputIntRange(0, 1) == 1)
                    operation += serviceCenter.ReplaceMotherboard;

                Console.Write("Заменить блок питания?\n[1] - Да\n[0] - Нет");
                if (CorrectInputIntRange(0, 1) == 1)
                    operation += serviceCenter.ReplacePowerSupply;

                Console.Write("Добавить оперативной памяти?\n[1] - Да\n[0] - Нет");
                if (CorrectInputIntRange(0, 1) == 1)
                    operation += serviceCenter.AddRAM;

                Console.Write("Заменить видеокарту?\n[1] - Да\n[0] - Нет");
                if (CorrectInputIntRange(0, 1) == 1)
                    operation += serviceCenter.ReplaceVideocard;

                Console.Write("Настроить программы?\n[1] - Да\n[0] - Нет");
                if (CorrectInputIntRange(0, 1) == 1)
                    operation += serviceCenter.SettingsApplication;

                //Выполнение задач
                if(operation !=null)
                    operation(computer);
                //----------------

                Console.WriteLine(computer);
                Console.Write("[1] - Выйти\n[0] - Eщё раз");
                if (CorrectInputIntRange(0, 1) == 1)
                    break;
            }
        }
        public static int CorrectInputIntRange(int min, int max)
        {
            int number;
            while (true)
            {
                Console.Write("\nВведите значение: ");
                if (!int.TryParse(Console.ReadLine(), out number) || number < min || number > max)
                    Console.WriteLine($"\nInvalid value. Check that it is in the range from {min} to {max}.");
                else
                    return number;
            }
        }
    }
}
