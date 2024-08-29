using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public  class Professor : Pessoa
    {
        public Professor()
        {
            
        }
        public Professor(string nome) : base(nome)
        {
        }

        public double Salario { get; set; }
        public sealed override void Apresentar()  // polimorfismo em apresentar
        {
                Console.WriteLine($"Olá, me chamo {Nome} e tenho {Idade} anos! sou professor e ganho  {Salario}");
        }
 
    }
}