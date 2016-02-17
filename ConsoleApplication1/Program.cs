using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Personne p = new Personne("Mohamed", 20);
            p.Avancer();
            //p.Age = 20;
            //p.Nom = "Mohamed";
            Console.WriteLine("Age : " + p.Age);
            Console.WriteLine("Nom : " + p.Nom);
            //p.Age = 23;// error

            Etudiant e = new Etudiant("Ahmed", 24, "TI");
            Console.WriteLine("Département : " + e.Departement);
            Console.WriteLine("Nom Etudiant : " + e.Nom);
            Console.WriteLine("Age Etudiant : " + e.Age);
            //e.Nom = "Ahmed";
            //e.Age = 24;

            Console.Write("Hello ISET Jendouba :)");
            Console.Read();
        }
    }
}
