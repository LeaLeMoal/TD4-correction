using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vehicules
{
    class Vehicule
    {
        private int _nbRoues;
        private int _nbPlaces;
        private int _kilometrage;

        public Vehicule(int nbRoues, int nbPlaces, int kilometrage)
        {
            _nbRoues = nbRoues;
            _nbPlaces = nbPlaces;
            _kilometrage = kilometrage;
        }

        public override string ToString()
        {
            return "NbRoues=" + _nbRoues + " NbPlaces=" + _nbPlaces + " Km=" + _kilometrage;
        }
    }
}
