using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public abstract class Conta   // classe abstrata
    {
        protected decimal saldo { get; set; }

        public abstract void Creditar(decimal valor); // metodo abstrato
        public void ExibirSaldo()
        {
            Console.WriteLine("O seu saldo é "+ saldo);
        }


    }
}