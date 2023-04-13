using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmNamespace
{
    internal partial class Catalogue
    {
        List<Film> Films {  get; set; }

        public Catalogue() 
        {
            Films = new List<Film>();
        }

        public void AjouterFilm(Film film)
        {
            Films.Add(film);
        }

        public void SupprimerFilm(Film film)
        {
            Films.Remove(film);
        }

        public void AfficherFilms()
        {
            foreach (Film film in Films)
            {
                Console.WriteLine($"{film}\n");
            }
        }
    }
}
