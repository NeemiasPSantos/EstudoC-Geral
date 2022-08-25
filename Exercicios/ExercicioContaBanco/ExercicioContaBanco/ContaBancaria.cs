using System;
using System.Globalization;

namespace ExercicioContaBanco
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        private double _saldo;

        public ContaBancaria()
        {
        }

        public ContaBancaria(string titular, int numero)
        {
            Numero = numero;
            Titular = titular;
        }

        public double Saldo
        {
            get { return _saldo; }
            set
            {
                if (value > 0)
                {
                    _saldo = value;
                }
            }
        }

        public void Deposito(double quantia)
        {
            _saldo += quantia;
        }
        public void Saque(double quantia)
        {
            _saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: "
                + _saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}


