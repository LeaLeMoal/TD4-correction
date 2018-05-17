using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecosysteme
{
    class Cigale : Insecte
    {
        public Cigale(int x, int y) : base(5, x, y)
        {
        }

        public override void Deplacer()
        {
            _abcisse += 20;
            _ordonnee += 20;
        }

        public override string ToString()
        {
            return "Je suis une cigale, " + base.ToString();
        }
    }
}
