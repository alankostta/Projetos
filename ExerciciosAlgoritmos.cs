using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programa
{
    public class ExerciciosAlgoritmo
    {
        public void determinante()
        {
            string[,] matriz = new string[2, 2];
            double[,] mat = new double[2, 2];
            double determinante = 0;

            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz.Length; j++)
                {
                    Console.Write("Informe os valores decimais para calcular o determinante: ");
                    mat[i, j] = Console.Read();
                    double.TryParse(matriz[i, j], out mat[i, j]);
                }
            }
            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz.Length; j++)
                {
                    determinante = ((mat[0, 0] * mat[1, 1]) - (mat[0, 1] * mat[1, 0]));
                }
            }
            Console.WriteLine("O resultado do cálculo do determinante é: ", determinante);
        }
    }
}