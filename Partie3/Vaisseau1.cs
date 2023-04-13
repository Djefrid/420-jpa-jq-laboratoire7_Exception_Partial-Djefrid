using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie3
{
    internal partial class Vaisseau
    {
        public List<Mission> Missions { get; set; }

        public void Decollage(string coordDest, string date)
        {
            if (StatutVaisseaus == StatutVaisseau.orbite)
                Console.WriteLine($"Le vaisseau est déjà en orbite");
            else
            {
                StatutVaisseaus = StatutVaisseau.orbite;
                Missions = new List<Mission> { { new Mission(coordDest, date) } };
            }
        }

        public void Decollage(Mission mission)
        {
            if (StatutVaisseaus == StatutVaisseau.orbite)
                Console.WriteLine($"Le vaisseau est déjà en orbite");
            else
            {
                StatutVaisseaus = StatutVaisseau.orbite;
                Mission nvlMission = mission;
                Missions.Add(nvlMission);
            }
        }
    }
}
