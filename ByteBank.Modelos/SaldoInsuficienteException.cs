using System;
using System.Runtime.Serialization;

namespace ByteBank.Modelos.Funcionários
{
    [Serializable]
    internal class SaldoInsuficienteException : Exception
    {
        private double saldo;
        private double valor;

        public SaldoInsuficienteException()
        {
        }

        public SaldoInsuficienteException(string message) : base(message)
        {
        }

        public SaldoInsuficienteException(double saldo, double valor)
        {
            this.saldo = saldo;
            this.valor = valor;
        }

        public SaldoInsuficienteException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SaldoInsuficienteException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}