using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculdade
{
    internal class Boletim
    {
        public string Disciplina { get; set; } 
        public double[] Notas { get; set; }
    
        public double Media { get; set; }

        public void calculoMedia()
        {
            double somaNotas = 0.0;

            for(int i = 0; i < Notas.Length; i++)
            {

                somaNotas += Notas[i]; 
            }

            Media = somaNotas / Notas.Length;
        }
        //public void pesoDisc()
        //{
        //    Media = ((Nota1 * 3) + (Nota2 * 3) + (Nota3 * 4)) / 10;
        //}
        public string resultado()
        {
            if(Media >= 7)
            {
                return "Aprovado!";
            }
            else if(Media >= 5 )
            {
                return "Recuperação!";
            }
            else
            {
                return "Reprovado";
            }
        }





    }
}
