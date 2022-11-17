using SAV_1.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SAV_1.Algorithms
{
    public class BubbleSort
    {
        private List<Element> elements = new List<Element>();

        public static void Sort(List<Element> elements, Graphics graphics, int tk, int s)
        {
            int n = elements.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (elements[j].Value > elements[j + 1].Value)
                    {
                        ElementHelper.DrawSwap(elements[j], elements[j + 1], graphics, tk,s);
                        ElementHelper.ElementSwap(elements, j, j + 1);
                        //Thread.Sleep(20);
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                ElementHelper.SelectedOne(elements[i],graphics, tk, s);
            }
        }
    }
}
