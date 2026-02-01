using System;
using System.Globalization; 

namespace ExercicioFixacao1_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor = 0.0; 

            Console.Write("Entre o número da conta: ");
            string numero = Console.ReadLine();
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Conta c = new Conta(titular, numero); 

            Console.Write("Haverá depósito inicial (s/n)? ");
            char d = char.Parse(Console.ReadLine());
            
            if(d == 's' || d == 'S')
            {
                Console.Write("\nEntre o valor de depósito inicial: ");
                valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                c.depositar(valor);
                Console.WriteLine("\nDados da conta: ");
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine("\nDados da conta: ");
                Console.WriteLine(c);
            }

            Console.Write("Entre um valor para depósito: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.depositar(valor);
            Console.WriteLine("\nDados da conta atualizados:");
            Console.WriteLine(c);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.sacar(valor);
            Console.WriteLine("\nDados da conta atualizados: ");
            Console.WriteLine(c);

        }
    }
}