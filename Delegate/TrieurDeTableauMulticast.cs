using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{   // Fait pareil que la classe TrieurDeTableau mais cette fois avec un delegate qui pointe sur les 2 fonctions de tri
    class TrieurDeTableauMulticast
    {
        private delegate void DelegateTri(int[] tableau);

        private void TriAscendant(int[] tableau)
        {
            Array.Sort(tableau);
            foreach (int i in tableau)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }

        private void TriDescendant(int[] tableau)
        {
            Array.Sort(tableau);
            Array.Reverse(tableau);
            foreach (int i in tableau)
            {
                Console.WriteLine(i);
            }
        }

        public void DemoTri(int[] tableau)
        {
            // Ici la delegate pointe sur 2 méthodes !
            DelegateTri tri = TriAscendant;
            tri += TriDescendant;
            // Les 2 méthodes vont être executées sur le tableau passé en paramètre.
            tri(tableau);
        }
    }
}
