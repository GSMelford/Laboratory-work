using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    class Painter
    {
        public static void Draw(IDraw draw)
        {
            draw.Draw();
        }
    }
}