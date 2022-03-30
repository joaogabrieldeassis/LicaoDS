using System;

namespace Licaojoao
{
    class Exercicio27
    {
        static void Main(string[] args)
        {
         int twoNumber =0;  
           while (true)
            {
            int uamNumber = 0;
            char receber;
                Console.WriteLine("Digite o seu valor");
               uamNumber = Convert.ToInt32(Console.ReadLine());
                for (twoNumber = 1; uamNumber > 1 ; uamNumber--)
                {
                    twoNumber = twoNumber * uamNumber;
                   
                }
                Console.WriteLine("O fatorial do seu número é {0}",twoNumber);

                Console.WriteLine("Deseja sair do programa ? \nDigite S para sair ou n para ficar ");
                receber = Convert.ToChar(Console.ReadLine());
                if (receber == 'S' || receber == 's')
                {
                    break;
                }
            }
        }
    }
}
