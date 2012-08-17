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
            Console.Read();


        }
    }
}
