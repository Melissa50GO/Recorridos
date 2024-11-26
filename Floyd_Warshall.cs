using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullPractica
{
    internal class Floyd_Warshall
    {
        int[,] matrizFinal;

        public void ImprimirMatriz(int[,] matriz)
        {
            for(int i=0; i<matriz.GetLength(0); i++)
            {
                Console.WriteLine();
                for(int j= 0; j< matriz.GetLength(0); j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
            }
        }

        public void Floyd(int[,] matriz)
        {
            matrizFinal = matriz;

            for(int k=0; k<matriz.GetLength(0); k++)
            {
                for(int i=0; i < matriz.GetLength(0); i++)
                {
                    for(int j= 0; j < matriz.GetLength(0); j++)
                    {
                        if (matrizFinal[i,k] + matrizFinal[k, j] < matrizFinal[i, j])
                        {
                            matrizFinal[i, j] = matrizFinal[i, k] + matrizFinal[k, j];
                        }
                    }
                }
            }

            ImprimirMatriz(matrizFinal);
        }
    }
}
