using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vehicules
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicule poussePousse = new Vehicule(4, 6, 100);
            Console.WriteLine(poussePousse);

            Voiture berlingo = new Voiture(5, 175000, 1400, "bleu", 7);
            Console.WriteLine(berlingo);

            Moto fazer = new Moto(2, 12300, 850, "rouge", 12);
            Console.WriteLine(fazer);

            Tesla modelS = new Tesla(5, 500, 1600, "blanc", 10, 4.3, 75.5);
            Console.WriteLine(modelS);
            Console.WriteLine("Consommation=" +modelS.Consommation);
            Console.WriteLine("CapaciteReservoir="+ modelS.CapaciteReservoir);

            Console.ReadKey();
        }
    }
}
