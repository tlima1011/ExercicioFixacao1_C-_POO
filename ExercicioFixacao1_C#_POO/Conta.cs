using System;
using System.Globalization;

namespace ExercicioFixacao1_POO
{
    internal class Conta
    {
        public string Titular;
        public string Numero;
        public double Saldo;

        public Conta(string titular, string numero)
        {
            Titular = titular;
            Numero = numero;
            Saldo = 0.0; 
        }

        public void depositar(double v)
        {
            Saldo += v;
        }

        public void sacar(double v)
        {
            Saldo -= v;
        }

        public override string ToString()
        {
            return "Conta: " 
                    + Numero 
                    + ", Titular: " + Titular 
                    + ", Saldo: $ " +  Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
