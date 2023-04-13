using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie3
{
    internal class Planete
    {
        public string NomPlanete { get; set; }
        public int Taille { get; set; }
        public int DistanceParRapA_Terre { get; set; }
        public string TypeAtmosphere { get; set; }
        public string CoordPlanete { get; set; }
        public bool Explorer { get; set; }

        public Planete(string nomPlanete, string coordPlanete, int taille, int distanceParRapA_Terre, string typeAtmosphere, bool explorer = false)
        {
            NomPlanete = nomPlanete;
            Taille = taille;
            DistanceParRapA_Terre = distanceParRapA_Terre;
            TypeAtmosphere = typeAtmosphere;
            Explorer = explorer;
            CoordPlanete = coordPlanete;
        }

        public Planete(string nomPlanete, string coordPlanete, bool explorer = false)
        {
            NomPlanete = nomPlanete;
            CoordPlanete = coordPlanete;
            Taille = 656556;
            DistanceParRapA_Terre = 45645;
            TypeAtmosphere = "h2o";
            Explorer = explorer;
        }

        public bool VerifierPlanete(Mission mission)
        {
            if (mission.Destination != CoordPlanete)
                Explorer = false;
            else
                Explorer = true;

            return Explorer;
        }

        public bool VerifierPlanete(bool explorer)
        {
            if (explorer == false)
                return false;
            else
                return true;
        }

        public override string ToString()
        {
            return $"\nNom : {NomPlanete}\nTaille : {Taille}\nDistance par rappeort avec la terre : {DistanceParRapA_Terre}\nType d'admosphere ; {TypeAtmosphere}";
        }

    }
}
