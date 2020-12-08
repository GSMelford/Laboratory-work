using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class ServiceCenter
    {
        Random random = new Random();

        public delegate void Operation(Computer computer);
        public void ReplaceWindows(Computer computer)
        {
            if (random.Next(2) == 1)
                computer.Windows = true;
            else
                computer.Windows = false;
        }

        public void ReplaceMotherboard(Computer computer)
        {
            if (random.Next(2) == 1)
                computer.Motherboard = true;
            else
                computer.Motherboard = false;
        }

        public void ReplacePowerSupply(Computer computer)
        {
            if (random.Next(2) == 1)
                computer.PowerSupply = true;
            else
                computer.PowerSupply = false;
        }

        public void AddRAM(Computer computer)
        {
            if (random.Next(2) == 1)
                computer.RAM = true;
            else
                computer.RAM = false;
        }

        public void ReplaceVideocard(Computer computer)
        {
            if (random.Next(2) == 1)
                computer.Videocard = true;
            else
                computer.Videocard = false;
        }

        public void SettingsApplication(Computer computer)
        {
            if (random.Next(2) == 1)
                computer.Application = true;
            else
                computer.Application = false;
        }

    }
}