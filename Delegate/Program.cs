using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tableau = new int[] { 4, 1, 6, 10, 8, 5 };
            new TrieurDeTableau().DemoTri(tableau);
            new Operations().DemoOperations();
        }
    }
}
