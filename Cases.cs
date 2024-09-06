// Importação das bibliotecas
using System;

namespace Calc
{
    // Cria uma classe publica
    public class Cases
    {
        // Metodo que realiza o calculo de acordo com a opção do usuário
        public decimal OperationsSwitch(decimal a, decimal b, int c)
        {
            // Instancia a classe Operations
            Operations op = new Operations();
            decimal result = 0;

            switch (c)
            {
                case 1:
                    result = op.Sum(a, b);
                    break;
                case 2:
                    result = op.Sub(a, b);
                    break;
                case 3:
                    result = op.Mul(a, b);
                    break;
                case 4:
                    result = op.Div(a, b);
                    break;
                default:
                    Console.WriteLine("Operação inválida");
                    break;
            }
            return result;
        }
    }
}