using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie3
{
    enum StatutVaisseau
    {
        orbite,
        terre
    }

    internal partial class Vaisseau
    {
        public string Nom { set; get; }
        public int Capacite { set; get; }
        public int VitesseAct { set; get; }
        public int VitesseMax { set; get; }
        public StatutVaisseau StatutVaisseaus { set; get; }

        public Vaisseau(string nom, int capacite, int vitesseAct, int vitesseMax, StatutVaisseau statutVaisseaus, List<Mission> missions)
        {
            Nom = nom;
            Capacite = capacite;
            VitesseAct = vitesseAct;
            VitesseMax = vitesseMax;
            StatutVaisseaus = statutVaisseaus;
            Missions = missions;
        }


        public Vaisseau(string nom, int capacite,StatutVaisseau statutVaisseaus) 
        {
            
            Nom = nom;
            Capacite = capacite;
            StatutVaisseaus = statutVaisseaus;
            Missions = new List<Mission>();
        }

        public override string ToString()
        {
            string infos = $"\nNom : {Nom} \nCapacite : {Capacite} \nVitesse actuelle : {VitesseAct} \nVitesse Maximal : {VitesseMax} \nStatut : {StatutVaisseaus}  ";
           
            if (Missions != null)
            {
                infos += "\nMissions : ";
                for (int i = 0; i < Missions.Count; i++)
                {
                    infos += Missions[i];
                    if (i < Missions.Count - 1)
                        infos += ", ";
                }
            }

            return infos;
        }
    }
}
