using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace produtos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            string nome;
            double valor;
            Produtos[] vect = null;
            double soma = 0;
            double media = 0.0;


            Console.Write("Qual a quantidade de produtos : ");
            n = int.Parse(Console.ReadLine());

            vect = new Produtos[n];

            //input

            for (int i = 0; i < n; i++)
            {

                Console.Write($"\nInforme o nome do {i + 1}º produto : ");
                nome = Console.ReadLine();

                Console.Write($"Informe o valor do {i + 1}º Produto : R$");
                valor = double.Parse(Console.ReadLine());



                vect[i] = new Produtos { Nome = nome, Valor = valor };
            }

            //soma

            for (int i = 0; i < n; i++)
            {
                soma += vect[i].Valor;
            }

            // media 

            media = soma / n;

            //output

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n======================Produto{i + 1}==========================");

                Console.WriteLine($"Produto {i + 1} : {vect[i].Nome}");
                Console.WriteLine($"Valor do(a) {vect[i].Nome} : {vect[i].Valor}");



            }

            Console.WriteLine("\n====================Média de Compra==========================");
            Console.WriteLine($"A média da compra foi de : {media.ToString("F2")}");

            Console.ReadKey();

        }
    }
}
