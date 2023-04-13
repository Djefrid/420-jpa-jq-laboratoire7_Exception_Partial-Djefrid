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
            List<string> genre = new List<string> { "combat ", "action" };
            List<string> Acteurs = new List<string> { "Obrayant" };
            Film film = new Film("spartacus", "Obrayant", 2015, Acteurs, genre, "les genis");

            List<string> genre1 = new List<string> { "Histoire ", "Drame", "Geurre" };
            List<string> Acteurs1 = new List<string> { " Pierre Lottin", "Théo Cholbi", " Yannick Choirat" , "Omar Boulakirba" };
            Film film1 = new Film("Les Haris", "Obrayant", 2022, Acteurs1,genre1, "les genis");

            List<string> genre2 = new List<string> { "Drame ", " Thriller" };
            List<string> Acteurs2 = new List<string> { "Willem Dafoe", "Gene Bervoets", "Josia Krug" , "Eliza Stuyck" };
            Film film2 = new Film("Inside", "Obrayant", 2023, Acteurs2, genre2, "les genis");

            List<string> genre3 = new List<string> { "Drame ", "Histoire" };
            List<string> Acteurs3 = new List<string> { "Obrayant" };
            Film film3 = new Film("L'Homme De Dieu", "Yelena Popovic", 2021, Acteurs3, genre3, "les genis");

            List<string> genre4 = new List<string> { "Fantastique ", "action" };
            List<string> Acteurs4 = new List<string> { " Tyler Hoechlin", " Elizabeth Tulloch" , "Alex Garfin" };
            Film film4 = new Film("Superman & Loïs - Saison 3", " Todd Helbing", 2015, Acteurs4, genre4, "les genis");

            Production productions = new Production();

            productions.AddFilmCatalogue(film);
            productions.AddFilmCatalogue(film1);
            productions.AddFilmCatalogue(film2);
            productions.AddFilmCatalogue(film3);
            productions.AddFilmCatalogue(film4);
            Console.WriteLine("after -------------------------------------------------------\n");
            productions.AfficherFilmscatalogue();
            productions.DeleteFilmCatalogue(film);
            Console.WriteLine("before -------------------------------------------------------\n");
            productions.AfficherFilmscatalogue();
        }
    }
}
