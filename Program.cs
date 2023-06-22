using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motores
{
    internal class Program
    {
  
        
            static double[] motores;
            static void lancarValor()
            {
                int motor;
                double valor;

                do
                {
                    Console.WriteLine("Qual motor será reparado?");
                    motor = int.Parse(Console.ReadLine());
                }
                while (motor < 1 || motor > 15);

                Console.WriteLine("Qual o Valor Gasto: ");
                valor = double.Parse(Console.ReadLine());

                motores[motor - 1] += valor;
                Console.WriteLine("Valor registrado com sucesso");


            }

            static void mostrarValores()
            {
                double t = 0;
                int i;
                for (i = 0; i < 15; i++)
                {
                    Console.WriteLine("O Motor {0} teve gasto de {1}", i + 1, motores[i]);
                    t += motores[i];
                }

                Console.WriteLine("A soma dos valores é {0}", t);
            }

            static void maiorGasto()

            {
                int qualmaior = 0;
                int i;
                int maior;
                maior = (int)motores[qualmaior];

                for (i = 1; i < 14; i++)

                    if (motores[i] > maior)
                    {
                        qualmaior = i;
                        maior = (int)motores[i];
                    }

                Console.WriteLine("O Motor com maior valor é {0}", qualmaior + 1);

            }

            static void Main(string[] args)
            {


                motores = new double[15];

                int opcao;

                do
                {
                    Console.WriteLine("0. Sair");
                    Console.WriteLine("1. Lançar Valor");
                    Console.WriteLine("2. Mostrar Valores");
                    Console.WriteLine("3. Informar o maior gasto");
                    Console.WriteLine();
                    Console.Write("Escolha sua opção: ");
                    opcao = int.Parse(Console.ReadLine());

                    if (opcao == 1)
                    {
                        lancarValor();
                    }

                    if (opcao == 2)
                    {
                        mostrarValores();
                    }

                    if (opcao == 3)
                    {
                        maiorGasto();
                    }
                }
                while (opcao != 0);
            }
    }
}
