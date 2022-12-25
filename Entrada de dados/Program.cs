using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrada_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            // DESCOBRIR QUAL NUMERO É MENOR


            int N1;
            int N2;
            int N3;

            Console.WriteLine("Vamos descobrir qual numero de entrada é menor \n");
            Console.WriteLine("Coloque seu primeiro numero");
            N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Coloque seu segundo numero");
            N2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Coloque seu terceiro numero");
            N3 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            if(N1 < N2 & N1 < N3)
            {
                Console.WriteLine("O primeiro numero é menor");

            } else if(N2 < N1 && N2 < N3)
            {
                Console.WriteLine("O segudo numero é menor");

            } else if (N3 < N1 && N3 < N2)
            {
                Console.WriteLine("O terceiro numero é menor");

            } else if(N1 == N2 & N2 == N3 & N1 == N3)
            {
                Console.WriteLine("Todos os numeros são iguais");

            } else
            {
                Console.WriteLine("Erro encotrado");
            }

            Console.WriteLine("__________________________________________________ \n");
            // DESCOBRIR QUAL NUMERO É MAIOR


            Console.WriteLine("Vamos descobrir qual numero de entrada é maior \n");
            Console.WriteLine("Coloque seu primeiro numero");
            N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Coloque seu segundo numero");
            N2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Coloque seu terceiro numero");
            N3 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            if (N1 > N2 & N1 > N3)
            {
                Console.WriteLine("O primeiro numero é maior");

            }
            else if (N2 > N1 && N2 > N3)
            {
                Console.WriteLine("O segudo numero é maior");

            }
            else if (N3 > N1 && N3 > N2)
            {
                Console.WriteLine("O terceiro numero é maior");

            }
            else if (N1 == N2 & N2 == N3 & N1 == N3)
            {
                Console.WriteLine("Todos os numeros são iguais");

            }
            else
            {
                Console.WriteLine("Erro encotrado");
            }

            Console.WriteLine("__________________________________________________ \n");
            
            // UMA ESCALA DE 0 Á 10 COM OS NÍVEIS DE URGÊNCIA


            Console.WriteLine("Em uma escala de 0 até 10 escolha o nível de urgência \n");
            int urgencia = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            if(urgencia >= 0 && urgencia <= 3)
            {
                Console.WriteLine("Seu nível de urgência é considerado: Baixo");

            } else if(urgencia >= 4 && urgencia <= 7)
            {
                Console.WriteLine("Seu nível de urgência é considerado: Medio");

            } else if(urgencia >= 8 && urgencia <= 10)
            {
                Console.WriteLine("Seu nível de urgência é considerado: Alto");

            } else
            {
                Console.WriteLine("Seu nível de urgência não encotrado");

            }




            Console.ReadLine();


        }
    }
}
