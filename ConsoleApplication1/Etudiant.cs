using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Etudiant : Personne, IPersonne
    {

        public float F { get; set; }

        public string Departement;

        public Etudiant(string Nom, int age, string departement) : base(Nom, age)
        {
            //base.Nom = Nom;
            //Age = age;
            Departement = departement;
        }

        public double Afficher(string v)
        {
            Departement = "TI";

            Console.WriteLine(v);
            return 5;
        }

        public override int Avancer()
        {
            Console.WriteLine("Avancer..");

            return 0;
        }

        string Etudier(string s)
        {
            this.Avancer();
            base.Avancer();
            return "Etudier..";
        }
    }
}
