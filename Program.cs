using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullPractica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grafo g = new Grafo(11);

            g.ConexionAristas(0,1);
            g.ConexionAristas(0,6);
            g.ConexionAristas(0,7);
            g.ConexionAristas(0,8);
            g.ConexionAristas(0,9);
            g.ConexionAristas(0,10);
            g.ConexionAristas(1,0);
            g.ConexionAristas(1,2);
            g.ConexionAristas(1,4);
            g.ConexionAristas(1,10);
            g.ConexionAristas(2,1);
            g.ConexionAristas(2,3);
            g.ConexionAristas(2,10);
            g.ConexionAristas(3,2);
            g.ConexionAristas(3,4);
            g.ConexionAristas(3,5);
            g.ConexionAristas(4,1);
            g.ConexionAristas(4,3);
            g.ConexionAristas(4,5);
            g.ConexionAristas(4,6);
            g.ConexionAristas(5,3);
            g.ConexionAristas(5,4);
            g.ConexionAristas(5,6);
            g.ConexionAristas(6,0);
            g.ConexionAristas(6,0);
            g.ConexionAristas(6,4);
            g.ConexionAristas(6,5);
            g.ConexionAristas(6,7);
            g.ConexionAristas(7,0);
            g.ConexionAristas(7,6);
            g.ConexionAristas(7,8);
            g.ConexionAristas(8,0);
            g.ConexionAristas(8,7);
            g.ConexionAristas(8,9);
            g.ConexionAristas(9,0);
            g.ConexionAristas(9,8);
            g.ConexionAristas(9,10);
            g.ConexionAristas(10,0);
            g.ConexionAristas(10,1);
            g.ConexionAristas(10,2);
            g.ConexionAristas(10,9);

            g.Amplitud(0);
            Console.WriteLine("\nProfundidad: ");
            g.Profundidad(0);

            Console.ReadKey();
        }
    }
}
