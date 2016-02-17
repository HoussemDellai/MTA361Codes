using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangle r = new Rectangle(10, 5);

            r.LengthChangedEvent += R_LengthChangedEvent;
            //r.LengthChangedEvent += R_LengthChangedEvent2;

            r.LengthChangedEvent -= R_LengthChangedEvent2;

            r.Length = 15;

            Console.Read();
        }

        private static void R_LengthChangedEvent(double l)
        {
            Console.WriteLine("Notification sur le changement du longeur du rectangle, nouveau longeur = " + l);
        }

        private static void R_LengthChangedEvent2(double l)
        {
            Console.WriteLine("Notification sur le changement du longeur du rectangle, nouveau longeur = " + l);
        }
    }
}
