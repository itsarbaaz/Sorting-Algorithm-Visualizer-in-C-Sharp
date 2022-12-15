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
    public class MergeSort
    {
        
        public static List<Element> myElements1 = new List<Element>();
        public static List<Element> myElements2 = new List<Element>();
        public static List<Element> myElements = new List<Element>();

        public static int Sort(List<Element> elements, Graphics graphics, int tk, int s)
        {
            int ICount = 0;
            int n=elements.Count;
            List<Element> MyMergeSort(List<Element> myElements, Graphics myGraphics, int myTk, int low, int high)
            {
                int l = low;
                int h = high;
                if (l >=h)
                {
                   return myElements;
                }
                int mid = (l + h) / 2;
                ElementHelper.SelectedOne(myElements[mid], myGraphics, myTk,s);
                Thread.Sleep(s);
                MyMergeSort(myElements, myGraphics, myTk, l, mid);
                MyMergeSort(myElements, myGraphics, myTk, mid + 1, h);
                
                int end_lo = mid;
                int start_hi = mid + 1;
                while ((l<=end_lo) && (start_hi<=h))
                {   ICount++;
                    if (myElements[l].Value < myElements[start_hi].Value)
                    {
                        ElementHelper.SelectedOne(myElements[l], myGraphics, myTk, s);
                        Thread.Sleep(s);
                        l++;
                        ICount++;
                    }
                    else
                    {   
                        for(int k=start_hi-1; k>=l;k--)
                        {
                            
                            ElementHelper.DrawSwap(myElements[k], myElements[k+1], graphics, tk,s);
                            ElementHelper.ElementSwap(myElements, k, k+1);
                            ICount++;
                        }
                       
                        end_lo++;
                        start_hi++;
                    }
                }
                return myElements;
            }
            MyMergeSort(elements, graphics, tk, 0, n-1);
            for (int i = 0; i < n-1; i++)
            {
                ElementHelper.SelectedOne(elements[i], graphics, tk,s);
            }
            return ICount;
        }
    }
}
