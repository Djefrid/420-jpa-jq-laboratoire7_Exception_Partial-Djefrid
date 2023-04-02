using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmNamespace
{
    internal partial class Film
    {
        public string Titre { get; set; }
        public string Directeur { get; set; }
        public int Annee { get; set; }
        public string Acteurs { get; set; }

        public override string ToString()
        {
            return $"Titre : {Titre}   \nDirecteur de production : {Directeur}  \nAnnee de production : {Annee}  \nActeurs : {Acteurs}";
        }
    }
}
