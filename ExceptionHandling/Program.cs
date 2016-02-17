using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            TryCatchFinallyTest();

            int a = 5;
            int b = 0;

            try
            {
                // db.Open();
                // db.ExecuteQuery("SELECT ** FROM Tab2");
                // db.Close();
                int c = a/b;
                int v = 6/b;
                // Personne p; //= new Personne();
                // p.Nom;
                // p.Universite;
                //List<int> l;
                //l.Add(5);
            }
            catch (NullReferenceException e)
            {
            }
            catch (DivideByZeroException e)
            {
            }
            catch (FileNotFoundException e)
            {
            }
            catch (Exception exception)
            {
                // db.Close();
                Console.WriteLine(exception.Message);
                Console.WriteLine(exception.Source);
            }
            finally
            {
                // db.Close();
                Console.WriteLine("Finally block");
            }

            Console.Read();
        }

        private static void TryCatchFinallyTest()
        {
            StreamReader sr = null;
            //StreamWriter sw;
            try
            {
                sr = File.OpenText(@"D:\data.txt");
                Console.WriteLine(sr.ReadToEnd());
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }
    }
}
