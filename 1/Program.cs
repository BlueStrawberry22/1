using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Lógica_de_programação
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string NomeAluno;
            double NotaTrabalho, NotaProva1, NotaProva2, Resultado;

            Console.Write("Insira o nome do aluno: ");
            NomeAluno = Console.ReadLine();

            Console.Write("Insira a nota do Trabalho: ");
            NotaTrabalho = double.Parse(Console.ReadLine());

            Console.Write("Insira a nota da primeira prova: ");
            NotaProva1 = double.Parse(Console.ReadLine());

            Console.Write("Insira a nota da segunda prova: ");
            NotaProva2 = double.Parse(Console.ReadLine());

            Resultado = (NotaTrabalho + NotaProva1 + NotaProva2) / 3;
            Console.WriteLine("Média: " + Resultado);

            if (Resultado >= 8.50 && Resultado <= 10)
            {
                Console.WriteLine("Parabéns, você foi aprovado!");
                Console.Write("Conceito: A");
            }
            else if (Resultado >= 7.0 && Resultado <= 8.4)
            {
                Console.WriteLine("Parabéns, você foi aprovado!");
                Console.WriteLine("Conceito: B");
            }
            else if (Resultado >= 6.0 && Resultado <= 6.9)
            {
                Console.WriteLine("Parabéns, você foi aprovado!");
                Console.WriteLine("Conceito: C");
            }
            else if (Resultado >= 0.1 && Resultado <= 5.9)
            {
                Console.WriteLine("Reprovado.");
                Console.WriteLine("Conceito: D");
            }
            else if (Resultado == 0.0)
            {
                Console.WriteLine("Reprovado.");
                Console.WriteLine("Conceito: E");
            }


            Console.ReadLine();

        }
    }
}
