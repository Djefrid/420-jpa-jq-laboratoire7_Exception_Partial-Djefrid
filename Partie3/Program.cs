using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = Colorful.Console;

namespace Partie3
{
    internal class Program
    {
        static int VerifierSaisie()
        {
            bool estValide = false;
            int nbre = 0;

            do
            {
                try
                {
                    string value = Console.ReadLine();

                    if (!int.TryParse(value, out nbre))
                        throw new MonException("Vous n'avez pas entrer un entier");
                    else
                        estValide = true;
                }
                catch (MonException monEx)
                {
                    Console.WriteLine(monEx.Message, color: Color.Red);
                }
                finally
                {
                    if (!estValide)
                        Console.WriteLine("Ressayer", color: Color.Blue);
                }
            } while (!estValide);

            return nbre;
        }


        static void MessageDeBienvenue()
        {
            int DA = 255;
            int V = 255;
            int ID = 0;
            Console.WriteAscii("  ---BIENVENUE---  ", Color.FromArgb(DA, V, ID));
        }

        static void Option()
        {
            Console.WriteLine("\n-------------------------------------------------------------");
            Console.WriteLine("-- 1. Afficher les vaisseaux                               --");
            Console.WriteLine("-- 2. Afficher les missions                                --");
            Console.WriteLine("-- 3. Afficher les planetes                                --");
            Console.WriteLine("-- 4. Planifier une mission                                --");
            Console.WriteLine("-- 5. Lancer un vaisseau                                   --");
            Console.WriteLine("-- 6. Verifier si une planete a deja été explorer          --");
            Console.WriteLine("-- 7. Quitter                                              --");
            Console.WriteLine("-------------------------------------------------------------");

            Console.WriteLine("\nNB : pour eviter de faire ses erreur de saisie sur les nom de planete afficher lès avant la verification", color: Color.Yellow);
            Console.WriteLine("\nEntrer le nombre correspondant a voter choix", color: Color.Green);
        }

        static void Main(string[] args)
        {
            MessageDeBienvenue();
            L_agence monAgence = new L_agence();

            bool valide = true;

            while (valide == true)
            {
                Option();
                int saisie = VerifierSaisie();

                switch (saisie)
                {
                    case 1:
                        Console.WriteLine("la liste des vaiseau est :");
                        monAgence.AfficherVaisseau();
                        break;
                    case 2:
                        Console.WriteLine("la liste des missions est :");
                        monAgence.AfficherMission();
                        break;
                    case 3:
                        Console.WriteLine("la liste des planetes est :");
                        monAgence.AfficherPlanete();
                        break;
                    case 4:
                        Console.WriteLine("Quelle vaisseau vouler vous lancer\nEntrer le numero qui est devant le nom du vaisseau :");
                        int entrer = VerifierSaisie();
                        Vaisseau vaisseau;

                        if (entrer == 1)
                            vaisseau = monAgence.Vaisseaus[entrer];
                        else if (entrer == 2)
                            vaisseau = monAgence.Vaisseaus[entrer];
                        else if (entrer == 3)
                            vaisseau = monAgence.Vaisseaus[entrer];
                        else
                            vaisseau = monAgence.Vaisseaus[entrer];

                        Console.WriteLine("Quelle missiom vouler vous planifier\nEntrer le numero qui est devant le nom de la mission :");
                        int entrer1 = VerifierSaisie();
                        Mission mission;

                        if (entrer1 == 1)
                            mission = monAgence.Missions[entrer1];
                        else if (entrer == 2)
                            mission = monAgence.Missions[entrer1];
                        else if (entrer == 3)
                            mission = monAgence.Missions[entrer1];
                        else
                            mission = monAgence.Missions[entrer1];

                        monAgence.PlanifierMission(vaisseau, mission);
                        Console.WriteLine("afficher les Vaisseau de nouveau pour pouvoir savoir les vaiseau qui ont une mission planifier");
                        break;
                    case 5:
                        Console.WriteLine("Quelle vaisseau vouler vous lancer\nEntrer le numero qui est devant le nom de la mission :");
                        int entrer2 = VerifierSaisie();
                        Vaisseau vaisseau1;

                        if (entrer2 == 1)
                            vaisseau1 = monAgence.Vaisseaus[entrer2];
                        else if (entrer2 == 2)
                            vaisseau1 = monAgence.Vaisseaus[entrer2];
                        else if (entrer2 == 3)
                            vaisseau1 = monAgence.Vaisseaus[entrer2];
                        else
                            vaisseau1 = monAgence.Vaisseaus[entrer2];

                        monAgence.Lancement(vaisseau1);
                        break;
                    case 6:
                        Console.WriteLine("Quelle planete vouler vous verifier sont exploration\nEntrer le nom de la planete :");
                        string nomPlanete = Console.ReadLine();
                        string testeEnMinusc = nomPlanete.ToLower();
                        Planete planete = null;
                        for (int i = 0; i < monAgence.Planetes.Count; i++)
                        {
                            if (testeEnMinusc == monAgence.Planetes[i].NomPlanete)
                                planete = monAgence.Planetes[i];
                        }
                        monAgence.VerifierPlanete(planete);
                        break;
                    case 7:
                        valide = false;
                        Console.WriteLine("Merci d'avoir participer. Bye!", color: Color.Yellow);
                        break;
                }
            }
        }
    }
}
