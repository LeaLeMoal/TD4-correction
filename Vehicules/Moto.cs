using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vehicules
{
    class Moto : Vehicule
    {
        private int _poids;
        private string _couleur;
        private int _puissance;

        public Moto(int nbPlaces, int kilometrage, int poids, string couleur, int puissance)
            : base(2, nbPlaces, kilometrage)
        {
            _poids = poids;
            _couleur = couleur;
            _puissance = puissance;
        }

        public override string ToString()
        {
            return base.ToString() + " Poids= " + _poids + " Couleur=" + _couleur + " Puissance=" + _puissance;
        }
    }
}
