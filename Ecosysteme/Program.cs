using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecosysteme
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Insecte insecte = new Insecte(5, 0, 0);

            for (int i = 0; i < 32; i++)
            {
                insecte.Deplacer();
                insecte.Manger();
            }

            Console.WriteLine(insecte);*/

            Simulation simu = new Simulation(15, 32, 100, 100);
            simu.Simuler();
            Console.WriteLine(simu);

            Console.ReadKey();
        }
    }
}
