using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[5];
            double[] peso = new double[5];
            double[] altura = new double[5];
            double[] IMC = new double[5];
            Double IMCa = 0;
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Insira o nome: ");
                nome[i] = Console.ReadLine();
                Console.WriteLine("Insira o peso: ");
                peso[i] = Double.Parse(Console.ReadLine());
                Console.WriteLine("Insira a altura: ");
                altura[i] = Double.Parse(Console.ReadLine());
                IMC[i] = peso[i] / (Math.Pow(altura[i], 2));

               
                
            }

            for (int j = 0; j <= 4; j++)
            {
                Console.WriteLine("Nome: " + nome[j]);
                Console.WriteLine("Peso: " + peso[j]);
                Console.WriteLine("Altura: " + altura[j]);
                if (IMC[j] > 24.9 && IMC[j] <= 29.9)
                {
                    IMCa = IMCa + 1;

                    Console.WriteLine("IMC: " + IMC[j]);
                    Console.WriteLine("Classificação: Levemente acima do peso");

                }
                else if (IMC[j] >= 18.6 && IMC[j] <= 24.9)
                {
                    Console.WriteLine("IMC: " + IMC[j]);
                    Console.WriteLine("Classificação: Parabéns, peso ideal! :)");

                }
                else if (IMC[j] < 18.6)
                {
                    Console.WriteLine("IMC: " + IMC[j]);
                    Console.WriteLine("Classificação: Abaixo do peso");

                }
                else if (IMC[j] > 29.9 && IMC[j] < 35)
                {
                    IMCa = IMCa + 1;
                    Console.WriteLine("IMC: " + IMC[j]);
                    Console.WriteLine("Classificação: Obesidade Grau I");

                }
                else if (IMC[j] > 34.9 && IMC[j] < 40)
                {
                    IMCa = IMCa + 1;
                    Console.WriteLine("IMC: " + IMC[j]);
                    Console.WriteLine("Classificação: Obesidade Grau II(severa)");

                }
                else if (IMC[j] >= 40)
                {
                    IMCa = IMCa + 1;
                    Console.WriteLine("IMC: " + IMC[j]);
                    Console.WriteLine("Classificação: Obesidade III(mórbida)");

                }
                else Console.WriteLine("Entrada inválida :(, por favor certifique-se de digitar os nomes, pesos e alturas correatamente.");
              
            }
            Console.WriteLine("O percentual de pessoas acima do peso ideal é de: " + IMCa / 5*100 + "%");
            Console.ReadKey();
        }
    }
}
