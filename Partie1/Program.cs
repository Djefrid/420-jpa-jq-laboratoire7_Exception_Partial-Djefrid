﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculateur calculateur = new Calculateur();

            calculateur.Diviser();

            calculateur.Multiplier();

            Console.ReadKey();
        }
    }
}
