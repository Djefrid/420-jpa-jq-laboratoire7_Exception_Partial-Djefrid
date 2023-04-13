using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie3
{
    internal partial class Mission
    {
        public void CompleterMission(Vaisseau vaisseau)
        {
            if (vaisseau.StatutVaisseaus == StatutVaisseau.orbite && StatutMissions != StatutMission.terminee)
            {
                StatutMissions = StatutMission.terminee;
                Console.WriteLine("La mission est terminer");
            }
            else
            {
                Console.WriteLine($"la mision est : {StatutMissions}");
            }
        }

    }
}
