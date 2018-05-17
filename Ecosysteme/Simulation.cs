using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecosysteme
{
    class Simulation
    {
        private List<Insecte> _insectes;
        private int _nbTours;
        private Random _alea;

        public Simulation(int nbInsectes, int tours, int xMax, int yMax)
        {
            _alea = new Random();
            _insectes = new List<Insecte>();
            _nbTours = tours;

            for (int i = 0; i < nbInsectes; i++)
            {
                int x = _alea.Next(0, xMax + 1);
                int y = _alea.Next(0, yMax + 1);
                
                switch (_alea.Next(2))
                {
                    case 0:
                        _insectes.Add(new Cigale(x, y));
                        break;
                    case 1:
                        _insectes.Add(new Fourmi(x, y));
                        break;
                    //case 2:
                    //    int faim = _alea.Next(0, 11);
                    //    _insectes.Add(new Insecte(faim, x, y));
                    //    break;
                }
            }
        }

        public void Simuler()
        {
            for (int i = 0; i < _nbTours; i++)
                SimulerUnTour();
        }

        public void SimulerUnTour()
        {
            foreach (Insecte insecte in _insectes)
            {
                insecte.Deplacer();
                insecte.Manger();
            }
        }

        public override string ToString()
        {
            string description = "";
            foreach (Insecte insecte in _insectes)
            {
                description += insecte + "\n";
            }
            return description;
        }
    }
}
