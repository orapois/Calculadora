// Importação das bibliotecas
using System;

namespace Calc
{
    // Cria uma classe publica com as operações
    public class Operations
    {
        // Metodo de soma
        public decimal Sum(decimal a, decimal b)
        {
            return a + b;
        }

        // Metodo de subtração
        public decimal Sub(decimal a, decimal b)
        {
            return a - b;
        }

        // Metodo de multiplicação
        public decimal Mul(decimal a, decimal b)
        {
            return a * b;
        }

        // Metodo de divisão
        public decimal Div(decimal a, decimal b)
        {
            if(b != 0)
            {
                return a / b;
            }
            else
            {
                Console.WriteLine("Divisão por zero não é permitida.");
                return 0;
            }
            
        }
    }
}