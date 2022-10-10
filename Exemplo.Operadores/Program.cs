using System;

namespace Exemplo.Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Qual é a sua idade?");
                int idade = int.Parse(Console.ReadLine());
                
                //se idade é menor igual a 12 exibe a mensagem vc é uma criança
                if (idade <= 12)
                {
                    Console.WriteLine("Você é uma criança!");
                }
                //se idade é menor igual a 17 exibir mensagem vc é um adolecente
                else if (idade <= 17)
                {
                    Console.WriteLine("Você é um adolescente!");
                }
                // se não vc é um adulto
                else
                {
                    Console.WriteLine("Você é um adulto!");
                }
            }
            catch
            {
                Console.WriteLine("Valor informado inválido.");
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
