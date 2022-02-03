using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programa
{
    public class Calculadora
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public Char Operador { get; set; }

        public Calculadora()
        {
            this.Num1 = 0.0;
            this.Num2 = 0.0;
            this.Operador = ' ';
        }
        public void InformarValores()
        {
            Calculadora calcular = new Calculadora();

            Console.WriteLine("Informe o operador Matemático");
            calcular.Operador = char.Parse(Console.ReadLine());

            Console.WriteLine("Informe o primeiro número: ");
            calcular.Num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            calcular.Num2 = Convert.ToDouble(Console.ReadLine());

            double result = calcularValores(calcular.Operador, calcular.Num1, calcular.Num2);
            Console.WriteLine("Resultado: "+result);
        }
        public double calcularValores(char op, double num1, double num2)
        {
            double resultado = 0.0;

            if (op == '+' || op == '-' || op == '*' || op == '/')
            {
                try
                {
                    switch (op)
                    {
                        case '+':
                            resultado = num1 + num2;
                            break;

                        case '-':
                            resultado = num1 - num2;
                            break;

                        case '*':
                            resultado = num1 * num2;
                            break;

                        case '/':
                            resultado = num1 / num2;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Não existe divisão por zero!"+ ex.Message);
                }
                
                return resultado;
            }
          
           return resultado; 
        }
    }
}


