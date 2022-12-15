using SAV_1.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAV_1.Algorithms
{
    public class InsertionSort
    {
        public static int Sort(List<Element> elements, Graphics graphics, int tk, int s)
        {
            int ICount = 0;
            int n = elements.Count;
            for (int i = 1; i < n; ++i)
            {
                ElementHelper.SelectedOne(elements[i], graphics, tk, s);
                int key = elements[i].Value;
                int j = i - 1;
                while (j >= 0 && elements[j].Value > key)
                {
                    ElementHelper.DrawSwap(elements[j], elements[j + 1], graphics, tk, s);
                    ElementHelper.ElementSwap(elements, j, j + 1);
                    j = j - 1;
                    ICount++;
                }
                elements[j + 1].Value = key;
                ICount++;
            }
            return ICount;
        }
    }
}
