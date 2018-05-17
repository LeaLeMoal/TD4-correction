using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecosysteme
{
    abstract class Insecte
    {
        private int _faim;
        private int _dernierRepas;
        protected int _abcisse;
        protected int _ordonnee;

        public Insecte(int nbFaim, int x, int y)
        {
            _faim = nbFaim;
            _abcisse = x;
            _ordonnee = y;
            _dernierRepas = 0;
        }

        public void Manger()
        {
            if (_dernierRepas == _faim)
                _dernierRepas = 0;
            else
                _dernierRepas++;
        }

        public abstract void Deplacer();
        
        public override string ToString()
        {
            return "X=" + _abcisse + " Y=" + _ordonnee + " DernierRepas=" + _dernierRepas + " Faim=" + _faim;
        }
    }
}
