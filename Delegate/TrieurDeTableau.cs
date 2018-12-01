using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class TrieurDeTableau
    {
        // Création de la delegate
        private delegate void DelegateTri(int[] tableau);

        private void TriAscendant(int[] tableau)
        {
            Array.Sort(tableau);
        }

        private void TriDescendant(int[] tableau)
        {
            Array.Sort(tableau);
            Array.Reverse(tableau);
        }
        public void DemoTri(int[] tableau)
        {
            // Initialisation de la variable delegate pointant sur la fonction TriAscendant
            DelegateTri tri = TriAscendant;
            tri(tableau);
            foreach (int i in tableau)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            // On affecte (on fait pointer) la méthode TriDescendant à la delegate
            tri = TriDescendant;
            tri(tableau);
            foreach (int i in tableau)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
        // TrierEtAfficher attend une delegate en paramètre, on peut faire passer des méthodes en paramètre !
        private void TrierEtAfficher(int[] tableau, DelegateTri methodeDeTri)
        {
            methodeDeTri(tableau);
            foreach (int i in tableau)
            {
                Console.WriteLine(i);
            }
        }
        // Action simule une delegate ne renvoyant pas de résultat (cela permet simplement de ne pas appelé le type DelegateTri crée)
        private void TrierEtAfficherBis(int[] tableau, Action<int[]> methodeDeTri)
        {
            methodeDeTri(tableau);
            foreach (int i in tableau)
            {
                Console.WriteLine(i);
            }
        }
        public void DemoTriBis(int[] tableau)
        {
            // L'écriture est largement simplifiée grâce aux delegates.
            TrierEtAfficher(tableau, TriAscendant);
            TrierEtAfficher(tableau, TriDescendant);
            Console.ReadKey();
        }
        // ici on fait la même chose mais sans déclarer TriAscendant et TriDescendant, pas forcment utilse et surtout moyennement lisible
        public void DemoTriBisBis(int[] tableau)
        {
            TrierEtAfficher(tableau, delegate (int[] leTableau)
            { // On décrit TriAscendant, pas besoin de déclarer la méthode, utilse quand la méthode est utilisé pour un seul processus
                Array.Sort(leTableau);
            });

            Console.WriteLine();

            TrierEtAfficher(tableau, delegate (int[] leTableau)
            { // On décrit TriDescendant, pas besoin de déclarer la méthode, utilse quand la méthode est utilisé pour un seul processus
                Array.Sort(leTableau);
                Array.Reverse(leTableau);
            });
            Console.ReadKey();
        }
        public void demoLambdas()
        {
            // Ceci
            DelegateTri tri = delegate (int[] leTableau)
            {
                Array.Sort(leTableau);
            };
            // Peut s'écrire 
            DelegateTri triBis = (leTableau) =>
            { //Pas besoin de spécifier le type étant donné que celui ci est déjà indiqué à la déclaration du delegate.
                Array.Sort(leTableau);
            };

        }
    }
}
