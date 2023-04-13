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
        public List<string> Acteurs { get; set; }

        public Film(string titre, string directeur, int annee, List<string> acteurs, List<string> genres, string synopsis)
        {
            Titre = titre;
            Directeur = directeur;
            Annee = annee;
            Acteurs = acteurs;
            Genres = genres;
            Synopsis = synopsis;
        }

        public override string ToString()
        {
            string infos = $"Titre : {Titre}   \nDirecteur de production : {Directeur}  \nAnnee de production : {Annee}  \nActeurs : ";
            for (int i = 0; i < Acteurs.Count; i++)
            {
                infos += Acteurs[i];
                if (i < Acteurs.Count - 1)
                    infos += ", ";
            }
            infos += "\nGenres : ";
            for (int i = 0;i < Genres.Count; i++)
            {
                infos += Genres[i];
                if (i < Genres.Count - 1)
                    infos += ", ";
            }
            infos += $"\nSynopsis : {Synopsis}";

            return infos;
        }
    }
}
