using System;
using System.Globalization;

namespace ExercicioFixacao1_POO
{
    internal class Conta
    {
        private string _titular;
        private string _numero;
        public double Saldo;

        public Conta(string titular, string numero)
        {
            _titular = titular;
            _numero = numero;
            Saldo = 0.0; 
        }

        public void depositar(double v)
        {
            if (v <= 0.0)
            {
                Console.WriteLine("Inválido, valor de saque não pode ser menor ou igual 0.0");
            }
            else
            {
                Saldo += v;
            }
        }

        public void sacar(double v)
        {
            if(v <= 0.0)
            {
                Console.WriteLine("Inválido, valor de saque não pode ser menor ou igual 0.0");
            }
            else
            {
                v += 5.0;
                Saldo -= v;
            }
                
        }

        public override string ToString()
        {
            return "Conta: " 
                    + _numero 
                    + ", Titular: " + _titular 
                    + ", Saldo: $ " +  Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
