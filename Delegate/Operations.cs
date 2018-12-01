using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Operations
    {
        public void DemoOperations()
        {
            double division = Calcul(delegate (int a, int b)
            {
                return (double)a / (double)b;
            }, 4, 5);
            // Méthode division simplifiée à l'aide de l'ambdas
            double divisionBis = Calcul((a, b) =>
            {
                return (double)a / (double)b;
            }, 4, 5);
            // Sur une seule ligne !
            double divisionBisBis = Calcul((a, b) => (double)a / (double)b, 4, 5);

            double puissance = Calcul(delegate (int a, int b)
            {
                return Math.Pow((double)a, (double)b);
            }, 4, 5);

            Console.WriteLine("Division : " + division);
            Console.WriteLine("Puissance : " + puissance);
            Console.ReadKey();
        }
        // Func est un mot clé permettant de simuler une delegate renvoyant un résultat (on indique les paramètres que prend la delegate et sa valeur de retour)
        private double Calcul(Func<int, int, double> methodeDeCalcul, int a, int b)
        {
            return methodeDeCalcul(a, b);
        }
    }
}
