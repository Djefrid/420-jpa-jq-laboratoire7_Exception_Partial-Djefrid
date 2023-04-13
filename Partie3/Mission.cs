using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Partie3
{
    enum StatutMission
    {
        Planifiee,
        en_cour,
        terminee
    }

    internal partial class Mission
    {
        public string NomMission { get; set; }
        public string Destination { get; set;}
        public string DateDepart { get; set; }
        public string DateD_arriver { get; set; }
        public StatutMission StatutMissions { get; set; }

        public Mission(string nomMission, string destination, string dateDepart, string dateD_arriver, StatutMission statutMission) 
        {
            NomMission = nomMission;
            Destination = destination;
            DateDepart = dateDepart;
            DateD_arriver = dateD_arriver;
            StatutMissions = statutMission;
        }

        public Mission(string destination, string dateDepart, string nomMission = "Exploration") 
        {
            NomMission = nomMission;
            Destination = destination;
            DateDepart = dateDepart;
            DateD_arriver = "Dans 3 jour";
            StatutMissions = StatutMission.Planifiee;
        }

        public override string ToString() 
        {
            return $"\nNom : {NomMission}\nDestination : {Destination}\nStatut Missions : {StatutMissions}";
        }

    }
}
