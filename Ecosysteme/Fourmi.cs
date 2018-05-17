using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecosysteme
{
    class Fourmi : Insecte
    {
        public Fourmi(int x, int y) : base(7, x, y)
        {
        }

        public override void Deplacer()
        {
            _abcisse += 10;
            _ordonnee += 10;
        }

        public override string ToString()
        {
            return "Je suis une fourmi, " + base.ToString();
        }
    }
}
