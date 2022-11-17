using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAV_1;


namespace SAV_1.Entity
{
    
    public class Element
    {
        public Point Start { get; set; }
        public Point End { get; set; }

        public int Value { get; set; }

        public Element(Point start, Point end, int value)
        {
            Start = start;
            End = end;
            Value = value;
        }

        public Element Clone() => new Element(Start, End, Value);
        public void Draw(Graphics graphics, int tk)
        {
            var pen = new Pen(Color.Red, tk);
            graphics.DrawLine(pen, Start, End);
        }

        public void Eraser(Graphics graphics, int tk)
        {
            var pen = new Pen(Color.Black, tk);
            graphics.DrawLine(pen, Start, End);
        }

        public void Selected(Graphics graphics, int tk)
        {
            var pen = new Pen(Color.Green,tk);
            graphics.DrawLine(pen, Start, End);
        }
        public void SelectedOne(Graphics graphics, int tk)
        {
            var pen = new Pen(Color.Purple, tk);
            graphics.DrawLine(pen, Start, End);
        }
    }
}
