using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Personne
    {

        public int Age { get; set; }
        public string Nom;

        public Personne()
        {
        }

        public Personne(string Nom, int Age)
        {
            this.Nom = Nom;
            this.Age = Age;
        }

        public virtual int Avancer()
        {
            Console.WriteLine("Avancer..");

            return 0;
        }
    }
}
