using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class ServiceСenter
    {
        Random random = new Random();
        public void ReplaceWindows(ref Computer computer)
        {
            if (random.Next(1) == 1)
                computer.Windows = true;
            else
                computer.Windows = false;
        }

        public void ReplaceMotherboard(ref Computer computer)
        {
            if (random.Next(1) == 1)
                computer.Motherboard = true;
            else
                computer.Motherboard = false;
        }

        public void ReplacePowerSupply(ref Computer computer)
        {
            if (random.Next(1) == 1)
                computer.PowerSupply = true;
            else
                computer.PowerSupply = false;
        }

        public void AddRAM(ref Computer computer)
        {
            if (random.Next(1) == 1)
                computer.RAM = true;
            else
                computer.RAM = false;
        }

        public void ReplaceVideocard(ref Computer computer)
        {
            if (random.Next(1) == 1)
                computer.Videocard = true;
            else
                computer.Videocard = false;
        }

        public void SettingsApplication(ref Computer computer)
        {
            if (random.Next(1) == 1)
                computer.Application = true;
            else
                computer.Application = false;
        }

    }
}