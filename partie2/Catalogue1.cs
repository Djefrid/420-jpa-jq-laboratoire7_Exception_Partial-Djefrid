using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmNamespace
{
    internal partial class Catalogue
    {
        public Film RechercherParCategorie(Film film)
        {
            for (int i = 0; i < Films.Count; i++)
            {
                if (film.Titre == Films[i].Titre)
                {
                    Console.WriteLine(film.ToString());
                }
            }

            return new Film();
        }

        public Film RechercherParActeur(Film film)
        {
            for (int i = 0; i < Films.Count; i++)
            {
                if (film.Acteurs == Films[i].Acteurs)
                {
                    Console.WriteLine($"{film}");
                }
            }

            return new Film();
        }
    }
}
