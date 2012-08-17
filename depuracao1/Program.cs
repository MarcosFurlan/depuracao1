using System;
using System.Collections.Generic;

using System.Text;

namespace depuracao1
{
    class Program
    {
        static float Dividir(int n, int d)
        {
            return n / d;
        }
        static int Mudar(int m)
        {
            m = m + 1;
            return m;
        }
        static void Main(string[] args)
        {
           
            int numero = 0;
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("O numero escolhido é: {0}", numero);
            numero = Mudar(numero);
            Console.WriteLine("O numero modificado é: {0}", numero);
            

            int denominador;
            denominador = int.Parse(Console.ReadLine());
            if (denominador == 0)
            {
                Console.WriteLine("Não exite divisão por zero");
                denominador = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("O quociente entre {0} e {1} é {2}", numero, denominador, Dividir(numero, denominador));

            int[] vetor = new int [3];
            vetor[0] = int.Parse(Console.ReadLine());
            vetor[1] = int.Parse(Console.ReadLine());
            vetor[2] = int.Parse(Console.ReadLine());
            for (int c = 0; c < vetor.Length; c++)
                Console.Write("{0}", vetor[c]);
           
          /*  int[] v = null ;
            string n2 = "Nada" + v[0];
           Aqui acontece uma exceção por tentar acessar valor nulo
           */

            Console.Read();


        }
    }
}
