using SAV_1.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SAV_1
{
    public class ElementHelper
    {
        public static void DrawSwap(Element first, Element second, Graphics graphic, int tk, int speed)
        {
            var firstClone = first.Clone();
            var secondClone = second.Clone();
            int temporary = firstClone.End.Y;

            //Show selected
            firstClone.Selected(graphic,tk);
            secondClone.Selected(graphic, tk);
            Thread.Sleep(speed);

            //eraser
            firstClone.Eraser(graphic,tk);
            secondClone.Eraser(graphic,tk);
            Thread.Sleep(speed);
            //Thread.Sleep(ArrayOptions.Delayed);

            //swap
            firstClone.End = new Point(firstClone.End.X, second.End.Y);
            secondClone.End = new Point(secondClone.End.X, temporary);
            Thread.Sleep(speed);

            //redraw
            firstClone.Draw(graphic,tk);
            secondClone.Draw(graphic,tk);

        }

        public static void ElementSwap(List<Element> elements, int first, int second)
        {
            //swap location
            var temporary = elements[first].End.Y;
            elements[first].End = new Point(elements[first].End.X, elements[second].End.Y);
            elements[second].End = new Point(elements[second].End.X, temporary);

            //swap value
            var tempValue = elements[first].Value;
            elements[first].Value = elements[second].Value;
            elements[second].Value = tempValue;
        }

        public static void SelectedOne(Element first, Graphics graphic, int tk,int speed)
        {
            var firstSelected = first.Clone();
            firstSelected.SelectedOne(graphic, tk);
            Thread.Sleep(speed);
            firstSelected.Draw(graphic, tk);

        }

        public static void keepSelected(Element first, Graphics graphic, int tk, int speed)
        {
            var firstSelected = first.Clone();
            firstSelected.SelectedOne(graphic, tk);
            Thread.Sleep(speed);
            //firstSelected.Draw(graphic, tk);

        }
    }
}
