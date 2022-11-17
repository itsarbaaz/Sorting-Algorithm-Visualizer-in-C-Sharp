using SAV_1.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAV_1.Algorithms
{
    public class SelectionSort
    {
        private List<Element> elements = new List<Element>();

        public static void Sort(List<Element> elements, Graphics graphics,int tk,int s)
        {
            int n=elements.Count;
            for (int i = 0; i < n; i++)
            {
               
                int min_idx = i;
                for (int j = i; j < n; j++)
                {
                    ElementHelper.SelectedOne(elements[j], graphics, tk,s);
                    if (elements[j].Value < elements[min_idx].Value)
                    {
                        min_idx = j;
                    }
                    ElementHelper.SelectedOne(elements[min_idx], graphics, tk,s);
                }
                
                ElementHelper.DrawSwap(elements[i], elements[min_idx], graphics, tk,s);
                ElementHelper.ElementSwap(elements, i, min_idx);


                /*int min_idx = i;

                 for (int j = i+1; j < n; j++)
                 {
                     ElementHelper.SelectedOne(elements[min_idx], graphics, tk);
                     if (elements[j].Value < elements[min_idx].Value)
                     {
                         min_idx = j;
                     }

                 }

                 ElementHelper.DrawSwap(elements[i], elements[min_idx], graphics, tk);
                 ElementHelper.ElementSwap(elements, i, min_idx); */
            }
            for (int i = 0; i < n; i++)
            {
                ElementHelper.SelectedOne(elements[i], graphics, tk,s);
            }
        }
    }
}
