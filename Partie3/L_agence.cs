using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Console = Colorful.Console;

namespace Partie3
{
    internal class L_agence
    {
        public List<Vaisseau> Vaisseaus { get; set; }
        public List<Mission> Missions { get; set; }
        public List<Planete> Planetes { get; set; }

        public L_agence()
        {
            Vaisseaus = new List<Vaisseau> { { new Vaisseau("v1", 8888954, StatutVaisseau.terre) }, { new Vaisseau("v2", 46874, StatutVaisseau.terre) }, { new Vaisseau("v3", 5765652, StatutVaisseau.terre) } };
            Missions = new List<Mission> { { new Mission("jupiter", "05-11-2023", "m1") }, { new Mission("mars", "05-10-2023", "m2") }, { new Mission("saturne", "05-06-2023", "m3") }, { new Mission("saturne", "05-06-2023", "m4") } };
            Planetes = new List<Planete> { { new Planete("jupiter", "jupiter") }, { new Planete("mars", "mars") }, { new Planete("saturne", "saturne", true) }, { new Planete("neptune", "neptune") } };
        }

        public void AddVaisseau(Vaisseau vaisseau)
        {
            Vaisseaus.Add(vaisseau);
        }

        public void AddMission(Mission mission)
        {
            Missions.Add(mission);
        }

        public void AddPlanete(Planete planete)
        {
            Planetes.Add(planete);
        }

        public void AfficherVaisseau()
        {
            for (int i = 0; i < Vaisseaus.Count; i++)
                Console.WriteLine(Vaisseaus[i]);
        }

        public void AfficherMission()
        {
            for (int i = 0; i < Missions.Count; i++)
                Console.WriteLine(Missions[i]);
        }

        public void AfficherPlanete()
        {
            for (int j = 0; j < Planetes.Count; j++)
                Console.WriteLine(Planetes[j]);
        }

        public void PlanifierMission(Vaisseau vaisseau, Mission mission)
        {
            vaisseau.Decollage(mission);
        }

        public void PlanifierMission(Vaisseau vaisseau, string coordDest, string date)
        {
            vaisseau.Decollage(coordDest, date);
        }

        public void Lancement(Vaisseau vaisseau, Planete planete)
        {
            try
            {
                if (vaisseau == null || (vaisseau != null && vaisseau.Missions == null))
                    throw new MonException("Le vaiseau ne peut pas etre lancer car : \nSoit le vaisseau est null ou le vaiseau n'a aucunne mission de plannifier");
                else if (vaisseau != null && vaisseau.Missions != null && planete.Explorer == true)
                    throw new MonException("Le vaiseau ne peut pas etre lancer car : \nLa planette a deja été explorer");
                else
                {
                    planete.Explorer = true;
                    Console.WriteLine("Le vaisseau  été lancer avec succes");
                }
            }
            catch (MonException monEx)
            {
                Console.WriteLine(monEx.Message);
            }
        }

        public void Lancement(Vaisseau vaisseau)
        {
            try
            {
                if (vaisseau == null || (vaisseau != null && vaisseau.Missions == null))
                    throw new MonException("Le vaiseau ne peut pas etre lancer car : \nSoit le vaisseau est null ou le vaiseau n'a aucunne mission de plannifier");
                else
                {
                    Console.WriteLine("Le vaisseau  été lancer avec succes");
                }
            }
            catch (MonException monEx)
            {
                Console.WriteLine(monEx.Message);
            }
        }

        public void VerifierPlanete(Planete planete)
        {
            if (planete.VerifierPlanete(planete.Explorer))
                Console.WriteLine("La planette a deja été explorer", color: Color.Yellow);
            else
                Console.WriteLine("La planete n'a encore été explorer", color: Color.Yellow);
        }
    }
}
