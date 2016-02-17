using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class AbstractPersonne
    {

        public virtual void Afficher(string v)
        {
            Console.WriteLine(v);
        }

        public abstract void AfficherNom(string nom);
    }
}
