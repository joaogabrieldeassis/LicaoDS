using System;

namespace Licaojoao
{
    class Exercicio28
    {
        static void Main(string[] args)
        {
          
            double numbers = 100;
            for (int i = 100; i <= 200 ; i++)
            {
                if ((i  % 2)!=0)
                {
                    Console.WriteLine("O número {0} é impar",i);
                }
            }
        }
    }
}
