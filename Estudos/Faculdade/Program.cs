using Faculdade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, qtdProvas;
            Boletim[] boletim = null;
            

            Console.Write("Quantas disciplinas você está fazendo : ");
            n = int.Parse(Console.ReadLine());

            boletim = new Boletim[n];

            for (int i = 0; i < n; i++)
            {
                
                boletim[i] = new Boletim();

                Console.Write("Insira a disciplina : ");
                boletim[i].Disciplina = Console.ReadLine();

                Console.Write("Insira Quantas provas você fez nesta disciplina : ");
                qtdProvas = int.Parse(Console.ReadLine());

                boletim[i].Notas = new double[qtdProvas];

                for (int j = 0; j < qtdProvas; j++)
                {
                    
                    Console.Write($"Insira a sua {j+1}ª nota : ");
                    double aux = (double.Parse(Console.ReadLine()));
                    boletim[i].Notas[j] = aux;


                }

                boletim[i].calculoMedia();
                Console.WriteLine($"{boletim[i].resultado()}");
            }

            

            Console.ReadKey();



        }
    }
}
