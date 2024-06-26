﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrayImc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] nome = new String[5];
            double[] peso = new double[5]; 
            double[] altura = new double[5];
            double[] imc = new double[5];
            double cont = 0;

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Nome: ");
                nome[i] = Console.ReadLine();
                Console.WriteLine("Peso: ");
                peso[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Altura: ");
                altura[i] = double.Parse(Console.ReadLine());

                imc[i] = peso[i] / (altura[i] * altura[i]);

            }

            

            for (int j = 0; j <= 4; j++)
            {

                if (imc[j] <= 18.5)
                {
                    Console.WriteLine("Abaixo do peso");
                }
                else if (imc[j] <= 24.9)
                {
                    Console.WriteLine("Peso ideal");
                }
                else if (imc[j] <= 29.9)
                {
                    Console.WriteLine("Levemente acima do peso");
                    cont++;
                }
                else if (imc[j] <= 34.9)
                {
                    Console.WriteLine("Obesidade grau I");
                    cont++;
                }
                else if (imc[j] <= 39.9)
                {
                    Console.WriteLine("Obesidade grau II (severa)");
                    cont++;
                }
                else if (imc[j] > 40)
                {
                    Console.WriteLine("Obesidade grau III (mórbida)");
                    cont++;
                }

                Console.WriteLine("NOME: " + nome[j] + "  PESO: " + peso[j] + "  ALTURA: " + altura[j] + "  IMC: " + imc[j]);
                
            }
            Console.WriteLine("O número de pessoas que estam acima do peso é de " + (cont/5) * 100 + "%");


            Console.ReadKey();

        }
    }
}
