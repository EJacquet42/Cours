using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsAlgo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Veuillez entrer un Premier Nombre à Additionner : ");
            int Numero1 = int.Parse(Console.ReadLine());
            Console.Write("Veuillez entrer un Deuxième Nombre à Additionner : ");
            int Numero2 = int.Parse(Console.ReadLine());
            Console.Write("La Somme de " + Numero1 + " et " + Numero2 + " est : " + (Numero1 + Numero2));
            Console.ReadKey();
        }
    }
}
