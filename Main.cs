// Importação das bibliotecas
using System;


namespace Calc
{

    class Program
    {        
        static void Main(string[] args)
        {
            // Instancia a classe cases
            Cases cs = new Cases();

            // Imprime no console as operações possiveis
            Console.WriteLine("Escolha uma operação: ");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            
            // Recebe a operção escolhida "Console.ReadLine()" e converte para int 
            int operation = Convert.ToInt32(Console.ReadLine());

            // Solicita o primeiro número para o usuário e converte para decimal
            Console.WriteLine("Digite o primeiro número: ");
            decimal a = Convert.ToDecimal(Console.ReadLine());

            // Solicita o segundo número para o usuário e converte para decimal
            Console.WriteLine("Digite o segundo número: ");
            decimal b = Convert.ToDecimal(Console.ReadLine());

            // Realiza a operação
            decimal result = cs.OperationsSwitch(a, b, operation);

            // Exibe o resultado
            Console.WriteLine($"Resultado: {result}");

        }
    }
}