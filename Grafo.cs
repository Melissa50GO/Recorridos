using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullPractica
{
    internal class Grafo
    {
        private LinkedList<int>[] ArregloListAdya;
        int v;

        public Grafo(int vertices)
        {
            v = vertices;
            ArregloListAdya = new LinkedList<int>[v];
            for(int i= 0; i<v; i++)
            {
                ArregloListAdya[i] = new LinkedList<int>();
            }
        }

        public void ConexionAristas(int origen, int destino)
        {
            ArregloListAdya[origen].AddLast(destino);
            ArregloListAdya[destino].AddLast(origen);
        }

        public void Amplitud(int origen)
        {
            int actual;
            Queue<int> cola = new Queue<int>();
            bool[] visitados = new bool[v];

            cola.Enqueue(origen);
            while(cola.Count > 0)
            {
                actual = cola.Dequeue();
                visitados[actual] = true;
                Console.Write(actual + " ");
                foreach(int n in ArregloListAdya[actual])
                {
                    if (!visitados[n])
                    {
                        cola.Enqueue(n);
                        visitados[n] = true;
                    }
                }
            }

        }

        private void Profundidad(int origen, bool[] visitados)
        {
            visitados[origen] = true;
            Console.Write(origen + " ");

            foreach(int n in ArregloListAdya[origen])
            {
                if (!visitados[n])
                {
                    Profundidad(n, visitados);
                }
            }
        }

        public void Profundidad(int origen)
        {
            bool[] visit = new bool[v];
            Profundidad(origen, visit);
        }
    }
}
