using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta,decimal saldoInicial)
        {
            NumeroConta=numeroConta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }
        private decimal saldo;
        // private int v1;
        // private double v2;

        public void Sacar(Decimal valor)
        {
            if (valor>saldo)
            {
                Console.WriteLine("Saldo Insificiente");
            }
            else
            {
            saldo -= valor;
            Console.WriteLine("Saldo é : "+saldo+" saque");
            }
        }
        public void Depositar(Decimal valor)
        {
            saldo += valor;
            Console.WriteLine("saldo é : "+saldo+" deposito");
        }
        public void ExibirSaldo()
        {
            Console.WriteLine("saldo : " +saldo);
        }

    }
}