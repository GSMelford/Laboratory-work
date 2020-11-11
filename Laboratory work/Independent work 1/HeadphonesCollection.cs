using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Independent_work_1
{
    class HeadphonesCollection
    {
        private List<Headphones> headphonesCollection = new List<Headphones>();
        public void AddHeadphones(Headphones headphones)
        {
            headphonesCollection.Add(headphones);
        }
        public List<int> FindHeadphones(Headphones headphones)
        {
            List<int> headphonesFinded = new List<int>();
            headphonesFinded.Clear();

            for (int i = 0; i < headphonesCollection.Count; i++)
            {
                if (headphones.Colors != null)
                {
                    bool colorTrue = false;
                    for (int j = 0; j < headphonesCollection[i].Colors.Count; j++)
                    {
                        if (headphonesCollection[i].Colors[j] == headphones.Colors[0])
                        {
                            colorTrue = true;
                            break;
                        }
                    }
                    if (!colorTrue)
                        continue;
                }

                if (headphones.Year != 0)
                {
                    if (headphonesCollection[i].Year != headphones.Year)
                        continue;
                }

                if (headphones.Price != 0)
                {
                    if (headphonesCollection[i].Price != headphones.Price)
                        continue;
                }

                if (headphones.Brand != string.Empty)
                {
                    if (headphonesCollection[i].Brand != headphones.Brand)
                        continue;
                }
                headphonesFinded.Add(i);
            }
            return headphonesFinded;
        }
        public void PrintInfoHeadphones()
        {
            for (int i = 0; i < headphonesCollection.Count; i++)
                Console.WriteLine(headphonesCollection[i]);
        }
        public void PrintInfoHeadphones(List<int> headphonesNumber)
        {
            if (headphonesNumber.Count == 0)
                Console.WriteLine("Таких наушников нету.");
            foreach (var headphones in headphonesNumber)
                Console.WriteLine(headphonesCollection[headphones]);
        }
    }
}
