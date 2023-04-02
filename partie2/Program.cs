using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmNamespace;

namespace Partie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Film film = new Film();

            film.Titre = "Scorpion";
            film.Directeur = "Obrayant";
            film.Annee = 2015;
            film.Acteurs = "Obrayant";


            Film film1 = new Film();

            film1.Titre = "Scorpion";
            film1.Directeur = "Obrayant";
            film1.Annee = 2015;
            film1.Acteurs = "Obrayant";

            Film film2 = new Film();

            film2.Titre = "Scorpion";
            film2.Directeur = "Obrayant";
            film2.Annee = 2015;
            film2.Acteurs = "Obrayant";

            Film film3 = new Film();

            film3.Titre = "Scorpion";
            film3.Directeur = "Obrayant";
            film3.Annee = 2015;
            film3.Acteurs = "Obrayant";

            Film film4 = new Film();

            film4.Titre = "Scorpion";
            film4.Directeur = "Obrayant";
            film4.Annee = 2015;
            film4.Acteurs = "Obrayant";

            Production productions = new Production();

            productions.AddFilmCatalogue(film);
            productions.AddFilmCatalogue(film1);
            productions.AddFilmCatalogue(film2);
            productions.AddFilmCatalogue(film3);
            productions.AddFilmCatalogue(film4);

            productions.AfficherFilmscatalogue();
        }
    }
}
