using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class Rectangle
    {
        public delegate void LengthChanged(double l);
        public event LengthChanged LengthChangedEvent;

        private double length;
        public double Length
        {
            get { return length; }
            set
            {
                length = value;
                if (LengthChangedEvent != null)
                {
                    LengthChangedEvent(length);
                }
                Console.WriteLine(length);
            }
        }

        public double Width { get; set; }

        public Rectangle(double l, double w)
        {
            this.Length = l;
            this.Width = w;
        }

        public double GetArea()
        {
            return this.Length * this.Width;
        }
    }
}
