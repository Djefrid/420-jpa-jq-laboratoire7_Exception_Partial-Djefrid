using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmNamespace
{
    internal partial class Catalogue
    {
        public void RechercherParCategorie(Film film)
        {
            for (int i = 0; i < Films.Count; i++)
            {
                if (film.Titre == Films[i].Titre)
                {
                    Console.WriteLine(film);
                }
            }
        }

        public void RechercherParActeur(Film film)
        {
            for (int i = 0; i < Films.Count; i++)
            {
                if (film.Acteurs == Films[i].Acteurs)
                {
                    Console.WriteLine($"{film}");
                }
            }
        }
    }
}
