using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class Computer
    {
        public bool Windows { get; set; } = true;
        public bool Motherboard { get; set; } = true;
        public bool PowerSupply { get; set; } = true;
        public bool RAM { get; set; } = true;
        public bool Videocard { get; set; } = true;
        public bool Application { get; set; } = true;

        public override string ToString() =>
            $"\nПереустановка Windows: \t{Windows}\nЗамена материнской платы: \t{Motherboard}" +
            $"\nЗамена блока питания: \t{PowerSupply}\nДобавление оперативной памяти: \t{RAM}\nЗамена видеокарты: \t{Videocard}" +
            $"\nНастройка программ: \t{Application}\n";
    }
}
