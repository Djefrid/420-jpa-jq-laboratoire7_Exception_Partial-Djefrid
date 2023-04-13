using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie3
{
    internal partial class Vaisseau
    {
        public void ChangerVitesse(int nouvelleVitesse)
        {
            if(nouvelleVitesse > VitesseMax)
            {
                Console.WriteLine("La vitesse demandée dépasse la vitesse maximale du vaisseau");
            }
            else 
            {
                VitesseAct = nouvelleVitesse;
            }
        }
    }
}
