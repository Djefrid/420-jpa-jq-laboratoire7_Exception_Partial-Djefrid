using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmNamespace
{
    internal class Production
    {
        public Catalogue Catalogues { get; set; }

        public void AddFilmCatalogue(Film film)
        {
            Catalogues.AjouterFilm(film);
        }

        public void AfficherFilmscatalogue()
        {
            Catalogues.AfficherFilms();
        }
    }
}
