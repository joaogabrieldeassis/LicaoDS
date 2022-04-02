using System;

namespace Licaojoao
{
    class Exercicio32
    {
        static void Main(string[] args)
        {
            int number = 0;
            int recebeNumber = 0;
            int somaQuadrados = 0;
            int contador = 0;
            
            
            
                while (contador<20)
                {
                    if (number >= 0 && number <= 10)
                    {
                    Console.WriteLine("Digite um número de 0 a 10");
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number % 2 != 0)
                    {
                        recebeNumber = number * number;
                         contador ++;
                        somaQuadrados += recebeNumber;
                    }
                    }
                }
               
                Console.WriteLine("A soma dos quadrados é {0}", somaQuadrados);
            
        }
    }
}