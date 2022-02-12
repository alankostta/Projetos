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
            double[,] matriz = new double[2,2];
            float determinante = 0.0f;


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("Informe os valores décimais para cálcular o determinante: ");
                    matriz[i, j] = double.Parse(Console.ReadLine());

                    Console.WriteLine($"Determinante: {matriz[i,j]}");
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    determinante = (float)((matriz[0,0] * matriz[1,1]) - (matriz[0,1] * matriz[1,0]));
                }
            }
            Console.WriteLine($"O resultado do cálculo do determinante é: {determinante}");

        }
    }
}