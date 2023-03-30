using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie1
{
    internal class Calculateur
    {

        public Calculateur() { }



        public int VerifierSaisie()
        {
            bool estValide = false;
            int nbre = 0;

            do
            {
                try
                {
                    string value = Console.ReadLine();

                    if(!int.TryParse(value,out nbre)) 
                        throw new MonException("Vous n'avez pas entrer un entier");
                    else
                        estValide = true;
                }
                catch (MonException monEx)
                {
                    Console.WriteLine(monEx.Message);
                }
                finally
                {
                    if (!estValide)
                    {
                        Console.WriteLine("Ressayer");
                    }
                }

            } while (!estValide);

            return nbre;
        }

        public void Diviser()
        {
            Console.WriteLine("Entrer un nombre a diviser ");
            int nbre1 = VerifierSaisie();
            Console.WriteLine("Entrer le nombre par lequel vous vouler diviser le premier");
            int nbre2 = VerifierSaisie();

            try
            {
                int rslt = nbre1 / nbre2;

                Console.WriteLine($"le resultat de la division est : {rslt}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("La division na pas pu etre effectuer car le denominateur est 0");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Une erreur s'est produite ");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
