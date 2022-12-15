using SAV_1.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAV_1.Algorithms
{
    public class QuickSort
    {
        private List<Element> elements = new List<Element>();
        public static int Sort(List<Element> elements, Graphics graphics, int tk, int s)
        {
            int ICount = 0;
            int partition(List<Element> Myelements, int low, int high)
            {
                int pivot = Myelements[high].Value;
                ElementHelper.keepSelected(Myelements[high], graphics, tk, s);
                int i = (low - 1);
                for (int j = low; j <= high - 1; j++)
                {
                    ElementHelper.SelectedOne(Myelements[j], graphics, tk,s);
                    if (Myelements[j].Value < pivot)
                    {
                        i++;
                        ElementHelper.DrawSwap(Myelements[i], Myelements[j], graphics,tk,s);
                        ElementHelper.ElementSwap(Myelements, i, j);
                        ICount++;
                    }
                    else
                    {
                        ICount++;
                    }
                }
                ElementHelper.DrawSwap(elements[i + 1], elements[high], graphics,tk,s);
                ElementHelper.ElementSwap(elements, i + 1, high);
                return i + 1;
            }

            void quickSort(List<Element> Myelements, int low, int high)
            { 
                if (low < high)
                {
                    int pi = partition(Myelements, low, high);
                    quickSort(Myelements, low, pi - 1);
                    quickSort(Myelements, pi + 1, high);
                }
            }

            quickSort(elements, 0, elements.Count - 1);
            for (int i = 1; i<elements.Count; ++i)
            {
                ElementHelper.SelectedOne(elements[i], graphics, tk,s);
                int key = elements[i].Value;
                int j = i - 1;
                while (j >= 0 && elements[j].Value > key)
                {
                    ElementHelper.DrawSwap(elements[j], elements[j + 1], graphics,tk,s);
                    ElementHelper.ElementSwap(elements, j, j + 1);
                    j = j - 1;
                }
                elements[j + 1].Value = key;
            }
            return ICount;
        }
    }
}
