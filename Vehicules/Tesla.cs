using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vehicules
{
    class Tesla : Voiture
    {
        public double Consommation { get; set; }
        public double CapaciteReservoir { get; set; }

        public Tesla(int nbPlaces, int kilometrage, int poids, string couleur, 
            int puissance, double consommation, double capaciteReservoir)
            : base(nbPlaces, kilometrage, poids, couleur, puissance)
        {
            Consommation = consommation;
            CapaciteReservoir = capaciteReservoir;
        }

        public override string ToString()
        {
            return base.ToString() + " Consommation=" + Consommation + " CapaciteReservoir=" + CapaciteReservoir;
        }
    }
}
