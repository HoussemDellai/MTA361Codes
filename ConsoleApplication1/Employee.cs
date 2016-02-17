using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Employee : AbstractPersonne
    {

        public override void Afficher(string v)
        {
            Console.WriteLine("v : " + v);
        }

        public override void AfficherNom(string nom)
        {
            Console.WriteLine(nom);
        }
    }
}
